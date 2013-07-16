using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
	public class Mines
	{
		public class GamePoints
		{
			string name;
			int points;

			public string Name
			{
				get { return name; }
				set { name = value; }
			}

			public int Points
			{
				get { return points; }
				set { points = value; }
			}

			public GamePoints() { }

			public GamePoints(string name, int points)
			{
				this.name = name;
				this.points = points;
			}
		}

		static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] gameField = GenerateBoard();
			char[,] bombs = PutBombs();
			int pointsCounter = 0;
			bool mineBang = false;
			List<GamePoints> gameChampions = new List<GamePoints>(6);
			int fieldRow = 0;
			int fieldCow = 0;
			bool gameOn = true;
			const int maxPoints = 35;
			bool gameOver = false;

			do
			{
				if (gameOn)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					GameField(gameField);
					gameOn = false;
				}
				Console.Write("Daj red i kolona : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out fieldRow) &&
					int.TryParse(command[2].ToString(), out fieldCow) &&
						fieldRow <= gameField.GetLength(0) && fieldCow <= gameField.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						Rankings(gameChampions);
						break;
					case "restart":
						gameField = GenerateBoard();
						bombs = PutBombs();
						GameField(gameField);
						mineBang = false;
						gameOn = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (bombs[fieldRow, fieldCow] != '*')
						{
							if (bombs[fieldRow, fieldCow] == '-')
							{
								PlayerTurn(gameField, bombs, fieldRow, fieldCow);
								pointsCounter++;
							}
							if (maxPoints == pointsCounter)
							{
								gameOver = true;
							}
							else
							{
								GameField(gameField);
							}
						}
						else
						{
							mineBang = true;
						}
						break;
					default:
						Console.WriteLine("\nGreshka! nevalidna Komanda\n");
						break;
				}
				if (mineBang)
				{
					GameField(bombs);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", pointsCounter);
					string nickname = Console.ReadLine();
					GamePoints gamePoints = new GamePoints(nickname, pointsCounter);
					if (gameChampions.Count < 5)
					{
						gameChampions.Add(gamePoints);
					}
					else
					{
						for (int i = 0; i < gameChampions.Count; i++)
						{
							if (gameChampions[i].Points < gamePoints.Points)
							{
								gameChampions.Insert(i, gamePoints);
								gameChampions.RemoveAt(gameChampions.Count - 1);
								break;
							}
						}
					}
					gameChampions.Sort((GamePoints r1, GamePoints r2) => r2.Name.CompareTo(r1.Name));
					gameChampions.Sort((GamePoints r1, GamePoints r2) => r2.Points.CompareTo(r1.Points));
					Rankings(gameChampions);

					gameField = GenerateBoard();
					bombs = PutBombs();
					pointsCounter = 0;
					mineBang = false;
					gameOn = true;
				}
				if (gameOver)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					GameField(bombs);
					Console.WriteLine("Daj si imeto, batka: ");
					string playerName = Console.ReadLine();
					GamePoints playerPoints = new GamePoints(playerName, pointsCounter);
					gameChampions.Add(playerPoints);
					Rankings(gameChampions);
					gameField = GenerateBoard();
					bombs = PutBombs();
					pointsCounter = 0;
					gameOver = false;
					gameOn = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void Rankings(List<GamePoints> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} boxes",
						i + 1, points[i].Name, points[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty Rankings!\n");
			}
		}

		private static void PlayerTurn(char[,] gameBoard,
			char[,] bombs, int boardRow, int boardCol)
		{
			char bombsCount = HowMuchMines(bombs, boardRow, boardCol);
			bombs[boardRow, boardCol] = bombsCount;
			gameBoard[boardRow, boardCol] = bombsCount;
		}

		private static void GameField(char[,] board)
		{
			int RRR = board.GetLength(0);
			int KKK = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < RRR; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < KKK; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] GenerateBoard()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PutBombs()
		{
			int rows = 5;
			int cows = 10;
			char[,] gameBoard = new char[rows, cows];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cows; j++)
				{
					gameBoard[i, j] = '-';
				}
			}

			List<int> r3 = new List<int>();
			while (r3.Count < 15)
			{
				Random random = new Random();
				int asfd = random.Next(50);
				if (!r3.Contains(asfd))
				{
					r3.Add(asfd);
				}
			}

			foreach (int i2 in r3)
			{
				int col = (i2 / cows);
				int row = (i2 % cows);
				if (row == 0 && i2 != 0)
				{
					col--;
					row = cows;
				}
				else
				{
					row++;
				}
				gameBoard[col, row - 1] = '*';
			}

			return gameBoard;
		}

        //I could not figure out what 'kolkoo' does..
		private static void CalculateMines(char[,] gameBoard)
		{
			int boardCol = gameBoard.GetLength(0);
			int boardRow = gameBoard.GetLength(1);

			for (int i = 0; i < boardCol; i++)
			{
				for (int j = 0; j < boardRow; j++)
				{
					if (gameBoard[i, j] != '*')
					{
						char kolkoo = HowMuchMines(gameBoard, i, j);
						gameBoard[i, j] = kolkoo;
					}
				}
			}
		}

		private static char HowMuchMines(char[,] gameBoard, int rows, int cols)
		{
			int count = 0;
			int boardRows = gameBoard.GetLength(0);
			int boardCols = gameBoard.GetLength(1);

			if (rows - 1 >= 0)
			{
				if (gameBoard[rows - 1, cols] == '*')
				{ 
					count++; 
				}
			}
			if (rows + 1 < boardRows)
			{
				if (gameBoard[rows + 1, cols] == '*')
				{ 
					count++; 
				}
			}
			if (cols - 1 >= 0)
			{
				if (gameBoard[rows, cols - 1] == '*')
				{ 
					count++;
				}
			}
			if (cols + 1 < boardCols)
			{
				if (gameBoard[rows, cols + 1] == '*')
				{ 
					count++;
				}
			}
			if ((rows - 1 >= 0) && (cols - 1 >= 0))
			{
				if (gameBoard[rows - 1, cols - 1] == '*')
				{ 
					count++; 
				}
			}
			if ((rows - 1 >= 0) && (cols + 1 < boardCols))
			{
				if (gameBoard[rows - 1, cols + 1] == '*')
				{ 
					count++; 
				}
			}
			if ((rows + 1 < boardRows) && (cols - 1 >= 0))
			{
				if (gameBoard[rows + 1, cols - 1] == '*')
				{ 
					count++; 
				}
			}
			if ((rows + 1 < boardRows) && (cols + 1 < boardCols))
			{
				if (gameBoard[rows + 1, cols + 1] == '*')
				{ 
					count++; 
				}
			}
			return char.Parse(count.ToString());
		}

        public static char[,] bombs { get; set; }
    }
}
