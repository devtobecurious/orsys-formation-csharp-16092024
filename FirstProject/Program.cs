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