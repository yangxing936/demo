using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class DosSelect
    {
        public static readonly DbSession Context = new DbSession(DatabaseType.MySql, "");//连接字符串
    }
}
