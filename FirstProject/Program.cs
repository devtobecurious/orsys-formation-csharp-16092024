using FirstProject;

//Animal a = new();



Animal a = new Eagle()
{
    // TypeAnimal = TypeAnimal.Eagle
};


// ((Eagle)a).SitUp();
(a as Eagle)?.SitUp();

List<Animal> animals = new List<Animal>()
{
    a,
    new Rabbit()
};

void GoToSleep(IEnumerable<Animal> animals)
{
    foreach (Animal animal in animals)
    {
        animal.Sleep(2);
    }
}

void BigUpToEagles(IEnumerable<Eagle> eagles)
{
    foreach (var eagle in eagles)
    {
        eagle.SitUp();
        eagle.Sleep(1);
    }
}

// animals.Add(eagle);



// eagle.TypeAnimal = TypeAnimal.Rabbit;

IAbilityToFly batman = new Bat();

List<IAbilityToFly> list = new List<IAbilityToFly>()
{
    new Eagle(),
    new Leia(),
    //new Bat()
};
List<IAbilityToFly> list2 =
[
    new Eagle(),
    new Leia(),
    new Bat()
];

//Dictionary<int, string> dico = new Dictionary<int, string>()
//{
//    { 1, "coucou" },
//    { 1, "coucou" }
//};
Dictionary<int, IAbilityToFly> dico = new Dictionary<int, IAbilityToFly>()
{
    { 1, new Eagle() },
    { 2, new Leia() }
};

GoToFlyMyFriends(list);

void GoToFlyMyFriends(IEnumerable<IAbilityToFly> flyers)
{
    foreach (var flyer in flyers)
    {
        flyer.Fly();
    }
}