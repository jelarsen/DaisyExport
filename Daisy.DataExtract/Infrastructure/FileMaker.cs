using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FastMember;
using System.IO;
using CsvHelper;

namespace Daisy.DataExtract.Infrastructure
{
    public class FileMaker<T> where T : class, new()
    {
        public void Write(string file, Boolean append, string sql, SqlConnection conn, object param = null)
        {
            try
            {
                // todo: move connection outside of here
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                // add parameters
                if (param != null)
                {
                    Type type = param.GetType();
                    var accessor = TypeAccessor.Create(type);
                    var members = accessor.GetMembers();

                    foreach (var member in members)
                    {
                        cmd.Parameters.AddWithValue($@"@{member.Name}", accessor[param, member.Name]);
                    }
                }
                cmd.CommandTimeout = 1800;
                using (var writer = new StreamWriter(file, append, Encoding.ASCII))
                using (var csv = new CsvWriter(writer))
                using (var reader = cmd.ExecuteReader())
                {
                    int i = 0;
                    csv.Configuration.Delimiter = "|";
                    csv.WriteHeader(typeof(T));
                    csv.NextRecord();
                    while (reader.Read())
                    {
                        T t = reader.ConvertToObject<T>();
                        csv.WriteRecord<T>(t);
                        csv.NextRecord();

                        // flush  buffer every 50 records to prevent out of memory
                        i++;
                        if (i == 50)
                        {
                            csv.Flush();
                            i = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // remove file
                try { if (System.IO.File.Exists(file)) { System.IO.File.Delete(file); } } catch { }
                throw ex;
            }
            finally
            {
                try { conn.Close(); } catch { }
            }

            
        }
    }
}
