using BowlingGame;
using Xunit;

namespace BowlingGame.Test
{
	public class GameShould
	{
		[Fact]
		public void Game_Class_Exists()
		{
			new Game(); //Check Game class exists
		}

		[Fact]
		public void Roll_And_Score_Exists()
		{
			var game = new Game();

			for (var i = 0; i < 20; i++)
			{
				game.Roll(0); //Check Roll exists
			}

			Assert.Equal(0, game.Score()); //Check Score exists
		}

		[Fact]
		public void Handle_Spare()
		{
			var game = new Game();
			
			//Spare (10 in two rolls)
			game.Roll(5);
			game.Roll(5);

			game.Roll(2);

			for (var i = 0; i < 17; i++)
			{
				game.Roll(0); //Check Roll exists
			}

			Assert.Equal(14, game.Score());
		}

		[Fact]
		public void Handle_Strike()
		{
			var game = new Game();

			//Strike (10 in one rolls)
			game.Roll(10);
			game.Roll(3);
			game.Roll(4);

			for (var i = 0; i < 16; i++)
			{
				game.Roll(0); //Check Roll exists
			}

			Assert.Equal(24, game.Score());
		}

		[Fact]
		public void PerfectGame()
		{
			var game = new Game();
			for(int i = 0; i < 12; i ++)
			{
				game.Roll(10); //Roll all 10s
			}

			Assert.Equal(300, game.Score());
		}
	}
}
