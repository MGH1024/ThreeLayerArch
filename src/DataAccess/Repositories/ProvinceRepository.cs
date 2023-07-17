using Core.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOs;

namespace Repositories
{
    public class ProvinceRepository
    {
        private string conn = ConfigurationManager.ConnectionStrings["SqlConnection"].ToString();


        public void CreateProvince(Province province)
        {

            var query = "insert into dbo.Province (Name) Values (@Name)";

            using (SqlConnection connection = new SqlConnection(conn))
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
            using (SqlConnection connection = new SqlConnection(conn))
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
    }
}
