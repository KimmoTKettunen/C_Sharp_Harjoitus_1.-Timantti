namespace displayDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;  // r = annettu rivimäärä
                    
            Console.WriteLine("Display the pattern like diamond:");
            Console.WriteLine("------------------------------------- \n"); //silmämääräisesti viivat ja 2 tyhjää riviä, toinen writeline ja toinen \n
            Console.Write("Input number of rows (half of the diamond) ");  // Write niin pyydetty numero tulee samalle riville eikä alle.

            r = Convert.ToInt16(Console.ReadLine()); // muutetaan annettu arvo Int muotoon, koska ohjelma muuten lukee annetun numeron tekstimuotona (string, eikä int kuten tarvitaan)
                                                     // voisi käyttää ToInt32 mutta harjoituksessa käytetään vain pieniä lukuja

                                                     // Timantti saadaan tehtyä kun muodostetaan 2 pyramiidia, ensin yläosa ja sitten tehdään alaosa ylösalaisin

            // Ensin tehdään yläosa
            for (int a = 0; a <= r ; a++)    // r = annettu rivimäärä
            {
                for (int b = 1; b <= r - a; b++)
                    Console.Write(" ");  // ensin tehdään tyhjät ruudut, aloitus arvo on 0 joten ensimmäinen rivi on 5 tyhjää
                                         // r (esim 5) - 0 == 5, joten 5 tyhjää merkkiä
                                         // toisella loop kierroksella arvo nousee yhdellä 5 - 1 == 4, joten ohjelma tekee 4 tyhjää jne.
                                         // Helppo havannoida ja testailla, jos tyhjän ruudun sijaan laittaa merkiksi esim. 0
                
                for (int b  = 1; b <= 2 * a - 1;b++)
                    Console.Write("*");  // tällä pätkällä tehdään * merkit esittämään timanttia.                                       
                                         // 2*a-1 kaavalla, saadaan lisättyä aina 2 tähteä kerrallaan. Aluksi on 1 sitten 3, 5 jne.
                                         // 2*1-1 = 1, 2*2-1 = 3, 2*3-1 = 5 jne.

                Console.Write("\n");     // tällä siirrytään joka kierroksella aina seuraavalle riville
                                         // ohjelma toistaa nämä kuviot niin monta kertaa, kunnes a <= r, eli kunnes ollaan toistettu pyydetty määrä
            }
            // Sitten alaosa

            for (int a = r - 1; a >= 0; a--)  // voisi olla myös muodossa for (int a = r - 1; a >= 1; a--), mutta silloin kuvio ei olisi sama
                                              // tämä jättäisi viimeiset 5 tyhjää tekemättä, helpompi havannoida jos käyttää tyhjän sijasta esim 0
                                              // lisäämisen sijasta miinustetaan, ja aloitus numeroksi r - 1. Tällöin ei toisteta paksuinta kohtaan
                                              // vaan aloitetaan 4 tähteä (*)ja 1 tyhjästä (" "), eli muodostetaan kuvio toisinpäin.
            {
                for (int b = 1; b <= r - a; b++)
                    Console.Write(" ");

                for (int b = 1; b <= 2 * a - 1; b++)
                    Console.Write("*");

                Console.Write("\n");

                // ohjelma lopettaa kuvion teon, kun a >= 0
                // for loop ylä- ja alaosa tehtynä, loop loppuu

            }
            //Console.ReadLine();
            // readline loopin jälkeen, muuten loop keskeytyisi ja lukisi aina vain yhden rivin kerrallaan ja tekisi aukkoja. 
        }
    }
}

