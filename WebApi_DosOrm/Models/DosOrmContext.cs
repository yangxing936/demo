using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApi_DosOrm.Models
{
    public class DosOrmContext
    {

        public DbSession db = new DbSession(DatabaseType.MySql, ConfigurationManager.AppSettings["Dos"]);
    }
}