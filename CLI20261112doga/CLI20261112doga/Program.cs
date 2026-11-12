using CLI20261112doga;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Videogame> videogames = [];

FileStream fs = new FileStream("videogames.csv", FileMode.Open);
StreamReader sr = new StreamReader(fs);
sr.ReadLine();

while (!sr.EndOfStream)
{
    videogames.Add(new Videogame(sr.ReadLine()));
}

// 1. feladat 
Console.WriteLine("-------------------------------------------------");
var f01 = videogames.Count(v => v.Ertekeles > 4.5);
Console.WriteLine($"Ennyi játék van több mint 4.5 értékelésen: {f01}");

Console.WriteLine("-------------------------------------------------");

var f02 = videogames.Max(v => v.AktivJatekosok);
Console.WriteLine($"Legtöbb aktív játékossal rendelkező játék: {f02}");

Console.WriteLine("-------------------------------------------------");

var f03 = videogames.Any(v => v.KiadasDatum.Year < 2020);
Console.WriteLine($"Van a listában kiadott játék 2020 előtt?: {(f03 ? "van" : "nincs")}");

Console.WriteLine("-------------------------------------------------");

var f04 = videogames.Average(v => v.Ertekeles);
Console.WriteLine($"Az összes játék értékelése átlagja: {f04}");

Console.WriteLine("-------------------------------------------------");

var f05 = videogames.Find(v => v.Cim == "Cyber City 2077");
Console.WriteLine(f05);

Console.WriteLine("-------------------------------------------------");

var f06 = videogames.Where(v => v.Mufaj == "RPG");
foreach (var rpg in f06)
{
    Console.WriteLine($"\t{rpg}");
}

Console.WriteLine("-------------------------------------------------");

var f07 = videogames.OrderByDescending(v => v.Ertekeles).Take(3);
foreach (var max in f06)
{
    Console.WriteLine($"\n{max}");
}

Console.WriteLine("-------------------------------------------------");

var f08 = videogames.Where(v => v.KiadasDatum.Year >= 2022);

foreach (var avg in f08)
{
    Console.WriteLine($"{avg.Ertekeles}");
}

Console.WriteLine("-------------------------------------------------");

var f09 = videogames.GroupBy(v => v.Mufaj);

foreach (var grp in f09)
{
    Console.WriteLine($"{grp.Key} {grp.Count()} db");
}

Console.WriteLine("-------------------------------------------------");

var f10 = videogames.GroupBy(v =>v.Mufaj);

foreach (var grp in f10)
{
    Console.WriteLine($"{grp.Key} {grp.MaxBy(v => v.Ertekeles)} db");
}