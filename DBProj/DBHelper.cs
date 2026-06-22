using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DBProj
{
    internal static class DBHelper
    {
        public static DataTable ExecuteDataTable(string connString, string commandText, CommandType commandType, IDictionary<string, object> parameters, out string error)
        {
            error = null;
            var dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(commandText, conn) { CommandType = commandType })
                using (var da = new SqlDataAdapter(cmd))
                {
                    if (parameters != null)
                    {
                        foreach (var kv in parameters)
                        {
                            cmd.Parameters.AddWithValue(kv.Key, kv.Value ?? DBNull.Value);
                        }
                    }
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                error = $"SQL error ({ex.Number}): {ex.Message}";
            }
            catch (InvalidOperationException ex)
            {
                error = $"Invalid operation: {ex.Message}";
            }
            catch (Exception ex)
            {
                error = $"Unexpected error: {ex.Message}";
            }
            return dt;
        }

        public static int ExecuteNonQuery(string connString, string commandText, CommandType commandType, IDictionary<string, object> parameters, out string error)
        {
            error = null;
            try
            {
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(commandText, conn) { CommandType = commandType })
                {
                    if (parameters != null)
                    {
                        foreach (var kv in parameters)
                        {
                            cmd.Parameters.AddWithValue(kv.Key, kv.Value ?? DBNull.Value);
                        }
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                error = $"SQL error ({ex.Number}): {ex.Message}";
            }
            catch (InvalidOperationException ex)
            {
                error = $"Invalid operation: {ex.Message}";
            }
            catch (Exception ex)
            {
                error = $"Unexpected error: {ex.Message}";
            }
            return -1;
        }

        public static object ExecuteScalar(string connString, string commandText, CommandType commandType, IDictionary<string, object> parameters, out string error)
        {
            error = null;
            try
            {
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(commandText, conn) { CommandType = commandType })
                {
                    if (parameters != null)
                    {
                        foreach (var kv in parameters)
                        {
                            cmd.Parameters.AddWithValue(kv.Key, kv.Value ?? DBNull.Value);
                        }
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                error = $"SQL error ({ex.Number}): {ex.Message}";
            }
            catch (InvalidOperationException ex)
            {
                error = $"Invalid operation: {ex.Message}";
            }
            catch (Exception ex)
            {
                error = $"Unexpected error: {ex.Message}";
            }
            return null;
        }

        public static bool RecordExists(string connString, string commandText, IDictionary<string, object> parameters, out string error)
        {
            error = null;
            var obj = ExecuteScalar(connString, commandText, CommandType.Text, parameters, out error);
            if (!string.IsNullOrEmpty(error)) return false;
            if (obj == null || obj == DBNull.Value) return false;
            if (int.TryParse(obj.ToString(), out int n)) return n > 0;
            if (long.TryParse(obj.ToString(), out long l)) return l > 0;
            return true;
        }
    }
}
