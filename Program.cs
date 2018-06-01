using ConsoleApp4.NewFolder1;
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
            /*List<MenuItem> list = new List<MenuItem>
            {
              new MenuITem{Numero = 1, Libelle = "menu 1"}, 
              new MenuITem{Numero = 3, Libelle = "menu 3"}, 
              new MenuITem{Numero = 4, Libelle = "menu 4"}, 
            };*/

            Menu menu = new Menu();
            menu.InsererLigne(new MenuItem {Index = 1, Libelle = "Voyages"});
            menu.InsererLigne(new MenuItem {Index = 2, Libelle = "Clients"});
            menu.InsererLigne(new MenuItem {Index = 3, Libelle = "Dossiers"});
            //menu.InsererLigne(new MenuItem {Index = 4, Libelle = "menu 4"});
            
            menu.Afficher();
            
            int resulat = menu.Choisir();

            switch (resultat)
            {
                case 1:
                    SousMenuVoyages();
                    break;
                case 2:
                    SousMenuClients();
                    break;
                case 3:
                    SousMenuDossiers();
                    break;
            }
            Console.ReadLine();

            Console.WriteLine(resulat);
            Console.ReadLine();

            /*Menu menu = new Menu();
            menu.InsererLigne(new MenuItem("choix 2", 2));
            menu.InsererLigne(new MenuItem("choix 4", 4));
            menu.InsererLigne(new MenuItem("choix 6", 6));
            menu.InsererLigne(new MenuItem("choix 8", 8));
            menu.InsererLigne(new MenuItem("choix 10", 10));


            int menuChoisi = menu.GererMenu();

            Console.WriteLine("Vous avez choisi : " + menuChoisi);
            Console.ReadLine();*/
        }

        /// <summary>
        /// Affiche un menu et test les entrées de l'utilisateur
        /// </summary>
        /// <param name="menu">Liste des choix possibles</param>
        /// <returns> LE choix de l'utilisat</returns>


        /*private static int GererMenu(List<MenuItem> menu)
        {
            // Affiche les élements du Menu
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Index}. {ligne.Libelle}");
            }

            // Récupération du choix de l'utilisateur
            Console.WriteLine("Saisir un  choix : ");
            int choix;
            choix = int.Parse(Console.ReadLine());

            // Test du choix par rapport aux éléments du menu
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
            // return -1;

            // return singleOrDefault(x=> x.Index===choix) is null ? choix: -1
        }*/

        /// <summary>
        /// Représente une ligne de menu
        /// </summary>


        /*public class MenuItem
        {
            public string Libelle { get; set; }
            public int Index { get; set; }

            public MenuItem (string libelle, int index)
            {
                Libelle = libelle;
                Index = index;
            }
        }*/

        /*public class Menu
        {
            private List<MenuItem> menuItems;

            public Menu()
            {
                menuItems = new List<MenuItem>();
            }

            public int GererMenu()
            {
                //Afficher Menu
                Afficher();

                return Choisir();
            }

            public void Afficher()
            {
                foreach (MenuItem Item in menuItems)
                {
                    Console.WriteLine($"{Item.Index}. {Item.Libelle}");
                }
            }

            public int Choisir()
            {
                // Demande 1
                string saisie = Console.ReadLine();
                int numeroMenu = int.Parse(saisie);

                // Entrée utilisateur
                while (true)
                {
                    foreach (MenuItem item in menuItems)
                    {
                        if (numeroMenu == item.Index)
                        {
                            return numeroMenu;
                        }
                    }
                    Console.WriteLine("Erreur, saisir un choix");
                    numeroMenu = int.Parse(Console.ReadLine());

                }

            }

            public void InsererLigne(MenuItem menuItem)
            {
                menuItems.Add(menuItem);

            }

        }*/


    }
}
