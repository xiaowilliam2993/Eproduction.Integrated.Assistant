/*
 * <Author>FuWei</Author>
 * <CreateDate>2016/11/30</CreateDate>
 * <Description>数据查询服务</Description>
 **/
using System.Data;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Eproduction.Integrated.Assistant.Common.Core.Implement.Interface {

    [Description("数据查询服务")]
    public interface IQueryService {

        /*
         * 查询获取数据源
         **/
        DataTable Execute(string sql, params SqlParameter[] parameters);

        /*
         * 查询获取数据源(公开数据库连接)
         **/
        DataTable ExecuteWithPublicConnect(string connectionString, string sql, params SqlParameter[] parameters);

        /*
         * 查询获取数据源(多个结果集)
         **/
        DataSet ExecuteWithDataSet(string sql, params SqlParameter[] parameters);

        /*
         * 查询获取第一维度数据源
         **/
        object ExecteScalar(string sql, params SqlParameter[] parameters);

        /*
         * 查询获取第一维度数据源(公开数据库连接)
         **/
        object ExecuteScalarWithPublicConnect(string connectionString, string sql, params SqlParameter[] parameters);

        /*
         * 执行对DB有影响的SQL
         **/
        int ExecuteNonQuery(string sql, params SqlParameter[] parameters);

        /*
         * 执行对DB有影响的SQL(公开数据库连接)
         **/
        int ExecuteNonQueryWithPublicConnect(string connectionString, string sql, params SqlParameter[] parameters);

    }
}