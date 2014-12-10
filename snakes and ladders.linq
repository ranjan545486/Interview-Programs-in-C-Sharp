<Query Kind="Program" />

void Main()
{
	string[] playernames = {"Maria","Ranjan","Shrikl"};
	int numSquares = 12;
	int[,] snakesFromTo = {{11,5}};
	int[,] laddersFromTo = {{2,6},{7,9}};
	
}

public sealed class Game
{
	private List<Player> players = new List<players>();
	private Board board = null;
	private Player winner;
	
	private sealed class Die
	{
		private static sealed int MINVALUE = 1;
		private static sealed int MAXVALUE = 6;
		
		public int Roll()
		{
			return random(MINVALUE,MAXVALUE);
		}
		
		private int RandomVal(int min, int max)
		{
			if(min<max)
			{
			 	Random rand = new Random();			 
				return (int)(Random.Next(min,max));
			}
		}
		
	}
	
	private void movePlayer(int roll)
	{
		Player currentPlayer = players.Remove(
	}
	
}

public sealed class Player
{
	
}

// Snake and Ladders Program
// Main -> initializes/instantiates the game, passing to the constructor the necessary parameters(player names, number of squares, snakes and ladders position and transport data)
// Game-> contains the list of squares and players
// 
