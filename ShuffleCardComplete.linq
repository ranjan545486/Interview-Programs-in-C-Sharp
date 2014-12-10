<Query Kind="Program">
  <Connection>
    <ID>06d48d01-dfb4-43e1-85c8-4928764db481</ID>
    <Driver>AstoriaAuto</Driver>
    <Server>http://dbsalarmapi/AlarmService.svc</Server>
  </Connection>
</Query>

 static void Main(string[] args)  
        {  
            //Create a new Deck with 52 cards and write out its values.  
            Deck deck = new Deck(52);  
            Console.WriteLine("Before shuffle");  
            foreach (Card card in deck.Cards)  
            {  
                Console.WriteLine(card.number);  
            }  
  
            //shuffle deck and write out its values.  
            deck.Shuffle();  
            Console.WriteLine();  
            Console.WriteLine("After shuffle");  
            foreach (Card card in deck.Cards)  
            {  
                Console.WriteLine(card.number);  
            }  
  
            Console.WriteLine("Press ENTER to quit");  
             
		}
		
    public class Card  
    {  
        public int number;  
    }  
  
    public class Deck  
    {  
        public Deck(int numberOfCards)  
        {  
            this.Cards = new Card[numberOfCards];  
            for (int i = 1; i <= numberOfCards; i++)  
            {  
                Card c = new Card();  
                c.number = i;  
                this.Cards[i - 1] = c;  
            }  
        }  
  
        public Card[] Cards;  
  
        public void Shuffle()  
        {  
            Card[] currentDeck = this.Cards;  
            this.Cards = new Card[currentDeck.Length];  
            List<int> freeIndices = new List<int>(currentDeck.Length);  
            Random rand = new Random();  
  
            for (int idx = 0; idx < currentDeck.Length; idx++)  
                freeIndices.Add(idx);  
  
            foreach (Card card in currentDeck)  
            {  
                int indexOfNewIdx = rand.Next(freeIndices.Count);  
                int newIdxOfCard = freeIndices[indexOfNewIdx];  
  
                this.Cards[newIdxOfCard] = card;  
                freeIndices.Remove(newIdxOfCard);  
  
            }  
        }  
    }   
