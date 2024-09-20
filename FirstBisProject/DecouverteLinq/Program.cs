
using DecouverteLinq;

//List<Hobbit> list = new()
//{
//    new() { Age = 120, Prenom = "Bilbo", NbRepas = 2 },
//    new() { Age = 30, Prenom = "Frodo", NbRepas = 4 },
//    new() { Age = 50, Prenom = "Sam", NbRepas = 4 }
//};

List<Hobbit> list =
[
    new() { Age = 120, Prenom = "Bilbo", NbRepas = 2 },
    new() { Age = 30, Prenom = "Frodo", NbRepas = 4 },
    new() { Age = 50, Prenom = "Sam", NbRepas = 4 }
];

var query = from hob in list
            let ageEnString = hob.Age.ToString()
            let ageEtNbRepas = hob.Age + hob.NbRepas
            where hob.Age >= 50 && ageEtNbRepas > 0
            orderby hob.Prenom descending
            orderby hob.NbRepas descending
            select hob;

//var queryWithMethods = list.Where(hob => hob.Age >= 50 && hob.NbRepas > 1)
//                           .Where(hob => hob.NbRepas > 0)
//                           .OrderByDescending(hob => hob.Prenom)
//                           .ThenByDescending(hob => hob.NbRepas)
//                           .Select(item => item);

// Sommer
var totalAge = query.Sum(item => item.Age);

var queryToUseAge = from hob in list
                    select hob.Age;

totalAge = queryToUseAge.Sum();

// Améliorer mon select
var querySelectSuperPower = from hob in list
                            let nbRepasParJr = hob.NbRepas / 24
                            select new { Age = hob.Age, NbRepasParJour = nbRepasParJr };

foreach (var item in querySelectSuperPower)
{
    Console.WriteLine("{0}", item.NbRepasParJour);
}

// Exécution Différée
foreach (var item in query) // à chaque fois je ré-exécute le code de la query
{
    Console.WriteLine("{0}", item.Prenom);
}
Console.WriteLine("-------");

list.Add(new() { Prenom = "Golum", Age = 1500, NbRepas = 8 });

foreach (var item in query) // à chaque fois je ré-exécute le code de la query
{
    Console.WriteLine("{0}", item.Prenom);
}
Console.WriteLine("-------");

// Exécution immédiate
var result = query.ToList();

foreach (var item in result) // je lis les données de result et non depuis l'exécution de la query
{
    Console.WriteLine("{0}", item.Prenom);
}
Console.WriteLine("-------");

list.Add(new() { Prenom = "Merry", Age = 51, NbRepas = 18 });

foreach (var item in result) // je lis les données de result et non depuis l'exécution de la query
{
    Console.WriteLine("{0}", item.Prenom);
}
Console.WriteLine("--- A NE PAS FAIRE ----");

var resultBis = query.ToList()
                     .Where(item => item.NbRepas < 2);

var queryBcpMieux = query.Where(item => item.NbRepas < 2);
var resultFinalbcpMieux = queryBcpMieux.ToList();

