using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FisMSSqlClient
{
    public class DataBaseManager
    {
        private const string basic_connection_parametres = "Data Source=192.168.99.100,1433;Initial Catalog=CinemaSQL;";
        private string m_connectionParametres;
        private SqlConnection m_connection;

        /// <summary>
        /// Создание подключения в соответствии с логином и паролем
        /// </summary>
        public DataBaseManager(string login, string password)
        {
            SetConnection(basic_connection_parametres + "User ID = " + login + "; Password = " + password + ";");
        }
        
        public DataBaseManager()
        {
            SetConnection(basic_connection_parametres + "User ID = sa; Password = YourStrong!Passw0rd;");
        }

        /// <summary>
        /// Передает ссылку на этот объект
        /// </summary>
        public DataBaseManager GetDataBaseManager()
        {
            return this;
        }

        /// <summary>
        /// Изменение данных авторизации
        /// </summary>
        public void ChangeAuthorisationData(string login, string password)
        {
            SetConnection(basic_connection_parametres + "User ID = " + login + "; Password = " + password + ";");
        }

        /// <summary>
        /// Устанавливает новые параметры подключения, но без инициализации самого подключения к базе данных.
        /// </summary>
        public void SetConnection(string newConnection)
        {
            m_connectionParametres = newConnection;
            if (m_connection == null)
            {
                m_connection = new SqlConnection(m_connectionParametres);
            }
            else
            {
                m_connection.Dispose();
                m_connection = new SqlConnection(m_connectionParametres);
            }
        }

        /// <summary>
        /// Устанавливает подключение к базе данных, в случае ошибки возвращает false.
        /// </summary>
        public bool ConnectToDataBase()
        {
            if (m_connection == null)
            {
                m_connection = new SqlConnection(m_connectionParametres);
            }
            if (m_connection.State != ConnectionState.Closed)
            {
                m_connection.Close();
            }
            try
            {
                m_connection.Open();
            }
            catch (SqlException ex)
            {
                if(ex.Number == 18456)
                {
                    MessageBox.Show(ex.Message + "\nПроверьте логин и пароль.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
            return true;
        }

        /// <summary>
        /// Принимает sql-запрос, связанный с изменением данных, без возвращения.
        /// </summary>
        public void QueryInserter(string query)
        {
            ConnectToDataBase();
            SqlCommand m_command = new SqlCommand(query, m_connection);
            try
            {
                m_command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Извините, у вас недостаточно прав для продолжения");
                }
                else if (ex.Number == 547)
                {
                    MessageBox.Show("Прежде чем удалить эту запись, проверьте, что на нее ничто не ссылается");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Возникла ошибка!" + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CloseConnection();
        }

        /// <summary>
        /// Принимает sql-запрос, связанный с изменением данных через процедуры с возвращением информации об успехе, в массив данные идут в паре [название поля],[значения] друг за другом
        /// </summary>
        public int QueryExecutor(string procedureName, object[] parametres)
        {
            int result = -1;
            ConnectToDataBase();
            SqlCommand m_command = new SqlCommand(procedureName, m_connection);
            m_command.CommandType = CommandType.StoredProcedure;
            for(int i = 0; i < parametres.Length - 1; i+=2)
            {
                m_command.Parameters.AddWithValue(parametres[i].ToString(), parametres[i + 1]);
            }
            SqlParameter returnParametr = new SqlParameter();
            returnParametr.SqlDbType = SqlDbType.Int;
            returnParametr.ParameterName = "@retValue";
            returnParametr.Direction = ParameterDirection.ReturnValue;
            m_command.Parameters.Add(returnParametr);
            try
            {
                m_command.ExecuteNonQuery();
                result = (int)m_command.Parameters["@retValue"].Value;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Извините, у вас недостаточно прав для продолжения");
                }
                else if(ex.Number == 547)
                {
                    MessageBox.Show("Прежде чем удалить эту запись, проверьте, что на нее ничто не ссылается");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Возникла ошибка!" + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CloseConnection();
            return result;
        }

        /// <summary>
        /// Принимает sql-запрос в виде string и возвращает результат в формате DataTable.
        /// </summary>
        public DataTable TableQueryResponser(string query)
        {
            DataTable responce = new DataTable();
            ConnectToDataBase();
            SqlCommand m_command = new SqlCommand(query, m_connection);
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter { SelectCommand = m_command })
                {
                    adapter.Fill(responce);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229) //Код ошибки, связанной с доступом
                {
                    MessageBox.Show("Извините, у вас недостаточно прав для продолжения");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Возникла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                m_command.Dispose();
                CloseConnection();
                return null;
            }
            m_command.Dispose();
            CloseConnection();
            return responce;
        }

        /// <summary>
        /// Закрытие подключения
        /// </summary>
        public void CloseConnection()
        {
            if (m_connection != null)
            {
                if (m_connection.State != ConnectionState.Closed)
                    m_connection.Close();
            }
        }

        /// <summary>
        /// Освобождает ресурсы, но не то, чтобы в C# это прям так работало
        /// </summary>
        public void Dispose()
        {
            CloseConnection();
            m_connection.Dispose();
            GC.Collect();
        }
    }
}
