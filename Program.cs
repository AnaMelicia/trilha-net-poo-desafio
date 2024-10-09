using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        Smartphone iphone = new Iphone("123456789", "iPhone 14");
        iphone.Ligar();
        iphone.InstalarAplicativo("WhatsApp");
        
        Console.WriteLine(); // Linha em branco para melhor visualização
        
        Smartphone nokia = new Nokia("987654321", "Nokia 3310");
        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");
    }
}