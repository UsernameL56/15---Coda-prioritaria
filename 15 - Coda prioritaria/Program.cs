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
            public T LetturaPrimoElemento()
            {
                T primoElemento = (T)arrayList[0];
                return primoElemento;
            }
            public void EstrazionePrimoElemento()
            {
                if (arrayList.Count == 0)
                    return;
                else
                    arrayList.RemoveAt(0);
                return;
            }
            public void EstrazioneUltimoElemento()
            {
                int index = 0;
                if (arrayList.Count == 0)
                    return;
                else
                {
                    foreach (T item in arrayList)
                    {
                        index++;
                    }
                    arrayList.RemoveAt(index);
                    return;
                }
                
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
            
           
            int scelta;
            CodaPrioritaria<int> codaPrioritaria = new CodaPrioritaria<int>();
            do
            {
                Console.WriteLine();
                Console.WriteLine("Menù");
                Console.WriteLine("1) Inserimento di un elemento");
                Console.WriteLine("2) Ricerca di un elemento");
                Console.WriteLine("3) Lettura del primo elemento");
                Console.WriteLine("4) Estrazione del primo elemento");
                Console.WriteLine("5) Estrazione dell'ultimo elemento");
                Console.WriteLine("\n0) Fine\n");
                Console.Write("Scelta: ");

                if (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.Write("scelta non valida");
                    continue;
                }
                
                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Programma terminato.");
                        break;
                    case 1:
                        Console.WriteLine("Inserire l'elemento che si vuole aggiungere alla coda: ");
                        int elemento = int.Parse(Console.ReadLine());

                        codaPrioritaria.Aggiunta(elemento);

                        break;
                    case 2:
                       
                        break;
                    case 3:
                        Console.WriteLine(codaPrioritaria.LetturaPrimoElemento());
                        break;
                    case 4:
                        if (!codaPrioritaria.isEmpty())
                        {
                            codaPrioritaria.EstrazionePrimoElemento();
                            Console.WriteLine("Primo elemento estratto correttamente");
                        }
                        else
                            Console.WriteLine("La coda è vuota");
                        
                        break;
                    case 5:
                        if (!codaPrioritaria.isEmpty())
                        {
                            codaPrioritaria.EstrazioneUltimoElemento();
                            Console.WriteLine("Ultimo elemento estratto correttamente");
                        }
                        else
                            Console.WriteLine("La coda è vuota");
                        break;
                }
            } while (scelta != 0);
        }
    }
}

