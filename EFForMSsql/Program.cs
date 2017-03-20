using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFForMSsql
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch t = new Stopwatch();

            using (var db = new CLNContext())  //EF暖机
            {
                var objectContext = ((IObjectContextAdapter)db).ObjectContext;
                var mappingCollection = (System.Data.Entity.Core.Mapping.StorageMappingItemCollection)objectContext.MetadataWorkspace.GetItemCollection(System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace);
                mappingCollection.GenerateViews(new System.Collections.Generic.List<System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>());
            }

            t.Start();
            var DBContext = new CLNContext();
            foreach (var item in DBContext.NT_Photo)
            {
                Console.WriteLine(item.PostIP);
            }
            Console.WriteLine(t.Elapsed);
            Console.ReadKey();

         



        }
    }
}
