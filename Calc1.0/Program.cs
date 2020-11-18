using System;
using ClassOperazioni;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = ClassOperazioni1.LeggiNumeroDouble();
            double n2 = ClassOperazioni1.LeggiNumeroDouble();
            double? risultato = ClassOperazioni1.DoubleScelta(n1, n2);
            Console.ReadLine();
        }
    }
}
