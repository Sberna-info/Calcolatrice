using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOperazioni
{
    public class ClassOperazioni1
    {
        public static double LeggiNumeroDouble()
        {
            Console.Write("inserisci il numero con cui vuoi fare le operazioni: ");
            double n = double.Parse(Console.ReadLine());
            return n;
        }

        public static double? DoubleScelta(double n1, double n2)
        {
            double? risultato = null;
            Console.Write("Per scegliere quale operazione fare digita il numero accanto:\n1 = somma \n2 = sottrazione \n3 = moltiplicazione \n4 = divisione \n");
            string str = Console.ReadLine();

            switch (str)
            {
                case "1":
                case "somma":
                case "+":
                    risultato = n1 + n2;
                    Console.WriteLine($"La somma tra i due numeri è: {risultato}");
                    break;

                case "2":
                case "sottrazione":
                case "-":
                    risultato = n1 - n2;
                    Console.WriteLine($"La sottrazione tra i due numeri è: {risultato}");
                    break;

                case "3":
                case "moltiplicazione":
                case "*":
                    risultato = n1 * n2;
                    Console.WriteLine($"La moltiplicazione tra i due numeri è: {risultato}");
                    break;

                case "4":
                case "divisone":
                case "/":
                    risultato = n1 / n2;
                    Console.WriteLine($"La divisione tra i due numeri è: {risultato}");
                    break;

                default:
                    Error();
                    break;

            }
            return risultato;
        }

        public static void Error()
        {
            Console.WriteLine("Errore, operazione scelta non valida.");
        }
        

        
    }
   
}
