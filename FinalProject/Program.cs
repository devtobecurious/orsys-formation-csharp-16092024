using SdA.Models.Exceptions;

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Console.WriteLine("A Sam journey");

#region Exécution
DisplayMenu();
int choice = GetChoiceFromUser();
ExecuteActionByChoice(choice);


PrepareGame();

#region POC
//Weapon weapon = new("Epée", 100);
//Character character = new("", 0)
//{
//    Surname = ""
//};

////Vector2D vector = new()
////{
////    X = 10,
////    Y = 20,
////};

////Vector2D vector2 = new()
////{
////    X = 10,
////    Y = 20,
////};
//Vector2D vector = new(10, 20);
//Vector2D vector2 = new(10, 20);

//bool isEqual = vector == vector2;

//if (character.Weapon != null && !string.IsNullOrEmpty(character.Weapon.Label))
//{
//    string upper = character.Weapon.Label.ToUpper();
//}

//string? upper2 = character.Weapon?.Label?.ToUpper();
//upper2?.ToArray();

////if(character.Strength.HasValue)
////{
////    character.Strength.Value.
////}


#endregion

#endregion


#region Code interne
void PrepareGame()
{
	Character hero = new Hero("")
	{
		Surname = "Sam"
	};

	Grid grid = new(20, 20);
	grid.Cells.First(item => item.X == 0 && item.Y == 10).Characters.Add(hero);
	grid.Cells.First(item => item.X == 0 && item.Y == 20).Characters.Add(new Orq("", 10) { Surname = "" });

	var queryCellsEmpty = grid.Cells.Where(item => item.Characters.Count == 0);
	var queryCellsEmptyBis = from item in grid.Cells
							 where item.Characters.Count == 0
							 select item;


	var queryNbCellsWithEnemis = from item in grid.Cells
								 where item.Characters.Any(character => character is Orq)
								 select item;
	var queryNbCellsWithEnemisBis = grid.Cells.Where(cell => cell.Characters.Any(character => character is Orq));
	var nbCells = queryNbCellsWithEnemis.Count();

	try
	{

		hero.Attack(hero);
	}
	catch (DifferentCharacterRequiredException ex) when (ex.Message.Contains("Paf"))
	{
		Console.WriteLine("Oops erreur du développeur ;=)");
	}
	catch (DifferentCharacterRequiredException ex) when (ex.Character != null && ex.Character.Surname.StartsWith("A"))
	{
		Console.WriteLine("Oops erreur du développeur ;=)");
	}
	catch (Exception ex)
	{
		Console.WriteLine("Y a eu une erreur {0}", ex.Message);
	}
	finally
	{
		Console.WriteLine("S'exécute quelque soit l'erreur déclenchée ou pas");

	}
	//catch
	//{
	//    // Loggeur
	//    throw;

	//}
}

DateTime GetBirthDayFromUser()
{
	DateTime date = DateTime.MinValue;

	Console.WriteLine("Ta date de naissance ?");
	var saisie = Console.ReadLine();

	if (DateTime.TryParse(saisie, out date))
	{
		TimeSpan diff = DateTime.Now - date;
		int nbYears = diff.Days / 365;

		if (nbYears < 13)
		{
			Environment.Exit(-1);
		}
	}

	return date;
}

int GetChoiceFromUser()
{
	Console.WriteLine("Saisis ton choix");
	var choiceString = Console.ReadLine();

	int menuIndex = -1;
	if (!int.TryParse(choiceString, out menuIndex))
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Oops mauvaise manip");
		Console.ForegroundColor = ConsoleColor.White;
	}

	return menuIndex;
}

void DisplayMenu()
{
	string displayFormat = "{0}. {1}";

	Console.WriteLine(string.Format(displayFormat, 1.ToString(), "Nouvelle partie", "toto"));
	Console.WriteLine(string.Format(displayFormat, 2, "Charger une partie"));

	//Console.WriteLine(string.Format(displayFormat, 3, "Credits"));
	var credits = "Crédits";
	Console.WriteLine($"{GetLastIndex()}. {credits} {credits}");

	Console.WriteLine(displayFormat, 0, "Quitter");
}

void ExecuteActionByChoice(int choice)
{
	const int NewGame = 1;
	const int LoadGame = 2;

	switch (choice)
	{
		case NewGame:
			{
				Console.WriteLine("On démarre une partie");
			}
			break;

		case LoadGame:
			{
				Console.WriteLine("Quelle partie à charger");
				//string[][][][] tableauDeTableau;
				//string[,,,] matrice;

				//string[] datas = new string[2];
				//datas[0] = "Data 1";



				DateTime currentDate = DateTime.Now.AddDays(-1).AddMinutes(30);
				DateOnly dateOnly;
				TimeOnly timeOnly;

				string[] datas = [string.Format("Data {0:dd/MM/yyyy}", currentDate), $"Data {DateTime.Now.ToString("dddd dd MMMM yy HH:mm:ss")}", $"Data {DateTime.Now.ToString()}"]; // dotnet 8
				for (int i = 0; i < datas.Length; i++)
				{
					Console.WriteLine(datas[i]);
				}
			}
			break;

		default:
			break;
	}
}

int GetLastIndex()
{
	return 3;
}
#endregion


Console.ReadLine();