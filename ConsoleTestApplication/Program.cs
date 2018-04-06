using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client;
using Raven.Client.Documents;

namespace JustTimber
{
    class Program
    {
        static void Main()
        {
            var documentStore = new DocumentStore
            {
                Urls = new[] {"http://localhost:8080" },
                Database = "JustTimber"
            };

            documentStore.Initialize();

            //JobCard jc = new JobCard();


            using (var session = documentStore.OpenSession())
            {
                var p = session.Load<Work>("JustTimber");
                System.Console.WriteLine(p.WorkStatus);
                Console.ReadLine();
            }
            //DocumentStore.OpenSession();
            //using (var session = DocumentStoreHolder.Store.OpenSession())
        }
    }
}