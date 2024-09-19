//using FirstProject;

////Animal a = new();


#region Poo
//Animal a = new Eagle()
//{
//    // TypeAnimal = TypeAnimal.Eagle
//};


//// ((Eagle)a).SitUp();
//(a as Eagle)?.SitUp();

//List<Animal> animals = new List<Animal>()
//{
//    a,
//    new Rabbit()
//};

//void GoToSleep(IEnumerable<Animal> animals)
//{
//    foreach (Animal animal in animals)
//    {
//        animal.Sleep(2);
//    }
//}

//void BigUpToEagles(IEnumerable<Eagle> eagles)
//{
//    foreach (var eagle in eagles)
//    {
//        eagle.SitUp();
//        eagle.Sleep(1);
//    }
//}

//// animals.Add(eagle);



//// eagle.TypeAnimal = TypeAnimal.Rabbit;

//IAbilityToFly batman = new Bat();

//List<IAbilityToFly> list = new List<IAbilityToFly>()
//{
//    new Eagle(),
//    new Leia(),
//    //new Bat()
//};
//List<IAbilityToFly> list2 =
//[
//    new Eagle(),
//    new Leia(),
//    new Bat()
//];

////Dictionary<int, string> dico = new Dictionary<int, string>()
////{
////    { 1, "coucou" },
////    { 1, "coucou" }
////};
//Dictionary<int, IAbilityToFly> dico = new Dictionary<int, IAbilityToFly>()
//{
//    { 1, new Eagle() },
//    { 2, new Leia() }
//};

//GoToFlyMyFriends(list);

//void GoToFlyMyFriends(IEnumerable<IAbilityToFly> flyers)
//{
//    foreach (var flyer in flyers)
//    {
//        flyer.Fly();
//    }
//}
#endregion

#region Delegates
using FirstProject;

void DisplayData(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}

DisplayData("Ah que johny");


Afficher afficher = Console.WriteLine;
afficher("Ah que jony avec 2 N");


void ComputeAndDisplay(Afficher afficher, params int[] args)
{
    int result = args.Sum();
    afficher(result.ToString());
}

ComputeAndDisplay(afficher, 1, 2, 3);
ComputeAndDisplay(Console.WriteLine, 1, 2, 3);
ComputeAndDisplay(DisplayData, 1, 2, 3);

Afficher afficherAvecLambda = mess =>
{
    Console.WriteLine("Oh yeah {0}", mess);
};
Afficher afficherAvecLambdaShort = mess => Console.WriteLine("Oh yeah {0}", mess);
afficherAvecLambdaShort("Optic 2000");

ComputeAndDisplay(mess => Console.WriteLine(mess.ToUpper()), 1, 2, 3, 4);
#endregion


#region Evenements
Publisher pub = new();

pub.YaUneNews += Console.WriteLine;
pub.YaUneNews += Console.WriteLine;
pub.YaUneNews += afficherAvecLambda;
//pub.YaUneNews -= afficherAvecLambda;

pub.Notify();
#endregion