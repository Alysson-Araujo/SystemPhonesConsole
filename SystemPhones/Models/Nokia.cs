namespace SystemPhones.Models;

public class Nokia : Smartphone
{   
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no Nokia {Modelo}...");
    }
}