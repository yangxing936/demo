using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Model
{
    public class OrderInfo
    {
        public string GetOrderInfo()
        {
            MySqlConnection connection = new MySqlConnection("data source=120.26.218.213;user id=bread;password=]o-j3j]!3@;database=bread_db;port=3306;pooling=true;max pool size=50;min pool size=5;Allow User Variables=True;");
            //var res1 = connection.Query<OrderInfos>("select * from order_info").ToList();
            //return res1.ToString();
            return "";
        }
    }
}
