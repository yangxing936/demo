using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public class Base<T, TKey> : Ibase<T, TKey> where T : class, new()
    {
        public SqlSugarClient client() 
        {
            return new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "data source=120.26.218.213;user id=bread;password=]o-j3j]!3@;database=bread_db;port=3306;pooling=true;max pool size=50;min pool size=5;Allow User Variables=True;",
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
        }

        private object SqlSugarExe(Func<SqlSugarClient, object> func)
        {
            using (var db = client())
            {
                return func.Invoke(db);
            }
        }

        private async Task<object> SqlSugarExeAsync(Func<SqlSugarClient, Task<object>> func)
        {
            using (var db = client())
            {
                return await func.Invoke(db);
            }
        }

        public bool Delete(TKey key)
        {
            return (bool)SqlSugarExe((db) => db.Deleteable<T>(key).ExecuteCommand() > 0);
        }

        public bool Delete(T t)
        {
            return (bool)SqlSugarExe(db => db.Deleteable(t).ExecuteCommand() > 0);
        }

        public bool Delete(Expression<Func<T, bool>> expression)
        {
            return (bool)SqlSugarExe(db => db.Deleteable(expression).ExecuteCommand() > 0);
        }

        public async Task<bool> DeleteAsync(TKey key)
        {
            return (bool)await SqlSugarExeAsync(async db => await db.Deleteable<T>(key).ExecuteCommandAsync() > 0);
        }

        public async Task<bool> DeleteAsync(T t)
        {
            return (bool)await SqlSugarExeAsync(async db => await db.Deleteable(t).ExecuteCommandAsync() > 0);
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            return (bool)await SqlSugarExeAsync(async db => await db.Deleteable(expression).ExecuteCommandAsync() > 0);
        }

        public bool Insert(T t)
        {
            return (bool)SqlSugarExe(db => db.Insertable(t).ExecuteCommand() > 0);
        }

        public bool Insert(List<T> t)
        {
            return (bool)SqlSugarExe(db => db.Insertable(t).ExecuteCommand() > 0);
        }

        public async Task<bool> InsertAsync(T t)
        {
            return (bool)await SqlSugarExeAsync(async db => await db.Insertable(t).ExecuteCommandAsync() > 0);
        }

        public async Task<bool> InsertAsync(List<T> t)
        {
            return (bool)await SqlSugarExeAsync(async db => await db.Insertable(t).ExecuteCommandAsync() > 0);
        }

        public bool Save(T t)
        {
            return (bool)SqlSugarExe(db => db.Saveable(t).ExecuteCommand() > 0);
        }

        public async Task<bool> SaveAsync(List<T> t)
        {
            return (bool)await SqlSugarExeAsync(async db => await db.Saveable(t).ExecuteCommandAsync() > 0);
        }

        public IEnumerable<T> QueryAll()
        {
            return (IEnumerable<T>)SqlSugarExe(db => db.Queryable<T>().ToList());
        }

        public async Task<IEnumerable<T>> QueryAllAsync()
        {
            return (IEnumerable<T>)await SqlSugarExeAsync(async db => await db.Queryable<T>().ToListAsync());
        }

        public IEnumerable<T> QueryByExpression(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderby)
        {
            if (orderby == null)
            {
                return (IEnumerable<T>)SqlSugarExe(db => db.Queryable<T>().Where(expression).ToList());
            }
            return (IEnumerable<T>)SqlSugarExe(db => db.Queryable<T>().Where(expression).OrderBy(orderby).ToList());
        }

        public async Task<IEnumerable<T>> QueryByExpressionAsync(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderby)
        {
            if (orderby != null)
            {
                return (IEnumerable<T>)await SqlSugarExeAsync(async db => await db.Queryable<T>().Where(expression).OrderBy(orderby).ToListAsync());
            }
            return (IEnumerable<T>)await SqlSugarExeAsync(async db => await db.Queryable<T>().Where(expression).ToListAsync());
        }

        public T QueryById(TKey key)
        {
            return (T)SqlSugarExe(db => db.Queryable<T>().InSingle(key));
        }

        public async Task<T> QueryByIdAsync(TKey key)
        {
            return (T)await SqlSugarExeAsync(async db => await db.Queryable<T>().InSingleAsync(key));
        }

        public IEnumerable<T> QueryPage(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderby = null, int skip = 1, int pageSize = 15)
        {
            return (IEnumerable<T>)SqlSugarExe(db => db.Queryable<T>().Where(expression).OrderBy(orderby).ToPageList(skip, pageSize));
        }

        public async Task<IEnumerable<T>> QueryPageAsync(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderby = null, int skip = 1, int pageSize = 15)
        {
            return (IEnumerable<T>)await SqlSugarExeAsync(async db => await db.Queryable<T>().Where(expression).OrderBy(orderby).ToPageListAsync(skip, pageSize));
        }

        public dynamic QuerySqlDynamic(string sql, List<SugarParameter> parameters)
        {
            if (parameters == null)
            {
                return SqlSugarExe(db => db.SqlQueryable<dynamic>(sql).ToList());
            }
            return SqlSugarExe(db => db.SqlQueryable<dynamic>(sql).AddParameters(parameters).ToList());
        }

        public dynamic QuerySqlDynamic(string sql, List<SugarParameter> parameters, int skip = 1, int pageSize = 15)
        {
            return SqlSugarExe(db => db.SqlQueryable<dynamic>(sql).AddParameters(parameters).ToPageList(skip, pageSize));
        }

        public async Task<dynamic> QuerySqlDynamicAsync(string sql, List<SugarParameter> parameters)
        {
            return await SqlSugarExeAsync(async db => await db.SqlQueryable<dynamic>(sql).AddParameters(parameters).ToListAsync());
        }

        public async Task<dynamic> QuerySqlDynamicAsync(string sql, List<SugarParameter> parameters, int skip = 1, int pageSize = 15)
        {
            return await SqlSugarExeAsync(async db => await db.SqlQueryable<dynamic>(sql).AddParameters(parameters).ToPageListAsync(skip, pageSize));
        }

        public bool Update(T t)
        {
            return (bool)SqlSugarExe(db => db.Updateable(t).ExecuteCommand() > 0);
        }

        public async Task<bool> UpdateAsync(T t)
        {
            return (bool)await SqlSugarExeAsync(async db => await db.Updateable(t).ExecuteCommandAsync() > 0);
        }

        public async Task<bool> UpdateAsync(List<T> t)
        {
            return (bool)await SqlSugarExeAsync(async db => await db.Updateable(t).ExecuteCommandAsync() > 0);
        }


        public bool ExecuteCommand(string sql, List<SugarParameter> parameters)
        {
            if (parameters == null)
            {
                return (bool)SqlSugarExe(db => db.Ado.ExecuteCommand(sql) > 0);
            }
            return (bool)SqlSugarExe(db => db.Ado.ExecuteCommand(sql, parameters) > 0);
        }

        public async Task<bool> ExecuteCommandAsync(string sql, List<SugarParameter> parameters)
        {
            if (parameters == null)
            {
                return (bool)await SqlSugarExeAsync(async db => await db.Ado.ExecuteCommandAsync(sql) > 0);
            }
            return (bool)await SqlSugarExeAsync(async db => await db.Ado.ExecuteCommandAsync(sql, parameters) > 0);
        }
    }
}
