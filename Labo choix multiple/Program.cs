using System;

namespace Labo_choix_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable pour le jeu

            string nomjoueur1 = "";
            string nomjoueur2 = "";
            string choix1 = "";
            string choix2 = "";

            string choix4 = "";
            string choix5 = "";
            string choix6 = "";
            //Canche attraper police

            Random police = new Random();
            int chancepopo = police.Next(1, 3);

            //Chance de pas etre arreter
            Random policia = new Random();
            int popoarrete = policia.Next(1, 7);
            string déaffiche = "";



            //Texte d'affichage principal
            Console.WriteLine("Bonjour cher joueur. Ce jeu est une simulation d'une situation possible de folie exessive." +
                "Pour cette situation, nous allons vous demander d'entrer un nom d'utilisateur qui sera notre personage principal." +
                "Nous vous demandons également d'entrer un deuxième prénom pour le nom du personnage secondaire.");


            // Saisir nom joueur


            Console.WriteLine();
            Console.WriteLine("Personnage Principal");
            nomjoueur1 = Convert.ToString(Console.ReadLine());



            Console.WriteLine();
            Console.WriteLine("Personnage Secondaire");
            nomjoueur2 = Convert.ToString(Console.ReadLine());



            // Début
            Console.WriteLine("C'est donc " + nomjoueur1 + " qui s'ennuie et qui décide d'aller voler un enfant car" +
                " il s'ennuie et il en a toujours voulus un avec sa femme mais ils n'ont jamais pu. Il décide donc " +
                "d'aller dans un des pires orphelinas pour voler un enfant. Rendu sur place, deux enfants l'inspire et il hésite." +
                "Il ya l'enfant A et l'enfant B. Lequel " + nomjoueur1 + " doit-il choisir? (Entrer A puis entrer pour" +
                " l'enfant A ou B puis entrer pour l'enfant B.)");
            choix1 = Convert.ToString(Console.ReadLine());



            //Debut Choix a

            //Premier if

            if (choix1 == "A" || choix1 == "a")

            {
                Console.WriteLine(nomjoueur2 + "  ne semble pas vous aimer cher " + nomjoueur1 + "! Comment s'en sortir?" +
                    " Deux options s'offre a vous, le menacer avec vos katanas de vous suivre (A) ou le prendre en poche" +
                    " de patate et le kidnapper (B). À vous de choisir!");

                choix2 = Convert.ToString(Console.ReadLine());


                //Deuxème if

                if (choix2 == "A" || choix2 == "a")

                {
                    Console.WriteLine("Enfant pleure et vous devez donc le prendre en poche de patate pour le sauver");
                }


                Console.WriteLine("Vous prenez donc " + nomjoueur2 + " dans ses bras après plusieurs tentatives " + nomjoueur1 + " doit maintenant sortir" +
                    "Il y a trois options qui sont disponible: La porte d'en arrière(A), La porte d'en avant(B) ou La fenêtre(C). Que choisis" + nomjoueur1 + ".");




                choix6 = Convert.ToString(Console.ReadLine());

                //Conséquence du 3e choix

                if (choix6 == "A" || choix6 == "a")
                {
                    Console.WriteLine(nomjoueur1 + " est encerclé par la police et dois remettre " + nomjoueur2 + " à contrecoeur.");
                }



                if (choix6 == "B" || choix6 == "b")
                {
                    if (chancepopo == 1)
                    {
                        Console.WriteLine(nomjoueur1 + " est encerclé par la police et dois remettre " + nomjoueur2 + " à contrecoeur.");
                    }
                    if (chancepopo == 2)
                    {
                        Console.WriteLine("Vous vous échapper de justesse (avec un peu de chance tout de même ...) et vous arriver chez vous sains et sauf avec" + nomjoueur2);
                    }

                }


                if (choix6 == "C" || choix6 == "c")
                {
                    if (chancepopo == 1)
                    {
                        Console.WriteLine(nomjoueur1 + "s'en sort de justesse mais ne réussi pas a ramener" + nomjoueur2 + "sains et sauf chez lui");
                    }

                    if (chancepopo == 2)
                    {
                        Console.WriteLine("ous vous échapper de justesse (avec un peu de chance tout de même ...) et vous arriver chez vous sains et sauf avec" + nomjoueur2);
                    }

                }


            }







            // ChoixB
            if (choix1 == "B" || choix1 == "b")
            {
                Console.WriteLine(nomjoueur2 + " semble bien vous aimer! Voulez vous le prendre par la main et sortir " +
                    "(A) ou le prendre sur vos épaules et vous sauver avec lui(B)? ");
                choix4 = Convert.ToString(Console.ReadLine());
            }


            //Option A
            if (choix4 == "A" || choix4 == "a")
            {
                Console.WriteLine(nomjoueur1 + " est encerclé par la police et dois remettre" + nomjoueur2 + "à contrecoeur.");
            }
            //option B
            if (choix4 == "B" || choix4 == "b")
            {
                Console.WriteLine(nomjoueur1 + " réussi à s'enfuir de justesse de la " +
                    " police qui avait entourer les lieux lors de l'émouvante réunion.-Mais ou va t-on " + nomjoueur1 + " dit " + nomjoueur2
                    + "A la maison! Mais " + nomjoueur1 + " n'avais pas penser a ce qu'ils feraient et du donc se résoudre a 3 choix: " +
                    "(A) Il envoye " + nomjoueur2 + " à l'école, (B) " + nomjoueur1 + " entraine " + nomjoueur2 + " a devenir un ninja ou (C)" +
                    " ils font des deux ");
                choix5 = Convert.ToString(Console.ReadLine());
            }


            //Option A
            if (choix5 == "A" || choix5 == "a")
            {
                Console.WriteLine("Son fils devenu le 2e Albert Einstein et fit avancée la science au point ou il inventa une machine à remonter le temps pour sauver son père ''adoptif'' et l'aider a se sauver dans le passer!");
            }


            //Option B
            if (choix5 == "B" || choix5 == "b")
            {
                Console.WriteLine("Ils vous retrouvent quelques années plus tard et seul un lancer de dé peut vous sauvez!" +
                    " Si le nombre est 1,2,3 ils vous laissent partir. Si le nombre est 4,5,6 il" +
                    " vous arrêtes et vous mourrez en prison." + nomjoueur2 + " lance le dé.");

                Console.WriteLine("");
                Console.WriteLine("Appuyer sur entrer pour lancer le dé");
                Console.ReadKey();


                Console.WriteLine("");

                déaffiche = Convert.ToString(policia);

                Console.WriteLine("");

                Console.WriteLine("Le dé a tombé sur " + popoarrete);

                //Si 123
                if (popoarrete == 1 || popoarrete == 2 || popoarrete == 3)
                {
                    Console.WriteLine("Policier: Vous êtes en état d'arrestation pour le kidnapping de" + nomjoueur2 + " et pour délit de fuite durant plusieurs années.");
                }

                //Si345
                if (popoarrete == 4 || popoarrete == 5 || popoarrete == 6)
                {
                    Console.WriteLine("Nous vous laissons tranquille pour cette fois. Mais on vous a à l'oeil" + nomjoueur1);
                }


            }



            //Option C
            if (choix5 == "C" || choix5 == "c")
            {
                Console.WriteLine("Ils vivent une vie heureuse et chevauchère des licornes jusqu'à la fin des temps!");
            }




            // Fin
            Console.ReadKey();
        }
    }
}
