using CLNContext;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaPoco
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var Context = new CLNContext.CLNContextDB();
            Stopwatch s = new Stopwatch();
            s.Start();
            var list = Context.Query<NT_Photo>("select * from NT_Photo");
            foreach (var item in list)
            {
                Console.WriteLine(item.PostIP);
            }
            Console.WriteLine(s.Elapsed);
            Console.ReadKey();


        }
    }
}
