using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Database
    {
        private List<Document> lesDocuments = new List<Document>();
        public void Add(Document unDocument)
        {
            lesDocuments.Add(unDocument);
        }
        public void Editer()
        {
            for (int i = 0; i < lesDocuments.Count; i++)
            {
                Document document = (Document)lesDocuments[i];
                Console.WriteLine(document.Afficher());
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
