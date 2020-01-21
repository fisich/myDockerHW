using FisMSSqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MyOnlineCinema
{
    public partial class BuySub : Form
    {
        int pricePerMonth, userId, subId;
        DataBaseManager dataBase;

        public BuySub(int uId, int sId, int perMonth)
        {
            InitializeComponent();
            pricePerMonth = perMonth;
            userId = uId;
            subId = sId;
            dataBase = new DataBaseManager();
        }

        private void _monthCountUD_ValueChanged(object sender, EventArgs e)
        {
            _price.Text = (_monthCountUD.Value * pricePerMonth).ToString();
        }

        private void _confirmPayment_Click(object sender, EventArgs e)
        {
            DataTable data = dataBase.TableQueryResponser("SELECT u.Enddate FROM UsersSubs as u INNER JOIN [Subscription] as s ON u.id_Subscription = s.id_Subscription " +
                "WHERE u.id_User = " + userId + " AND u.id_Subscription = " + subId);
            if (data.Rows.Count > 0)
            {
                DateTime dateTime = Convert.ToDateTime(data.Rows[0][0].ToString());
                if(dateTime < DateTime.Now)
                {
                    dataBase.QueryInserter("UPDATE UsersSubs SET Buydate = '" + DateTime.Now.ToString("yyyy-MM-dd") 
                        + "', Enddate = '" + DateTime.Now.AddMonths(Convert.ToInt32(_monthCountUD.Value)).ToString("yyyy-MM-dd")
                        + "' WHERE id_User = " + userId + " AND id_Subscription = " + subId);
                }
                else
                {
                    dataBase.QueryInserter("UPDATE UsersSubs SET Enddate = '" + dateTime.AddMonths(Convert.ToInt32(_monthCountUD.Value)).ToString("yyyy-MM-dd")
                        + "' WHERE id_User = " + userId + " AND id_Subscription = " + subId);
                }
            }
            else
            {
                dataBase.QueryInserter("INSERT INTO UsersSubs (id_User, id_Subscription, Buydate, Enddate) VALUES (" +
                    userId + "," + subId + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.AddMonths(Convert.ToInt32(_monthCountUD.Value)).ToString("yyyy-MM-dd") + "')");
            }
            MessageBox.Show("Поздравляем с покупкой");
            dataBase.Dispose();
            Close();
        }
    }
}
