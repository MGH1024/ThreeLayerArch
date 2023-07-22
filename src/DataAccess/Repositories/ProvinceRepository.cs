using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Repositories
{
    public class ProvinceRepository : BaseRepository
    {

        public void CreateProvince(Province province)
        {

            var query = "insert into dbo.Province (Name) Values (@Name)";

            using (var connection = new SqlConnection(sqlConnection))
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", province.Name);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public IEnumerable<Province> GetAll()
        {
            var query = "SELECT  Id,Name FROM dbo.Province";
            var provinces = new List<Province>();
            using (var connection = new SqlConnection(sqlConnection))
            {

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var province = new Province();
                            province.Id = (int)reader["Id"];
                            province.Name = (string)reader["Name"];
                            provinces.Add(province);
                        }
                        reader.NextResult();
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return provinces;
        }


        public List<Province> GetAllProvince()
        {
            var states = new List<Province>();
            var querystr = "select Id,Name from province";

            using (var connection = new OleDbConnection(accessConnection))
            {
                OleDbCommand command = new OleDbCommand(querystr, connection);
                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var province = new Province();
                            province.Id = (int)reader["Id"];
                            province.Name = (string)reader["Name"];
                            states.Add(province);
                        }

                        reader.NextResult();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return states;
        }
    }
}
