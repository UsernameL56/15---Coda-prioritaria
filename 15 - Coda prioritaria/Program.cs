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
        class CodaPrioritaria<T>
        {
            // attributi
            ArrayList arrayList;
            // costruttore
            public CodaPrioritaria()
            {
               arrayList = new ArrayList();
            }

            // metodi
            public void Aggiunta(T obj)
            {
                if(isEmpty())
                    arrayList.Insert(0, obj);
                else
                {

                    ArrayList copia = (ArrayList)arrayList.Clone();
                    int index = 0;
                    foreach (T item in copia)
                    {
                        if (((IComparable)obj).CompareTo(item) <= 0)
                        {
                            arrayList.Insert(index, obj);
                            return;
                        }
                        else
                            index++;
                        arrayList.Insert(index, obj);
                    }
                }
            }
            public T LetturaElemento()
            {
                T primoElemento = (T)arrayList[0];
                return primoElemento;
            }
            public bool isEmpty()
            {
                if(arrayList.Count == 0)
                    return true;
                else
                    return false;
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Inserire il tipo degli elementi che si vogliono inserire: ");
            //string tipo = Console.ReadLine();
            CodaPrioritaria<int> codaPrioritaria = new CodaPrioritaria<int>();
            Console.WriteLine("Inserire il tipo degli elementi che si vogliono inserire: ");
            int elemento1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il tipo degli elementi che si vogliono inserire: ");
            int elemento2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il tipo degli elementi che si vogliono inserire: ");
            int elemento3 = int.Parse(Console.ReadLine());
            codaPrioritaria.Aggiunta(elemento1);
            codaPrioritaria.Aggiunta(elemento2);
            codaPrioritaria.Aggiunta(elemento3);
            Console.WriteLine(codaPrioritaria.LetturaElemento());
        }
        
    }
}
