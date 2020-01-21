using ElasticSearchFormats;
using FisMSSqlClient;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBFormats;
using Neo4jClient;
using Neo4jClient.Transactions;
using Neo4jFormats;// ЭТО МОЕ
using Nest;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyOnlineCinema
{
    public partial class MainMenu : Form
    {
        DataBaseManager dataBase;
        int userId = -1;
        List<int> idsOfSubs;
        List<string> namesOfSubs;

        public MainMenu()
        {
            InitializeComponent();
        }

        IGraphClient neo4j;
        ITransactionalGraphClient _client;
        ConnectionMultiplexer redis;
        IDatabase redisdb;
        MongoClient mongoclient;
        IMongoDatabase mongodb;
        ElasticClient elasticClient;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.authMenu.Hide();
            this._userControlPanel.Hide();
            this._mySubsPanel.Hide();
            this._myFilmsPanel.Hide();
            dataBase = new DataBaseManager();
            neo4j = new GraphClient(new Uri("http://192.168.99.100.:7474/db/data"), "neo4j", "password");
            neo4j.Connect();

            redis = ConnectionMultiplexer.Connect("192.168.99.100:6379");//просто подключение к редис, без входа в redis-cli
            redisdb = redis.GetDatabase(0); //в redis от 0 до 15 баз данных, по умолчанию всегда в 0
            redisdb.StringSet("demo", "helloworld"); //https://stackexchange.github.io/StackExchange.Redis/Basics.html -- redis

            elasticClient = new ElasticClient(new ConnectionSettings(new Uri("http://192.168.99.100:9200")).DefaultIndex("filmdesc"));

            string connectionString = "mongodb://192.168.99.100:27017";
            mongoclient = new MongoClient(connectionString);
            mongodb = mongoclient.GetDatabase("cinemastore");
            _lookMode.SelectedIndex = 0;
        }

        private void LoadNewReleases()
        {
            _filmsPanel.Controls.Clear();
            List<string> keys = new List<string>();
            // get the target server
            var server = redis.GetServer("192.168.99.100:6379");

            // show all keys in database 0 that include "films" in their name
            foreach (var key in server.Keys(pattern: "films:*"))
            {
                keys.Add(key);
            }
            var list = mongodb.GetCollection<Films>("films");
            List<string> boughtFilms = neo4j.Cypher
                .OptionalMatch("(film:Film)-[:BUY]-(user:User)")
                .Where((User user) => user.id == userId)
                .Return(film => film.As<Film>()._id).Results.ToList();
            foreach (string key in keys)
            {
                var value = redisdb.StringGet(key);
                var filter = new BsonDocument("_id", ObjectId.Parse(value));
                List<Films> mylist = list.Find(filter).ToList();
                foreach (Films film in mylist)
                {           
                    _filmsPanel.Controls.Add(GenerateFilmPanel(film, boughtFilms));
                }
            }
        }

        private void LoadAllReleases()
        {
            _filmsPanel.Controls.Clear();
            var list = mongodb.GetCollection<Films>("films");
            List<string> boughtFilms = neo4j.Cypher
                .OptionalMatch("(film:Film)-[:BUY]-(user:User)")
                .Where((User user) => user.id == userId)
                .Return(film => film.As<Film>()._id).Results.ToList();
            var filter = new BsonDocument();
            List<Films> mylist = list.Find(filter).ToList();
            foreach (Films film in mylist)
            {
                _filmsPanel.Controls.Add(GenerateFilmPanel(film, boughtFilms));
            }
        }

        private Panel GenerateFilmPanel(Films content, List<string> boughtFilms)
        {
            DataTable data = dataBase.TableQueryResponser("SELECT Name FROM [Subscription] WHERE id_Subscription = " + content.subscription_id);
            if(data == null)
            {
                MessageBox.Show("Ошибка при загрузке новых релизов");
                return null;
            }
            Panel panel = new Panel();
            panel.BackColor = SystemColors.Window;
            panel.Font = new Font("Times New Roman", 13f);
            panel.Width = 200;
            panel.Height = 300;
            panel.Tag = content.id.ToString();
            Label releaseLabel = new Label();
            releaseLabel.AutoSize = false;
            releaseLabel.Width = 200;
            releaseLabel.TextAlign = ContentAlignment.MiddleCenter;
            releaseLabel.Text = content.releaseDate.ToString("dd.MM.yyyy");
            releaseLabel.Font = new Font("Times New Roman", 13f);
            panel.Controls.Add(releaseLabel);
            releaseLabel.Dock = DockStyle.Top;
            Label label = new Label();
            label.AutoSize = false;
            label.Width = 200;
            label.BackColor = Color.Teal;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.MaximumSize = new Size(200,0);
            label.MinimumSize = new Size(200, 0);
            label.AutoSize = true;
            label.Text = content.name;
            label.ForeColor = Color.White;
            label.Font = new Font("Times New Roman", 13f);
            label.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(label);
            label.Dock = DockStyle.Top;
            Label ratingLabel = new Label();
            ratingLabel.AutoSize = false;
            ratingLabel.Width = 200;
            ratingLabel.ForeColor = Color.Teal;
            ratingLabel.TextAlign = ContentAlignment.MiddleCenter;
            ratingLabel.Text = "Рейтинг " + content.rating.ToString();
            ratingLabel.Font = new Font("Times New Roman", 13f);
            panel.Controls.Add(ratingLabel);
            ratingLabel.Dock = DockStyle.Bottom;
            Label subsriptionText = null;
            if (data.Rows.Count > 0)
            {
                subsriptionText = new Label();
                subsriptionText.AutoSize = false;
                subsriptionText.Width = 200;
                subsriptionText.ForeColor = Color.Teal;
                subsriptionText.TextAlign = ContentAlignment.MiddleCenter;
                subsriptionText.Text = "Доступен по подписке " + data.Rows[0][0].ToString();
                subsriptionText.Font = new Font("Times New Roman", 11f);
                panel.Controls.Add(subsriptionText);
                subsriptionText.Dock = DockStyle.Bottom;
            }
            int index = boughtFilms.IndexOf(content.id.ToString());
            Button button = new Button();
            button.Width = 200;
            button.Height = 30;
            button.BackColor = Color.Teal;
            button.ForeColor = Color.White;
            if(index < 0)
            {
                button.Text = "Купить за " + content.price + " руб.";
                button.Click += _buyBTN_Click;
            }
            else
            {
                button.Text = "Смотреть";
            }
            panel.Controls.Add(button);
            panel.DoubleClick += _panel_DoubleClick;
            button.Dock = DockStyle.Bottom;
            button.Tag = content.id.ToString();
            ToolTip toolTip = new ToolTip();
            toolTip.ForeColor = Color.Black;
            toolTip.SetToolTip(panel, "Кликните дважды чтобы посмотреть описание");
            return panel;
        }

        private void _panel_DoubleClick(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            FilmInfo filmInfo = new FilmInfo(panel.Tag.ToString(), userId);
            filmInfo.ShowDialog();
            _lookMode_SelectedIndexChanged(sender, e);
        }

        private void _buyBTN_Click(object sender, EventArgs e)
        {
            if(userId < 0)
            {
                MessageBox.Show("Сначала авторизуйтесь");
                return;
            }
            Button btn = sender as Button;
            var list = mongodb.GetCollection<Films>("films");
            var filter = new BsonDocument("_id", ObjectId.Parse(btn.Tag.ToString()));
            List<Films> mylist = list.Find(filter).ToList();
            BuyFilm buyFilm = new BuyFilm(userId.ToString(), btn.Tag.ToString() ,mylist.ElementAt(0).price);
            buyFilm.ShowDialog();
        }

        private void _showMenuBTN_Click(object sender, EventArgs e)
        {
            if(authMenu.Visible)
            {
                authMenu.Hide();
            }
            else
            {
                authMenu.Show();
            }
            if (_mySubsPanel.Visible)
                _mySubsPanel.Hide();
            if (_myFilmsPanel.Visible)
                _myFilmsPanel.Hide();
        }

        private void _authBTN_Click(object sender, EventArgs e)
        {
            if (_loginTB.Text == "admin" && _passwordTB.Text == "AdminBoss")
            {
                AdminSQLPanel admin = new AdminSQLPanel();
                admin.ShowDialog();
            }
            else
            {
                DataTable data = dataBase.TableQueryResponser("SELECT * FROM [User] WHERE Login = '" + _loginTB.Text + "' AND PassHash = '" + _passwordTB.Text.GetHashCode() + "'");
                if(data.Rows.Count == 0)
                {
                    MessageBox.Show("Неправильный логин или пароль.");
                    return;
                }
                else
                {
                    userId = Convert.ToInt32(data.Rows[0][0].ToString());
                    MessageBox.Show("Добро пожаловать, что посмотрим сегодня?");
                    Authorization(userId);
                }
            }
            LoadNewReleases();
        }

        private void _registerBTN_Click(object sender, EventArgs e)
        {
            Registry registry = new Registry(this);
            registry.Show();
        }

        public void Authorization(int id)
        {
            userId = id;
            DataTable table = dataBase.TableQueryResponser("SELECT * FROM [User] WHERE id_User =" + userId);
            if (table == null)
                MessageBox.Show("Что-то пошло не так, повторите авторизацию.");
            else if(table.Rows.Count == 0)
            {
                MessageBox.Show("Такой пользователь не зарегистрирован");
            }
            else if(table.Rows.Count > 0)
            {
                _authGB.Hide();
                _userControlPanel.Show();
                _usernameLbl.Text = table.Rows[0]["Name"].ToString(); //"name" = 3 поле
            }
        }

        private void _exitBTN_Click(object sender, EventArgs e)
        {
            userId = -1;
            _usernameLbl.Text = "{username}";
            _userControlPanel.Hide();
            _authGB.Show();
            if(_mySubsPanel.Visible)
            {
                _mySubsPanel.Hide();
            }
            if (_myFilmsPanel.Visible)
                _myFilmsPanel.Hide();
            LoadNewReleases();
        }

        private void _mySubsBTN_Click(object sender, EventArgs e)
        {
            if(_mySubsPanel.Visible)
            {
                _mySubsPanel.Hide();
            }
            else
            {
                _mySubsPanel.Show();
            }
            if (_myFilmsPanel.Visible)
                _myFilmsPanel.Hide();
            LoadUserSubsInfo();
            LoadAvailableSubs();
        }

        private void LoadUserSubsInfo()
        {
            if (userId == -1)
            {
                MessageBox.Show("Как вы тут оказались?");
                return;
            }
            DataTable data = dataBase.TableQueryResponser("SELECT s.Name as 'Название подписки', u.Buydate as 'Дата покупки', u.Enddate as 'Дата окончание действия подписки' FROM UsersSubs as u INNER JOIN [Subscription] as s ON u.id_Subscription = s.id_Subscription WHERE id_User = " + userId);
            if(data == null)
            {
                MessageBox.Show("Ошибка чтения списка подписок");
                return;
            }
            _userSubsGV.DataSource = data.DefaultView;
            _userSubsGV.ForeColor = Color.Black;
        }

        private void LoadAvailableSubs()
        {
            DataTable data = dataBase.TableQueryResponser("SELECT id_Subscription, Name as 'Название подписки', Price as 'Цена' FROM Subscription WHERE Price >= 0");
            if (idsOfSubs == null)
            {
                idsOfSubs = new List<int>();
                namesOfSubs = new List<string>();
            }
            else
            {
                namesOfSubs.Clear();
                idsOfSubs.Clear();
            }
            foreach (DataRow row in data.Rows)
            {
                idsOfSubs.Add(Convert.ToInt32(row[0].ToString()));
                namesOfSubs.Add(row[1].ToString());
            }
            data.Columns.RemoveAt(0);
            _allSubsGV.DataSource = data.DefaultView;
            _allSubsGV.ForeColor = Color.Black;
        }

        private void _buySubBTN_Click(object sender, EventArgs e)
        {
            int id = _allSubsGV.CurrentCell.RowIndex;
            DataGridViewRow row = _allSubsGV.Rows[id];
            string name = row.Cells[0].Value.ToString();
            int elId = namesOfSubs.IndexOf(name);
            if(id < 0)
            {
                MessageBox.Show("Выберите подписку для покупки/продления");
                return;
            }
            DataTable data = dataBase.TableQueryResponser("SELECT * FROM [Subscription] WHERE id_Subscription = " + idsOfSubs.ElementAt(elId));
            BuySub buySub = new BuySub(userId, idsOfSubs.ElementAt(elId), Convert.ToInt32(data.Rows[0]["Price"].ToString()));
            buySub.ShowDialog();
            LoadUserSubsInfo();
        }

        private void _myPaymentsBTN_Click(object sender, EventArgs e)
        {
            if (_myFilmsPanel.Visible)
            {
                _myFilmsPanel.Hide();
            }
            else
            {
                _myFilmsPanel.Show();
                LoadUserBuyments();
            }
            if (_mySubsPanel.Visible)
                _mySubsPanel.Hide();
        }

        private void LoadUserBuyments()
        {
            List<Film> filmIdList = neo4j.Cypher
                .OptionalMatch("(film:Film)-[:BUY]-(user:User)")
                .Where((User user) => user.id == userId)
                .Return(film => film.As<Film>()).Results.ToList();
            if(filmIdList.ElementAt(0) == null)
            {
                return;
            }
            List<BuyInfo> buyInfoList = neo4j.Cypher
                .OptionalMatch("(film:Film)-[buy:BUY]-(user:User)")
                .Where((User user) => user.id == userId)
                .Return(buy => buy.As<BuyInfo>()).Results.ToList();
            var collection = mongodb.GetCollection<Films>("films");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Название фильма"));
            dataTable.Columns.Add(new DataColumn("Дата выхода"));
            dataTable.Columns.Add(new DataColumn("Рейтинг"));
            dataTable.Columns.Add(new DataColumn("Дата покупки"));
            int i = 0;
            foreach (Film film in filmIdList)
            {
                var filter = new BsonDocument("_id", ObjectId.Parse(film._id));
                List<Films> mylist = collection.Find(filter).ToList();
                foreach (Films filmDoc in mylist)
                {
                    DataRow row = dataTable.NewRow();
                    row[0] = filmDoc.name;
                    row[1] = filmDoc.releaseDate.ToString("dd-MM-yyyy");
                    row[2] = filmDoc.rating.ToString();
                    row[3] = buyInfoList.ElementAt(i).date;
                    dataTable.Rows.Add(row);
                }
                ++i;
            }
            _myFilmGV.DataSource = dataTable;
            _myFilmGV.ForeColor = Color.Black;
        }

        private void _lookMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_lookMode.SelectedIndex == 0)
            {
                _searchBTN.Hide();
                _searchTB.Hide();
                LoadNewReleases();
            }
            else if(_lookMode.SelectedIndex == 1)
            {
                _searchBTN.Hide();
                _searchTB.Hide();
                LoadAllReleases();
            }
            else
            {
                _searchTB.Show();
                _searchBTN.Show();
            }
        }

        private void _searchBTN_Click(object sender, EventArgs e)
        {
            if(_searchTB.Text == string.Empty)
            {
                MessageBox.Show("Введите часть описания фильма");
                LoadAllReleases();
            }
            else
            {
                var searchResponce = elasticClient.Search<FilmDescription>
                (desc => desc
                .From(0)
                .Query(q => q
                    .Match(match => match
                        .Field(field => field.Description)
                        .Query("*"+ _searchTB.Text + "*")
                        )
                    )
                );
                var descriptions = searchResponce.Documents;
                _filmsPanel.Controls.Clear();
                List<string> boughtFilms = neo4j.Cypher
                    .OptionalMatch("(film:Film)-[:BUY]-(user:User)")
                    .Where((User user) => user.id == userId)
                    .Return(film => film.As<Film>()._id).Results.ToList();
                var list = mongodb.GetCollection<Films>("films");
                foreach (FilmDescription el in descriptions.ToList())
                {
                    var filter = new BsonDocument("_id", ObjectId.Parse(el.id));
                    List<Films> mylist = list.Find(filter).ToList();
                    foreach (Films film in mylist)
                    {
                        _filmsPanel.Controls.Add(GenerateFilmPanel(film, boughtFilms));
                    }
                }
                if(descriptions.Count == 0)
                {
                    MessageBox.Show("Похоже по вашему запросу ничего не найдено");
                }
            }
        }
    }
}
