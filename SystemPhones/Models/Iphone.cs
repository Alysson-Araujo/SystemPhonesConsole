namespace SystemPhones.Models;
using System;

public class Iphone : Smartphone
{
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no Iphone {Modelo}...");
    }
}