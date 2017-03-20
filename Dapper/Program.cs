using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = ConfigurationManager.ConnectionStrings["CLNContext"];
            SqlConnection Con = new SqlConnection(str.ConnectionString);
            var list=  Con.Query<NT_User>("select * from NT_User");

            foreach (var item in list)
            {
                Console.WriteLine(item.UserName);
            }
            Console.ReadKey();
        }
    }
}
