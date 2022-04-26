// See https://aka.ms/new-console-template for more information


using DV_MD_03;

Console.WriteLine("Telefons");

Telefons telefons = new Telefons(); 

Console.WriteLine("Ievadi telefona Marku");
telefons.Brand = Console.ReadLine();
telefons.Size = 7;
Console.WriteLine("Ievadi telefona modeli");
telefons.Model = Console.ReadLine();

Console.WriteLine("Masina");

Masina masina = new Masina();

Console.WriteLine("Ievadi mašīnas Marku");
masina.Brand = Console.ReadLine();
Console.WriteLine("Ar kādu ātrumu brauc mašīna?");
string Speed = Console.ReadLine();
Console.WriteLine("Ievadi mašīnas numurzīmi");
masina.NumberPlate = Console.ReadLine();


//Console.WriteLine("Prece");

//Prece prece = new Prece();
//Console.WriteLine("Ievadi preces garumu");
//prece.length = Console.ReadLine();
//Console.WriteLine("Ievadi preces platumu");
//string width = Console.ReadLine();
//Console.WriteLine("Ievadi preces svaru");
//prece.weight = Console.ReadLine();


Console.WriteLine("Persona");

Persona persona = new Persona();

Console.WriteLine("Ievadi savu vārdu");
persona.Name = Console.ReadLine();

Console.WriteLine("Ievadi savu uzvārdu");
persona.LastName = Console.ReadLine();

int BirthYear;
Console.WriteLine("Dzimšanas gads");
string Age = Console.ReadLine();


//persona.Age();


persona.SayHi();







----------------------

    Human human = new Human ()
    human.Name = "Artis"