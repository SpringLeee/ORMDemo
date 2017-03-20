using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Diagnostics;
using System.Threading;

namespace DapperForsql
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stopwatch w = new Stopwatch();
            w.Start();
            var str = "data source=.;initial catalog=CLN20140830;integrated security=True";
            SqlConnection Con = new SqlConnection(str);
            var list = Con.Query<NT_Photo>("select * from NT_Photo");

            foreach (var item in list)
            {
                Console.WriteLine(item.PostIP);
            }
            Console.WriteLine(w.Elapsed);
            Console.ReadKey();
        }
    }
}
