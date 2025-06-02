namespace SystemPhones.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    private string _modelo;
    private string _IMEI;
    private int _memoria;
    

    public void Ligar()
    {
        Console.WriteLine($"Ligando o smartphone {_modelo} com o número {Numero}...");
    }
    
    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }
    
    public abstract void InstalarAplicativo(string nome);
    
    public string Modelo
    {
        get => _modelo;
        set => _modelo = value;
    }
    public string IMEI
    {
        get => _IMEI;
        set => _IMEI = value;
    }
    
    public int Memoria
    {
        get => _memoria;
        set => _memoria = value;
    }
}