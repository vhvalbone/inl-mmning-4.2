using System;
namespace inlämmning_4._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett heltal");
            int heltal=int.Parse(Console.ReadLine());
            int störst = heltal;
            string svar = "";
                while(svar !="n")
            {
                Console.WriteLine("skriv in ett till heltal om du vill? j/n");
                svar = Console.ReadLine();
                if (svar == "n")
                {
                    break;
                }
                Console.WriteLine("skriv in ett till heltal");
                int nyttTal=int.Parse(Console.ReadLine());
                if (nyttTal > störst) ;
                {
                    störst = nyttTal;
                }
                
            }
            Console.WriteLine("det största talet är " + störst);
        }
    }
}
