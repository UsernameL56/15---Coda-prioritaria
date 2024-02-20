using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Coda_prioritaria
{
    
    internal class Program
    {
        class CodaPrioritaria
        {
            // attributi
            ArrayList arrayList;
            // costruttore
            public CodaPrioritaria()
            {
               arrayList = new ArrayList();
            }

            // metodi
            public void Aggiunta(Object obj)
            {
                arrayList.Add(obj);
            }
        }
        static void Main(string[] args)
        {
            CodaPrioritaria codaPrioritaria = new CodaPrioritaria();
            Console.WriteLine("Inserire elemento: ");
            string stringa = Console.ReadLine();
        }
    }
}
