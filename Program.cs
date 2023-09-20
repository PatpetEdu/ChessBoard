namespace ChessBoard
{
    internal class Program        //***NET23 Patrik Petterson***
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; //Används för att få symbolerna att fungera i konsolen

            //variabler för våra värden av vit eller svart ruta
            string white = "■";
            string black = "□";

            int number;


            while (true) //använder en while loop för att kontrollera så användaren har matat in ett värde mellan 1-100
            {
                Console.WriteLine("Ange valfri siffra mellan 1-100"); //text till användaren

                string userInput = Console.ReadLine(); //ber användaren mata in ett värde som lagras i userInput



                if (int.TryParse(userInput, out number) && number >= 1 && number < 100)
                //Använder TryParse som ett villkor i en if-sats, kontrollerar om userinput uppfyller villkoren för att kunna skriva ut första kodblocket.



                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltigt värde! Ange ett värde mellan 1-100"); //om villkoret i den övre if-satsen är falskt så skrivs texten ut till användaren.
                }




            }

            for (int i = 0; i < number; i++) //yttre for loop


            {
                for (int j = 0; j < number; j++) //inre for loop
                {



                    string olikaRader = (i + j) % 2 == 0 ? white : black; //beräknar värdet av strängen om det ska vara vit eller svart symbol.
                    Console.Write(olikaRader); //Skriver ut värdet på konsolen med antingen vit eller svart i en rad.



                }

                Console.WriteLine(); //lägger till en radbrytning på tidigare utskrivet så att värdet av varje kollumn läggs på olika rader.



            }













        }
    }
}