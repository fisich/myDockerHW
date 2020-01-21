using ElasticSearchFormats;
using FisMSSqlClient;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBFormats;
using Neo4jClient;
using Neo4jClient.Transactions;
using Neo4jFormats;
using Nest;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyOnlineCinema
{
    public partial class AdminSQLPanel : Form
    {
        DataBaseManager dataBase;
        List<int> idsOfCountries;
        List<int> idsOfCities;
        List<int> idsOfSubs;
        List<int> idsOfPeople;
        List<string> idsOfFilms;
        MongoClient mongoclient;
        IMongoDatabase mongodb;
        ConnectionMultiplexer redis;
        IDatabase redisdb;
        ITransactionalGraphClient _client;
        ElasticClient elasticClient;

        public AdminSQLPanel()
        {
            InitializeComponent();
            dataBase = new DataBaseManager();
            string connectionString = "mongodb://192.168.99.100:27017";
            mongoclient = new MongoClient(connectionString);
            _client = new GraphClient(new Uri("http://192.168.99.100.:7474/db/data"), "neo4j", "password");
            _client.Connect();
            elasticClient = new ElasticClient(new ConnectionSettings(new Uri("http://192.168.99.100:9200")).DefaultIndex("filmdesc"));
            LoadCountryList();
            LoadSubscriptionList();
            LoadPeopleList();
            LoadFilmList();
        }

        private void addCountryBTN_Click(object sender, EventArgs e)
        {
            if (_countryTB.Text == string.Empty)
                return;
            dataBase.QueryInserter("INSERT INTO Country (Name) VALUES ('" + _countryTB.Text.Replace("'", "''") + "')");
            _countryTB.Text = string.Empty;
            LoadCountryList();
        }
        
        public void LoadCountryList()
        {
            DataTable data = dataBase.TableQueryResponser("SELECT * FROM Country");
            if (data == null)
            {
                MessageBox.Show("Нет стран");
                return;
            }
            if (idsOfCountries == null)
                idsOfCountries = new List<int>();
            else
                idsOfCountries.Clear();
            _countryCB.Items.Clear();
            _countryCB2.Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                idsOfCountries.Add(Convert.ToInt32(row[0].ToString()));
                _countryCB.Items.Add(row[1].ToString());
                _countryCB2.Items.Add(row[1].ToString());
            }
        }

        public void LoadCityList()
        {
            if (dataBase == null)
                dataBase = new DataBaseManager();
            if (_countryCB2.SelectedIndex < 0)
                return;
            DataTable data = dataBase.TableQueryResponser("SELECT * FROM City WHERE id_Country =" + idsOfCountries.ElementAt(_countryCB2.SelectedIndex).ToString());
            if (data == null)
            {
                MessageBox.Show("Похоже администратор не добавил города, напишите в поддержку");
                return;
            }
            if (idsOfCities == null)
                idsOfCities = new List<int>();
            else
                idsOfCities.Clear();
            _cityCB.Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                idsOfCities.Add(Convert.ToInt32(row[0].ToString()));
                _cityCB.Items.Add(row[2].ToString());
            }
        }

        private void addCityBTN_Click(object sender, EventArgs e)
        {
            if(_countryCB.SelectedIndex < 0)
            {
                return;
            }
            if (_cityTB.Text == string.Empty)
                return;
            dataBase.QueryInserter("INSERT INTO City (id_Country, Name) VALUES (" + idsOfCountries.ElementAt(_countryCB.SelectedIndex) + ", '"+ _cityTB.Text.Replace("'", "''") + "')");
            _cityTB.Text = string.Empty;
            LoadCityList();
        }

        private void addSubBTN_Click(object sender, EventArgs e)
        {
            DataTable data = dataBase.TableQueryResponser("SELECT * FROM [Subscription] WHERE Name = '" + _subNameTB + "'");
            if (data.Rows.Count == 0)
            {
                dataBase.QueryInserter("INSERT INTO [Subscription] (Name, Price) VALUES ('" + _subNameTB.Text + "'," + _priceUD.Value.ToString() + ")");
            }
            else
            {
                dataBase.QueryInserter("UPDATE [Subscription] SET Price =" + _priceUD.Value.ToString() + " WHERE Name = '" + _subNameTB.Text + "'");
            }
            _subNameTB.Text = string.Empty;
            _priceUD.Value = 0;
        }

        private void _addPeopleBTN_Click(object sender, EventArgs e)
        {
            if (_surnameTB.Text == string.Empty || _nameTB.Text == string.Empty)
            {
                MessageBox.Show("Кажется, вы не ввели Фамилию и/или имя");
                return;
            }
            else if (_dieDateTP.Value.Year - _birthDateTP.Value.Year < 0)
            {
                MessageBox.Show("Кажется, у вас ошибка с датой");
                return;
            }
            else if (_countryCB.SelectedIndex < 0 || _cityCB.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбраны страна и город", "Упс, что-то не ввели", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(_dieChB.Checked == true)
            {
                dataBase.QueryInserter("INSERT INTO [People] (Surname, Name, Patronymic, Gender, Birthdate, Diedate, id_Country, id_City) VALUES ('"
                + _surnameTB.Text.Replace("'", "''") + "', '" + _nameTB.Text.Replace("'", "''") + "', '" + _patronymicTB.Text.Replace("'", "''")
                + "', " + (_manRB.Checked == true ? "0" : "1") + ", '" + _birthDateTP.Value.ToString("yyyy-MM-dd") + "','" + _dieDateTP.Value.ToString("yyyy-MM-dd")
                + "', " + idsOfCountries.ElementAt(_countryCB2.SelectedIndex) + "," + idsOfCities.ElementAt(_cityCB.SelectedIndex) + ")");
            }
            else
            {
                dataBase.QueryInserter("INSERT INTO [People] (Surname, Name, Patronymic, Gender, Birthdate, id_Country, id_City) VALUES ('"
                + _surnameTB.Text.Replace("'", "''") + "', '" + _nameTB.Text.Replace("'", "''") + "', '" + _patronymicTB.Text.Replace("'", "''")
                + "', " + (_manRB.Checked == true ? "0" : "1") + ", '" + _birthDateTP.Value.ToString("yyyy-MM-dd")
                + "', " + idsOfCountries.ElementAt(_countryCB2.SelectedIndex) + "," + idsOfCities.ElementAt(_cityCB.SelectedIndex) + ")");
            }
            LoadPeopleList();
        }

        private void _countryCB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCityList();
        }

        private void _addFilm_Click(object sender, EventArgs e)
        {
            if(_filmNameTB.Text == string.Empty || _subId.SelectedIndex < 0 || _filmLengthUD.Value == 0 || _genreListBox.Items.Count == 0)
            {
                MessageBox.Show("Не все заполнено");
                return;
            }
            Films filmDoc = new Films
            {
                name = _filmNameTB.Text,
                releaseDate = _filmReleaseDate.Value,
                subscription_id = idsOfSubs.ElementAt(_subId.SelectedIndex),
                rating = Convert.ToDouble(_filmRatingUD.Value),
                posterFolder = _posterFolderTB.Text,
                filmFolder = _filmFolderTB.Text,
                price = Convert.ToInt32(_filmPriceUD.Value),
                length = Convert.ToInt32(_filmLengthUD.Value)
            };
            mongodb = mongoclient.GetDatabase("cinemastore");
            var list = mongodb.GetCollection<Films>("films");
            if (list == null)
            {
                mongodb.CreateCollection("films");
                list = mongodb.GetCollection<Films>("films");
            }
            list.InsertOne(filmDoc);
            var filter = new BsonDocument();
            List<Films> mylist = list.Find(filter).Sort(Builders<Films>.Sort.Descending("_id")).Limit(1).ToList();
            string value = mylist.ElementAt(0).id.ToString();

            redis = ConnectionMultiplexer.Connect("192.168.99.100:6379");//просто подключение к редис, без входа в redis-cli
            redisdb = redis.GetDatabase(0); //в redis от 0 до 15 баз данных, по умолчанию всегда в 0
            string key = "films:" + DateTime.Now.ToString("yyyy-MM-dd") + ":" + _filmNameTB.Text;
            redisdb.StringSet(key, value);
            redisdb.KeyExpire(key, new TimeSpan(168,0,0));
            _filmNameTB.Text = string.Empty;
            Film newFilm = new Film { _id = mylist.ElementAt(0).id.ToString()};
            _client.Cypher.Merge("(film:Film { _id: {_id} })")
                .OnCreate()
                .Set("film = {newFilm}")
                .WithParams(new
                {
                    newFilm._id,
                    newFilm
                })
                .ExecuteWithoutResults();
            foreach(var item in _genreListBox.Items)
            {
                Genre newGenre = new Genre { name = item.ToString() };
                _client.Cypher
                    .Merge("(genre:Genre { name: {name} })")
                    .OnCreate()
                    .Set("genre = {newGenre}")
                    .WithParams(new
                    {
                        name = newGenre.name,
                        newGenre
                    })
                    .ExecuteWithoutResults();
                _client.Cypher
                    .Match("(genre:Genre)", "(film:Film)")
                    .Where((Genre genre) => genre.name == newGenre.name)
                    .AndWhere((Film film) => film._id == newFilm._id)
                    .CreateUnique("(film)-[:OF_GENRE]->(genre)")
                    .ExecuteWithoutResults();
            }
            LoadFilmList();
        }

        private void LoadSubscriptionList()
        {
            DataTable data = dataBase.TableQueryResponser("SELECT * FROM [Subscription]");
            if(data == null)
            {
                MessageBox.Show("Подписки не загрузились, что-то не так");
                return;
            }
            if (idsOfSubs == null)
                idsOfSubs = new List<int>();
            else
                idsOfSubs.Clear();
            idsOfSubs.Add(-1);
            _subId.Items.Clear();
            _subId.Items.Add("Не входит в подписку");
            foreach(DataRow row in data.Rows)
            {
                idsOfSubs.Add(Convert.ToInt32(row[0].ToString()));
                _subId.Items.Add(row[1].ToString() + "| " + row[2].ToString());
            }
        }

        private void _filmNameTB_TextChanged(object sender, EventArgs e)
        {
            SetFolders();
        }

        private void _filmReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            SetFolders();
        }

        private void SetFolders()
        {
            _posterFolderTB.Text = "./" + _filmReleaseDate.Value.Year + "/" + _filmReleaseDate.Value.Month + "/film/" + _filmNameTB.Text + "/poster.png";
            _filmFolderTB.Text = "./" + _filmReleaseDate.Value.Year + "/" + _filmReleaseDate.Value.Month + "/film/" + _filmNameTB.Text + "/film.avi";
        }

        private void _addGenreBTN_Click(object sender, EventArgs e)
        {
            if (_genreNameTB.Text != string.Empty || _genreListBox.Items.IndexOf(_genreNameTB.Text) < 0)
            {
                _genreListBox.Items.Add(_genreNameTB.Text);
                _genreNameTB.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Уже есть");
                return;
            }
        }

        private void _removeGenreBTN_Click(object sender, EventArgs e)
        {
            if (_genreListBox.SelectedIndex < 0)
                return;
            else
            {
                _genreListBox.Items.RemoveAt(_genreListBox.SelectedIndex);
            }
        }

        private void LoadPeopleList()
        {
            
            DataTable data = dataBase.TableQueryResponser("SELECT * FROM People");
            if (data == null)
            {
                MessageBox.Show("Нет людей");
                return;
            }
            if (idsOfPeople == null)
                idsOfPeople = new List<int>();
            else
                idsOfPeople.Clear();
            _peopleCB.Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                idsOfPeople.Add(Convert.ToInt32(row[0].ToString()));
                _peopleCB.Items.Add(row[2].ToString() + " " + row[1].ToString());
            }
        }

        private void LoadFilmList()
        {
            if (idsOfFilms == null)
                idsOfFilms = new List<string>();
            else
                idsOfFilms.Clear();
            _filmCB.Items.Clear();
            _filmCB2.Items.Clear();
            mongodb = mongoclient.GetDatabase("cinemastore");
            var list = mongodb.GetCollection<Films>("films");
            var filter = new BsonDocument();
            List<Films> mylist = list.Find(filter).ToList();
            foreach(Films film in mylist)
            {
                idsOfFilms.Add(film.id.ToString());
                _filmCB.Items.Add(film.name + " " + film.releaseDate.ToString("yyyy-MM-dd"));
                _filmCB2.Items.Add(film.name + " " + film.releaseDate.ToString("yyyy-MM-dd"));
            }
        }

        private void _connectPeopleAndFilm_Click(object sender, EventArgs e)
        {
            if (_peopleCB.SelectedIndex < 0 || _filmCB.SelectedIndex < 0 || _roleTB.Text == string.Empty)
            {
                MessageBox.Show("Не все заполнено");
                return;
            }
            else
            {
                Film newFilm = new Film { _id = idsOfFilms.ElementAt(_filmCB.SelectedIndex) };
                _client.Cypher.Merge("(film:Film { _id: {_id} })")
                    .OnCreate()
                    .Set("film = {newFilm}")
                    .WithParams(new
                    {
                        newFilm._id,
                        newFilm
                    })
                    .ExecuteWithoutResults();
                People newPeople = new People { id = idsOfPeople.ElementAt(_peopleCB.SelectedIndex) };
                _client.Cypher
                    .Merge("(people:People { id: {id} })")
                    .OnCreate()
                    .Set("people = {newPeople}")
                    .WithParams(new
                    {
                        id = newPeople.id,
                        newPeople
                    })
                    .ExecuteWithoutResults();
                _client.Cypher
                .Match("(people:People)", "(film:Film)")
                .Where((People people) => people.id == newPeople.id)
                .AndWhere((Film film) => film._id == newFilm._id)
                .CreateUnique("(people)-[:ROLE {role : {newRole}}]->(film)")
                .WithParams(new
                {
                    newRole = _roleTB.Text
                })
                .ExecuteWithoutResults();
            }
        }

        private void _addDescription_Click(object sender, EventArgs e)
        {
            if(_filmCB2.SelectedIndex < 0 || _filmDescriptionTB.Text == string.Empty)
            {
                return;
            }
            FilmDescription filmDescription = new FilmDescription { id = idsOfFilms.ElementAt(_filmCB2.SelectedIndex), Description = _filmDescriptionTB.Text };
            var responce = elasticClient.IndexDocument(filmDescription);
        }
    }
}
