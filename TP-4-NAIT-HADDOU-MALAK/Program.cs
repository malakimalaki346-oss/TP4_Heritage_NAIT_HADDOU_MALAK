using System;
using System.Numerics;
using TP4_Heritage;

Compte c1 = new Compte("Malak");
CompteEpargne c2 = new CompteEpargne("Sara", 1000, 3);
ComptePayant c3 = new ComptePayant("Aicha", 500);


c1.Deposer(1000);
c2.Deposer(500);
c3.Deposer(200);


c1.Retirer(300);
c2.Retirer(200);
c3.Retirer(100);


c2.CalculInteret();


Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);


Console.WriteLine($"c1 égal à c2 ? {c1.Equals(c2)}");

Console.ReadKey();