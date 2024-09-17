using FirstBisProject;
using System.Text;

//string title = "a sam journey";
//var subTitle = "A orsys game";

//char oneChar = 'A';
//var oneChar2 = "A";

//// Console.WriteLine(title.ToUpper().ToLower());
//Console.WriteLine(title.Substring(0, 1).ToUpper() + title.Substring(1));
//Console.WriteLine(subTitle[0]);

//DisplayMenu();

#region Learnings
#region POO

Animal cheval = new Animal("");
var chevalBis = new Animal(100);
Animal chevalTres = new("");

Animal jolly = cheval;

{
    var test = 1;
}
// Console.WriteLine(test);

void UseHorse(Animal animal) // ici c'est bien une variable nouvelle ! mais on a copié la référence passée
{

    // animal.Surname = "Hello 1";
    // animal = new Animal();
    animal.Eat("herbe");
}
UseHorse(cheval);
UseHorse(jolly);
#endregion

#region Out ref
bool Compute(int a, int b, out int resultA)
{
    resultA = a + b;

    return true;
}

int result = 0;
var success = Compute(1, 2, out result);


#endregion

#region Enums
TypeAnimal typeAnimal = TypeAnimal.Horse;
int valueOfHorse = (int)typeAnimal;

string displayType = typeAnimal.ToString();
Console.WriteLine(displayType);

typeAnimal = (TypeAnimal)Enum.Parse(typeof(TypeAnimal), displayType);
typeAnimal = Enum.Parse<TypeAnimal>(displayType);

foreach (var item in Enum.GetNames<TypeAnimal>())
{
    Console.WriteLine("{0}", item.ToUpper());
}

foreach (var item in Enum.GetValues<TypeAnimal>())
{
    Console.WriteLine("{0}", (int)item);
}
#endregion

void ConcatListOfStrings()
{
    string content = string.Empty;
    StringBuilder builder = new StringBuilder();

    for (int i = 0; i < 1100; i++)
    {
        //content += "i : " + i.ToString();
        // content += string.Format("i : {0}", i);
        // content += $"i : {i}";
        builder.Append($"i : {i}");
    }

    content = builder.ToString();
}

void CastValue()
{
    #region number
    int iOne = 1;
    decimal dTwo = 2.0M;
    float fThree = 3.0F;
    double ddFour = 4.0D;
    long lFive = 5L;

    dTwo = iOne; // conversion implicite, car type inférieur
    iOne = (int)dTwo; // brut cast / force cast : attention on perd des données binaires ! 

    // int.MinValue
    #endregion

    #region Cast string / number
    int resultInt = int.Parse("1");
    resultInt = Convert.ToInt32("1");
    bool boolResult = bool.Parse("true");
    #endregion
}
#endregion

#region Coeur du jeu vidéo
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

int GetLastIndex()
{
    return 3;
}
#endregion

Console.ReadLine();