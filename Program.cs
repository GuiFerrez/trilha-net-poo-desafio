using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Models.Nokia meuNokia = new Models.Nokia("987654321", "Nokia X", "987654321098765", 128);
            meuNokia.Ligar();
            meuNokia.ReceberLigacao();
            meuNokia.InstalarAplicativo("WhatsApp");

            Models.Iphone meuIphone = new Models.Iphone("123456789", "iPhone 13", "123456789012345", 256);
            meuIphone.Ligar();
            meuIphone.ReceberLigacao();
            meuIphone.InstalarAplicativo("Instagram");

   
            MostrarDadosSmartphone(meuNokia);
            MostrarDadosSmartphone(meuIphone);

            Console.ReadKey();
        }

     
        static void MostrarDadosSmartphone(Models.Smartphone smartphone)
        {
            Console.WriteLine($"Número: {smartphone.Numero}");
            Console.WriteLine($"Modelo: {smartphone.Modelo}");
            Console.WriteLine($"IMEI: {smartphone.IMEI}");
            Console.WriteLine($"Memória: {smartphone.Memoria}GB");
            Console.WriteLine();
        }
    }
}   