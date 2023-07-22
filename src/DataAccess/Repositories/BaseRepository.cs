using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BaseRepository
    {
        public string sqlConnection = 
            ConfigurationManager.ConnectionStrings["SqlConnection"].ToString();

        public string accessConnection = 
            ConfigurationManager.ConnectionStrings["AccessConnection"].ToString();
    }
}
