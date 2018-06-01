using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.NewFolder1
{
    class Menu
    {
        private List<MenuItem> menuItems;
        private int i;

        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        /// <summary>
        /// Insérer un menuItem dans le menu
        /// </summary>
        /// <param name="item">Element à insérer dans le menu</param>
        /// <exception cref="ArgumentException">Si le numéro de l'item est déjà dans le menu</exception>
        public void InsererLigne(MenuItem item)
        {
           /*foreach (var ligne in menuItems)
            {
                if(ligne.Index == item.Index)
                {
                    // ArgumentException ex = new ArgumentException
                    throw new ArgumentException($"Le numéro {item.Index} existe déjà dans le menu.");
                }
            }*/

            if (menuItems.Exists( x=> x.Index == item.Index))
            {
                throw new ArgumentException($"Le numéro {item.Index} existe déjà dans le menu.");
            }
            menuItems.Add(item);
        }

        /// <summary>
        /// Afficher les élements du menu
        /// </summary>
        public void Afficher()
        {
            foreach (MenuItem ligne in menuItems)
            {
                Console.WriteLine($"{ligne.Index}. {ligne.Libelle}");
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


        /*private List<MenuItem> menuItems;

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

        }*/
    }
}
