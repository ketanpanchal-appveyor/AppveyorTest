using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossOver
{


    using System;
    public class ExactDenomination
    {
        public ExactDenomination(int rent, int[] denoms)
        {
            this.rent = rent;
            this.denominations = denoms;
        }
        public int[][] OPT;
        public String[][] optimalDenomiation;

        public List<String> allPossibleCombinations = new List<String>();

        private int rent;

        public int[] denominations;
    };
    public class CoinChange
    {
        private static void recursiveFindCombination(String tempSol, int sIndex, int remainingRent, ExactDenomination answer)
        {
            for (int i = sIndex; i < answer.denominations.Length; i++)
            {
                int temp = remainingRent - answer.denominations[i];
                String tempSoln = tempSol + "" + answer.denominations[i] + ",";
                if (temp < 0)
                {
                    break;
                }
                if (temp == 0)
                {
                    answer.allPossibleCombinations.Add(tempSoln);
                    break;
                }
                else
                {
                    recursiveFindCombination(tempSoln, i, temp, answer);
                }
            }
        }
        public static ExactDenomination getAllDenominations(int rent, int[] denoms)
        {
            ExactDenomination soln = new ExactDenomination(rent, denoms);
            String tempString = "";
            recursiveFindCombination(tempString, 0, rent, soln);
            return soln;
        }
        /**
         * Complete the function below.
         * DONOT MODIFY anything outside this function!
         */
        static long numberOfWaysToPay(int[] denominations, int denominationCount, int rent)
        {
            ExactDenomination exactDenomination = new ExactDenomination(rent, denominations);
            String tempString = "";
            recursiveFindCombination(tempString, 0, rent, exactDenomination);
            return exactDenomination.allPossibleCombinations.Count();
        }

        /**
         * DO NOT MODIFY THIS METHOD!
         */
        static void Main(String[] args)
        {
            int denominationCount = 0;
            denominationCount = Convert.ToInt32(Console.ReadLine());
            int[] denominations = new int[denominationCount];
            String[] bankNotes = Console.ReadLine().Split(' ');
            for (int i = 0; i < denominationCount; i++)
            {
                denominations[i] = Convert.ToInt32(bankNotes[i]);
            }

            int rent = Convert.ToInt32(Console.ReadLine());
            long result = numberOfWaysToPay(denominations, denominationCount, rent);

            Console.WriteLine(result);
            Console.ReadLine();
        }


    }
}
