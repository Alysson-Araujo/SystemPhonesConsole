using SystemPhones.Models;

namespace SystemPhones;

public class Program
{
    public static void Main(string[] args)
    {
        var iphone = new Iphone
        {
            Numero = "19294038912",
            Modelo = "IPhone 12",
            IMEI = "128931892312345",
            Memoria = 128
        };
        
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");
        
        Console.WriteLine();
        
        var nokia = new Nokia
        {
            Numero = "92748201742",
            Modelo = "Nokia N95",
            IMEI = "134125123465123",
            Memoria = 16
        };
        
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");
    }
}