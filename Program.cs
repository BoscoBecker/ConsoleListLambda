using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Joao bosco");
            list.Add("Cassiana");
            list.Add("Sofia");
            list.Insert(0, "JB");

            string s1 = list.Find(x => x[0] == 'J');        /// Lambda expression
            string s2 = list.FindLast(x => x[0] == 'J');    /// Lambda expression
           
            int pos1 = list.FindIndex(x => x[0] == 'J');     /// Lambda expression
            int pos2 = list.FindLastIndex(x => x[0] == 'J');

            List<string> list2 = list.FindAll(x => x.Length == 5);
            List<string> list3 = list.FindAll(x => x.Equals("JB"));

            Console.WriteLine("First J:" + s1);
            Console.WriteLine("Last J:" + s2);
            Console.WriteLine("First Position J:" + pos1);
            Console.WriteLine("Last Position J:" + pos2);
            foreach (string result in list2)
            {
                Console.WriteLine("Item com 5 caracteres é: " + result);
            }
            foreach (string igual in list3)
            {
                Console.WriteLine("O Nome encontrado é: " + igual);
            }

            Console.WriteLine("-------------Todos os Itens-------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List count:" + list.Count());

            list.Remove("JB");
            Console.WriteLine("Item removido [JB]");

            Console.WriteLine("-------------Todos os Itens Atualizados-------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List count:" + list.Count());



        }

        //static bool BoolMatch(string s)
        //{
        //    return s[0] == 'J';

        //}
    }
}