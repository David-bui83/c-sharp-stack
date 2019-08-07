using System;
using System.Collections.Generic;

namespace deck
{
    public class Player
    {
        public string Name;
        public Deck Deck;
        public List<Card> Hand;

        public Player(string name){
            this.Name = name;
          
            this.Hand = new List<Card>();
        }

        public Card Draw(Deck deck){
            Card card = deck.deal();
            this.Hand.Add(card);
            return card;
        }
        public Card Discard(int index){
            
            if(index>=this.Hand.Count){
                return null;
            }else{
                Card card = this.Hand[index];
                this.Hand.RemoveAt(index);
                return card;
            }
        }

        public void ShowHand(){
            foreach(Card card in Hand){
                System.Console.WriteLine(card.StringVal + " " + card.Suit);
            }
        }
    }
}