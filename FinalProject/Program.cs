System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Console.WriteLine("A Sam journey");

#region Exécution
DisplayMenu();
int choice = GetChoiceFromUser();
ExecuteActionByChoice(choice);
#endregion


#region Code interne
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