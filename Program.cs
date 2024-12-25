// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int time = DateTime.Now.Hour;

if(time >= 6 && time <11)
{
    Console.WriteLine("Günaydın");
}
else if(time <= 18)
{
    Console.WriteLine("İyi günler");
}

else
{
    Console.WriteLine("iyi geceler");
}

string sonuc = time <= 18 ? "İyi günler" : "iyi geceler";
Console.WriteLine(sonuc);

sonuc = time>=6 && time < 11 ? "Günaydın" : time <= 18 ? "iyi günler" : "iyi geceler";

Console.WriteLine(sonuc);

