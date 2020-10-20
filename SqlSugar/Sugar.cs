using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public class Sugar: Interface1
    {
        private readonly Iorderinfo _iorderinfo;

        public Sugar(Iorderinfo iorderinfo)
        {
            _iorderinfo = iorderinfo;
        }

        public object Get()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "data source=120.26.218.213;user id=bread;password=]o-j3j]!3@;database=bread_db;port=3306;pooling=true;max pool size=50;min pool size=5;Allow User Variables=True;",
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
            var ress = _iorderinfo.QueryByExpression(s => s.OrderId == "");


            var res = db.Queryable<OrderInfos>();
            return null;
        }
    }
}
