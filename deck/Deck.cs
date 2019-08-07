using System;
using System.Collections.Generic;

namespace deck
{
    public class Deck
    {
        public List<Card> Cards;
        
        public Deck(){
            this.Cards = new List<Card>();
            this.Reset();
        }

        public void Reset(){
            this.Cards = new List<Card>();
            string[] suits = {"Clubs","Spades","Hearts","Diamonds"};
            string[] stringVal = {"Ace","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King"};
            
            int num = 0;
            foreach(string suit in suits){
                foreach(string val in stringVal){
                    Card card = new Card(val,suit,num++);
                    this.Cards.Add(card);
                }
            }
        }

        public void Shuffle(){
            Random rand = new Random();

            for(int i = 0; i<this.Cards.Count;i++){
                int randnum = rand.Next(1,13);
                Card temp = this.Cards[randnum];
                this.Cards[randnum] = this.Cards[i];
                this.Cards[i] = temp;
            }

        }

        public Card deal(){
            this.Shuffle();
            Card card = this.Cards[this.Cards.Count - 1];
            this.Cards.Remove(card);
            System.Console.WriteLine($"Dealt card: {card.StringVal} of {card.Suit} " );
            System.Console.WriteLine($"Card count: {this.Cards.Count}" );
            

            return card;
        }

        public void Show(){
            foreach(Card card in this.Cards){
                System.Console.WriteLine($"Suit: {card.Suit} - Number: {card.StringVal}");
            }
        }
    }
}