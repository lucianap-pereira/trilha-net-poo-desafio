using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "789456", modelo: "Modelo 1", imei: "011", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone iPhone:");
            Smartphone iphone = new Iphone(numero: "6549", modelo: "Modelo 2", imei: "022", memoria: 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
        }
    }
}