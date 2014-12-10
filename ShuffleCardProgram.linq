<Query Kind="Program">
  <Connection>
    <ID>06d48d01-dfb4-43e1-85c8-4928764db481</ID>
    <Driver>AstoriaAuto</Driver>
    <Server>http://dbsalarmapi/AlarmService.svc</Server>
  </Connection>
</Query>

void Main()
{
	Deck myDeck = new Deck();
	myDeck.Shuffle();
	/*foreach (Card c in myDeck.cards)
	{
		Console.WriteLine(c);
	}*/
}

public class Deck
{
  public Card[] cards = new Card[52];
  
  public void Shuffle()
  {
	int numberOfCards = 52;
	int randomNum;
	Card temp;
	Random r = new Random();
	while(numberOfCards>0)
	{
		randomNum = r.Next() % numberOfCards;
		temp = this.cards[randomNum];
		//randomNum.Dump();
		if(randomNum-1>0)
		{
		this.cards[randomNum] = this.cards[randomNum -1];
		this.cards[randomNum - 1] = temp;
		}
	   numberOfCards --;
	}

	foreach (Card c in this.cards)
	{
		Console.WriteLine(c);
	}
	
  }
  
  public Card GetRandomCard()
  {
     return null;
  }
  
  private int GetRandomNumbers()
  {
   throw new NotImplementedException();
  }
  
}
	
	public class Card
	{
		public int Value{get; private set;}
		public Suit CardSuit{get; private set;}
		
		public Card(int value, Suit suit)
		{
			this.Value = value;
			this.CardSuit = suit;
		}
	}
	
	public enum Suit
	{
		Hearts = 0,
		Diamonds = 1,
		Spade = 2,
		Clubs = 3
	}

// Define other methods and classes here