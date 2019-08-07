namespace deck
{
    public class Card
    {
        public string  StringVal;
        public string Suit;
        public int Val;

        public Card(string stringVal, string suit, int val){
            this.StringVal = stringVal;
            this.Suit = suit;
            this.Val = val;
        }
        
    }
}