using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class PokerStraigth
    {
        static void Main(string[] args)
        {
            List<int> cards = new List<int> { 2, 3, 4, 5, 6 };
            Console.WriteLine("{2, 3, 4 ,5, 6} Es escalera: " + isStraight(cards));

            cards = new List<int> { 14, 5, 4, 2, 3 };
            Console.WriteLine("{14, 5, 4 ,2, 3} Es escalera: " + isStraight(cards));

            cards = new List<int> { 7, 7, 12, 11, 3, 4, 14 };
            Console.WriteLine("{7, 7, 12 ,11, 3, 4, 14} Es escalera: " + isStraight(cards));

            cards = new List<int> { 7, 3, 2 };
            Console.WriteLine("{7, 3, 2} Es escalera: " + isStraight(cards));

            Console.ReadLine();
        }

        public static bool isStraight(List<int> cards)
        {

            bool respuesta = false;

            int last = 0;
            int count = 0;
            int valor = cards.Count() >= 5 ? 5 : cards.Count();

            cards.Sort();

            if (cards.Contains(14))
            {
                cards.Add(1);
                cards.Sort();
                valor = valor - 1;
            }


            foreach (int card in cards)
            {
                if (card.Equals(last)) {
                    continue;
                }
                else if (card.Equals(++last)) {
                    count++;
                    last = card;
                }
                else
                {
                    count = 1;
                    last = card;
                }

                if (count.Equals(valor))
                {
                    respuesta = true;
                }

            }

            return respuesta;

        }
    }
}
