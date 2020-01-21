using ElasticSearchFormats;
using FisMSSqlClient;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBFormats;
using Neo4jClient;
using Neo4jFormats;
using Nest;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyOnlineCinema
{
    public partial class FilmInfo : Form
    {
        int userId;
        string filmId;
        IGraphClient neo4j;
        MongoClient mongoclient;
        IMongoDatabase mongodb;
        DataBaseManager dataBase;
        List<int> idsOfPeople;
        Films filmInfo;
        ElasticClient elasticClient;

        public FilmInfo(string filmID, int userID)
        {
            InitializeComponent();
            userId = userID;
            filmId = filmID;
            neo4j = new GraphClient(new Uri("http://192.168.99.100.:7474/db/data"), "neo4j", "password");
            neo4j.Connect();
            string connectionString = "mongodb://192.168.99.100:27017";
            mongoclient = new MongoClient(connectionString);
            mongodb = mongoclient.GetDatabase("cinemastore");
            dataBase = new DataBaseManager();
            elasticClient = new ElasticClient(new ConnectionSettings(new Uri("http://192.168.99.100:9200")).DefaultIndex("filmdesc"));
        }

        private void FilmInfo_Load(object sender, EventArgs e)
        {
            var list = mongodb.GetCollection<Films>("films");
            var filter = new BsonDocument("_id", ObjectId.Parse(filmId));
            filmInfo = list.Find(filter).ToList().ElementAt(0);
            Film filmNeo = new Film { _id = filmInfo.id.ToString() };
            List<string> genreList = neo4j.Cypher
                .OptionalMatch("(film:Film)-[:OF_GENRE]-(genre:Genre)")
                .Where((Film film) => film._id == filmNeo._id)
                .Return(genre => genre.As<Genre>().name).Results.ToList();
            _genreLbl.Text = genreList.ElementAt(0);
            foreach (string genreName in genreList.Skip(1))
            {
                _genreLbl.Text += "/" + genreName;
            }
            idsOfPeople = neo4j.Cypher
                .OptionalMatch("(people:People)-[role:ROLE]-(film:Film)")
                .Where((Film film) => film._id == filmNeo._id)
                .Return(people => people.As<People>().id).Results.ToList();
            DataTable data = new DataTable();
            data.Columns.Add(new DataColumn("Фамилия"));
            data.Columns.Add(new DataColumn("Имя"));
            data.Columns.Add(new DataColumn("Участие в создании"));
            idsOfPeople = idsOfPeople.Distinct().ToList();
            foreach(int human in idsOfPeople)
            {
                DataTable peopleResult = dataBase.TableQueryResponser("SELECT Surname, Name FROM People WHERE id_People = " + human);
                DataRow row = data.NewRow();
                row[0] = peopleResult.Rows[0][0].ToString();
                row[1] = peopleResult.Rows[0][1].ToString();
                List<string> humanRolesList = neo4j.Cypher
                    .OptionalMatch("(people:People)-[role:ROLE]-(film:Film)")
                    .Where((Film film) => film._id == filmNeo._id)
                    .AndWhere((People people) => people.id == human)
                    .Return(role => role.As<Role>().role).Results.ToList();
                string roles = humanRolesList.ElementAt(0);
                foreach (string role in humanRolesList.Skip(1))
                {
                    roles += "/" + role;
                }
                row[2] = roles;
                data.Rows.Add(row);
            }

            _peopleGV.DataSource = data;
            _peopleGV.ForeColor = Color.Black;
            _filmNameLbl.Text = filmInfo.name;
            _filmDateLbl.Text = filmInfo.releaseDate.ToString("dd.MM.yyyy");
            _filmRatingLbl.Text = filmInfo.rating.ToString();
            _filmLengthLbl.Text = filmInfo.length.ToString() + " мин.";
            _priceLbl.Text = filmInfo.price.ToString() + " руб.";
            _posterTB.Text += "\nХранение на сервере:\n" + filmInfo.posterFolder.ToString();
            _filmSubTB.Text = "";

            DataTable result = dataBase.TableQueryResponser("SELECT Name, Price FROM Subscription WHERE id_Subscription = " + filmInfo.subscription_id);
            List<Film> filmList = neo4j.Cypher
                .OptionalMatch("(film:Film)-[:BUY]-(user:User)")
                .Where((User user) => user.id == userId)
                .AndWhere((Film film) => film._id == filmId)
                .Return(film => film.As<Film>()).Results.ToList();
            if(filmList.ElementAt(0) != null)
            {
                _filmSubLbl.Text = "Фильм уже куплен";
                _priceLbl.Hide();
                _filmSubTB.Hide();
                _buyBTN.Hide();
                return;
            }
            if (result.Rows.Count == 0)
            {
                _filmSubTB.Hide();
            }
            else
            {
                DataTable dataTable = dataBase.TableQueryResponser("SELECT * FROM UsersSubs WHERE id_User = " + userId + " AND id_Subscription = " + filmInfo.subscription_id);
                if (dataTable.Rows.Count > 0)
                {
                    if(DateTime.Compare(Convert.ToDateTime(dataTable.Rows[0][4].ToString()), DateTime.Now) > 0)
                    {
                        _filmSubTB.Text = "Доступен по вашей подписке";
                    }
                    else
                    {
                        _filmSubTB.Text = "Входит в подписки: ";
                        foreach (DataRow row in result.Rows)
                        {
                            _filmSubTB.Text += row[0].ToString() + "| " + row[1].ToString() + " руб.";
                        }
                    }
                }
                else
                {
                    _filmSubTB.Text = "Входит в подписки: ";
                    foreach (DataRow row in result.Rows)
                    {
                        _filmSubTB.Text += row[0].ToString() + "| " + row[1].ToString() + " руб.";
                    }
                }
            }
            var searchResponce = elasticClient.Search<FilmDescription>
                (desc => desc
                .From(0)
                .Size(10)
                .Query(q => q
                    .Match(match => match
                        .Field(field => field.id)
                        .Query(filmId)
                        )
                )
            );
            var descriptions = searchResponce.Documents;
            if (descriptions.Count == 0)
            {
                _descriptionTB.Text = "У данного фильма отсутствует описание";
            }
            else
            {
                _descriptionTB.Text = descriptions.ElementAt(0).Description;
            }
        }

        private void _buyBTN_Click(object sender, EventArgs e)
        {
            BuyFilm buyFilm = new BuyFilm(userId.ToString(), filmId, filmInfo.price);
            buyFilm.ShowDialog();
        }
    }
}
