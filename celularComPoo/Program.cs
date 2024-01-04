// See https://aka.ms/new-console-template for more information
using celularComPoo.Models;

class Program
{
    static void Main()
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        // Exemplo de utilização:
        Nokia nokia = new Nokia("123456789");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Iphone iphone = new Iphone("987654321");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
