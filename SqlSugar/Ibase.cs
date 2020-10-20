using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public interface Ibase<T, TKey> where T : class, new()
    {
        #region 查询
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="pk">主键</param>
        /// <returns></returns>
        T QueryById(TKey key);

        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="key">主键</param>
        /// <returns></returns>
        Task<T> QueryByIdAsync(TKey key);

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> QueryAll();

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> QueryAllAsync();

        /// <summary>
        /// 根据表达式查询实体
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="expression">排序</param>
        /// <returns></returns>
        IEnumerable<T> QueryByExpression(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderby = null);

        /// <summary>
        /// 根据表达式查询实体
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="expression">排序</param>
        /// <returns></returns>
        Task<IEnumerable<T>> QueryByExpressionAsync(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderby = null);

        /// <summary>
        /// 根据表达式分页查询
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="expression">排序</param>
        /// <returns></returns>
        IEnumerable<T> QueryPage(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderby = null, int skip = 1, int pageSize = 15);

        /// <summary>
        /// 根据表达式分页查询
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="expression">排序</param>
        /// <returns></returns>
        Task<IEnumerable<T>> QueryPageAsync(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderby = null, int skip = 1, int pageSize = 15);

        /// <summary>
        /// 根据Sql查询动态数据(适用于多表,不分页)
        /// </summary>
        /// <param name="sql">Sql</param>
        /// <param name="parameters">参数集</param>
        /// <returns></returns>
        dynamic QuerySqlDynamic(string sql, List<SugarParameter> parameters);

        /// <summary>
        /// 根据Sql查询动态数据(适用于多表,分页)
        /// </summary>
        /// <param name="sql">Sql</param>
        /// <param name="parameters">参数集</param>
        /// <param name="skip">当前页</param>
        /// <param name="pageSize">页显示总数</param>
        /// <returns></returns>
        dynamic QuerySqlDynamic(string sql, List<SugarParameter> parameters, int skip = 1, int pageSize = 15);

        /// <summary>
        /// 根据Sql查询动态数据(适用于多表,不分页)
        /// </summary>
        /// <param name="sql">Sql</param>
        /// <param name="parameters">参数集</param>
        /// <returns></returns>
        Task<dynamic> QuerySqlDynamicAsync(string sql, List<SugarParameter> parameters);

        /// <summary>
        /// 根据Sql查询动态数据(适用于多表,分页)
        /// </summary>
        /// <param name="sql">Sql</param>
        /// <param name="parameters">参数集</param>
        /// <param name="skip">当前页</param>
        /// <param name="pageSize">页显示总数</param>
        /// <returns></returns>
        Task<dynamic> QuerySqlDynamicAsync(string sql, List<SugarParameter> parameters, int skip = 1, int pageSize = 15);
        #endregion

        #region 修改
        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns></returns>
        bool Update(T t);
        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns></returns>
        Task<bool> UpdateAsync(T t);
        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns></returns>
        Task<bool> UpdateAsync(List<T> t);
        #endregion

        #region 更新
        /// <summary>
        /// 根据sql执行返回受影响行数
        /// </summary>
        /// <param name="sql">Sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        bool ExecuteCommand(string sql, List<SugarParameter> parameters);

        /// <summary>
        /// 根据sql执行返回受影响行数
        /// </summary>
        /// <param name="sql">Sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        Task<bool> ExecuteCommandAsync(string sql, List<SugarParameter> parameters);
        #endregion

        #region 删除
        /// <summary>
        /// 根据主键删除数据
        /// </summary>
        /// <param name="key">主键</param>
        /// <returns></returns>
        bool Delete(TKey key);
        /// <summary>
        /// 根据主键删除数据
        /// </summary>
        /// <param name="key">主键</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(TKey key);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns></returns>
        bool Delete(T t);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(T t);
        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="expression">条件</param>
        /// <returns></returns>
        bool Delete(Expression<Func<T, bool>> expression);
        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(Expression<Func<T, bool>> expression);
        #endregion

        #region 新增
        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns></returns>
        bool Insert(T t);
        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns></returns>
        Task<bool> InsertAsync(T t);
        /// <summary>
        /// 批量新增数据
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        bool Insert(List<T> t);
        /// <summary>
        /// 批量新增数据
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        Task<bool> InsertAsync(List<T> t);

        /// <summary>
        /// 批量新增数据
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        bool Save(T t);
        /// <summary>
        /// 批量新增数据
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        Task<bool> SaveAsync(List<T> t);
        #endregion
    }
}
