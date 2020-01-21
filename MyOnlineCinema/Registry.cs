using FisMSSqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyOnlineCinema
{
    public partial class Registry : Form
    {
        DataBaseManager dataBase;
        List<int> idsOfCountries;
        List<int> idsOfCities;
        MainMenu menu;

        public Registry(MainMenu parentMenu)
        {
            InitializeComponent();
            menu = parentMenu;
        }

        private void Registry_Load(object sender, EventArgs e)
        {
            FillCountriesCB();
        }

        private void FillCountriesCB()
        {
            if (dataBase == null)
                dataBase = new DataBaseManager();
            DataTable data = dataBase.TableQueryResponser("SELECT * FROM Country");
            if (data == null)
            {
                MessageBox.Show("Похоже администратор не добавил страны, напишите в поддержку");
                return;
            }
            if (idsOfCountries == null)
                idsOfCountries = new List<int>();
            else
                idsOfCountries.Clear();
            _countryCB.Items.Clear();
            foreach(DataRow row in data.Rows)
            {
                idsOfCountries.Add(Convert.ToInt32(row[0].ToString()));
                _countryCB.Items.Add(row[1].ToString());
            }
        }

        private void FillCityCB()
        {
            if(dataBase == null)
                dataBase = new DataBaseManager();
            if (_countryCB.SelectedIndex < 0)
                return;
            DataTable data = dataBase.TableQueryResponser("SELECT * FROM City WHERE id_Country =" + idsOfCountries.ElementAt(_countryCB.SelectedIndex).ToString());
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
            foreach(DataRow row in data.Rows)
            {
                idsOfCities.Add(Convert.ToInt32(row[0].ToString()));
                _cityCB.Items.Add(row[2].ToString());
            }
        }

        private void _countryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCityCB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = dataBase.TableQueryResponser("SELECT * FROM [User] WHERE Login = '" + _login.Text + "'");
            if (data == null)
                MessageBox.Show("При проверке что-то пошло не так, пожалуйста, попробуйте снова");
            if(_surnameTB.Text == string.Empty || _nameTB.Text == string.Empty)
            {
                MessageBox.Show("Кажется, вы не ввели Фамилию и/или имя");
                return;
            }
            else if(DateTime.Now.Year - _dateTimePicker.Value.Date.Year < 13)
            {
                MessageBox.Show("Кажется, вы не достигли 13 лет, нужен аккаунт родителей");
                return;
            }
            else if(_countryCB.SelectedIndex < 0 || _cityCB.SelectedIndex < 0)
            {
                MessageBox.Show("Нам нужно знать откуда вы. Это нужно только, чтобы предоставлять вам скидки", "Упс, что-то не ввели",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(data.Rows.Count > 0)
            {
                MessageBox.Show("Простите, данный логин занят");
            }
            else if(_passwordTB.Text != _password2TB.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            dataBase.QueryInserter("INSERT INTO [User] (Login, Surname, Name, Patronymic, Gender, Birthdate, PassHash, id_Country, id_City) VALUES ('" 
                + _login.Text.Replace("'","''") +"', '" + _surnameTB.Text.Replace("'", "''") + "', '" + _nameTB.Text.Replace("'", "''") + "', '" 
                + _patronymicTB.Text.Replace("'", "''") + "', " + (_manRB.Checked == true ? "0" : "1") + ", '" + _dateTimePicker.Value.ToString("yyyy-MM-dd")
                + "', '" + _passwordTB.Text.GetHashCode() + "', " + idsOfCountries.ElementAt(_countryCB.SelectedIndex) + "," + idsOfCities.ElementAt(_cityCB.SelectedIndex) + ")");
            MessageBox.Show("Добро пожаловать в MyOnlineCinema!");
            data = dataBase.TableQueryResponser("SELECT * FROM [User] WHERE Login = '" + _login.Text + "' AND PassHash = '" + _passwordTB.Text.GetHashCode() + "'");
            menu.Authorization(Convert.ToInt32(data.Rows[0][0].ToString()));
            Close();
        }

        private void Registry_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataBase.Dispose();
        }
    }
}
