using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_CMD_GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valeur1 = 1;
            int valeur2 = 21;
            int result = Calc(valeur1, valeur2);

            Affiche_Resultat(result);
        }







        //------------------------------------------------------------

        static int Calc(int P_valeur1, int P_valeur2)
        {
            return P_valeur1 + P_valeur2;
        }

        static void Affiche_Resultat(int P_result)
        {
            Console.WriteLine(P_result);
        }
    }
}
