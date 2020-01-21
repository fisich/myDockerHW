using Neo4jClient;
using Neo4jClient.Transactions;
using Neo4jFormats;
using System;
using System.Windows.Forms;

namespace MyOnlineCinema
{
    public partial class BuyFilm : Form
    {
        ITransactionalGraphClient _client;
        string userId, filmId;

        public BuyFilm(string userID, string filmID, int Price)
        {
            InitializeComponent();
            _price.Text = Price.ToString() + " руб.";
            userId = userID;
            filmId = filmID;
        }

        private void _confirmPayment_Click(object sender, EventArgs e)
        {
            _client = new GraphClient(new Uri("http://192.168.99.100.:7474/db/data"), "neo4j", "password");
            _client.Connect();
            User newUser = new User { id = Convert.ToInt32(userId) };
            _client.Cypher
                .Merge("(user:User { id: {id} })")
                .OnCreate() 
                .Set("user = {newUser}")
                .WithParams(new {
                    id = newUser.id,
                    newUser
                })
                .ExecuteWithoutResults();
            Film newFilm = new Film { _id = filmId };
            _client.Cypher.Merge("(film:Film { _id: {_id} })")
                .OnCreate()
                .Set("film = {newFilm}")
                .WithParams(new
                {
                    newFilm._id,
                    newFilm
                })
                .ExecuteWithoutResults();
            var newDate = DateTime.Now.ToString("yyyy-MM-dd");
            _client.Cypher
                .Match("(user:User)", "(film:Film)")
                .Where((User user) => user.id == newUser.id)
                .AndWhere((Film film) => film._id == filmId)
                .CreateUnique("(user)-[:BUY {date : {newDate}}]->(film)")
                .WithParams(new
                {
                    newDate
                })
                .ExecuteWithoutResults();
            MessageBox.Show("Поздравляем с покупкой");
            _client.Dispose();
            Close();
        }
    }
}
