using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            List<MenuItem> menu = new List<MenuItem>();
            menu.Add(new MenuItem("choix 2", 2));
            menu.Add(new MenuItem("choix 4", 4));
            menu.Add(new MenuItem("choix 6", 6));
            menu.Add(new MenuItem("choix 8", 8));
            menu.Add(new MenuItem("choix 10", 10));


            int menuChoisi = GererMenu(menu);

            Console.WriteLine("Vous avez choisi : " + menuChoisi);
            Console.ReadLine();
        }

        private static int GererMenu(List<MenuItem> menu)
        {
          
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Index}. {ligne.Libelle}");
            }

            int choix;
            choix = int.Parse(Console.ReadLine());

            while (true)
            {
                foreach (MenuItem item in menu)
                {
                    if (choix == item.Index)
                    {
                        return choix;
                    }
                }
                Console.WriteLine("Erreur, saisir un choix");
                choix = int.Parse(Console.ReadLine());

            }
            return -1;

            //return singleOrDefault(x=> x.Index===choix) is null :choix: -1
        }

        public class MenuItem
        {
            public string Libelle { get; set; }
            public int Index { get; set; }

            public MenuItem (string libelle, int index)
            {
                Libelle = libelle;
                Index = index;
            }
        }



    }
}
