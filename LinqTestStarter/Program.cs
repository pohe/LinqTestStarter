// See https://aka.ms/new-console-template for more information
using LinqTestStarter;

Console.WriteLine("Hello, LINQ Test 24!");

List<string> names = new List<string>() { "Jakob", "Katrine", "Molle", "Gustav", "Jonas", "Marius", "Kim", "Magnus", "Stephane" };

//Opgave 1
// Find antallet af navne i listen names?
//Udskriv resultatet
Console.WriteLine("Opgave 1");




//Opgave 2
// Find den gennemsnitlige længde af navnene i names?
//Udskriv resultatet
Console.WriteLine("Opgave 2");



// Opgave 3
//Udskriv navnene i names sorteret
Console.WriteLine("Opgave 3");



//Opgave 4
//Find summen af alle tal over 10
//Udskriv resultatet
Console.WriteLine("Opgave 4");




#region Create List of movies
List<Movie> movies = new List<Movie>()
            {
                new Movie{Title ="Se7en", Year = 1995, DurationInMins = 127, StudioName="New Line Cinema"},
                new Movie{Title = "Alien", Year = 1979, DurationInMins = 117, StudioName="20th Century Fox"},
                new Movie{Title = "Forrest Gump", Year = 1994, DurationInMins = 142, StudioName="Paramount Pictures"},
                new Movie{Title = "True Grit", Year = 2010, DurationInMins = 110, StudioName="Paramount Pictures"},
                new Movie{Title = "Dark City", Year = 1998, DurationInMins = 111, StudioName="New Line Cinema"},

            };
#endregion
#region Create actors
movies[0].Actors = new List<Actor>() { new Actor() { Name = "Dustin Hoffmann" }, new Actor() { Name = "Denzel Washington" } };
movies[1].Actors = new List<Actor>() { new Actor() { Name = "Meryl Streep" }, new Actor() { Name = "Jack Nicholson" } };
movies[2].Actors = new List<Actor>() { new Actor() { Name = "Ralph Fiennes" }, new Actor() { Name = "Sigourney Weaver" } };
movies[3].Actors = new List<Actor>() { new Actor() { Name = "Robert De Niro" }, new Actor() { Name = "Al Pacino" } };
movies[4].Actors = new List<Actor>() { new Actor() { Name = "Dustin Hoffmann" }, new Actor() { Name = " Jack Nicholson" } };
#endregion

#region create list of studios
List<Studio> studios = new List<Studio>()
            {
                new Studio{StudioName = "New Line Cinema", HQCity = "Boston", NoOfEmployees = 4000},
                new Studio{StudioName = "20th Century Fox", HQCity = "New York", NoOfEmployees = 2500},
                new Studio{StudioName = "Paramount Pictures", HQCity = "New York", NoOfEmployees = 8000}

            };
#endregion

//Opgave 5
//Find film der varer mere end 2 timer
//Udskriv resultatet
Console.WriteLine("Opgave 5");

//Opgave 6
//Find alle studioes (studionames) fra New York med mere end 3000 ansatte
//Udskriv resultatet
Console.WriteLine("Opgave 6");


//Opgave 7
//Find alle movies, som har mere end to skuespillere
//Udskriv resultatet
Console.WriteLine("Opgave 7");


//Opgave 8
//Find alle movies som Dustin Hoffman spiller med i?
//Udskriv resultatet
Console.WriteLine("Opgave 8");




//Ekstra opgaver til de hurtigste

//Opgave 9
//Find de 2 laveste ulige tal i listen numbers og udskriv dem i stigende orden
Console.WriteLine("Opgave 9");



//Opgave 10
//Find de 2 laveste ulige tal i listen numbers og som der ikke forekommer dubletter af og udskriv dem i falden orden
Console.WriteLine("Opgave 10");



