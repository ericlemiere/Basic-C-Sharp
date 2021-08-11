using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            using (StreamWriter file = new StreamWriter(@"C:\Users\ericr\Documents\GitHub\Basic-C-Sharp\TwentyOne\logs\log.txt", true))
            {
                file.WriteLine(card + " " + DateTime.Now);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
