using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celularComPoo.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero, "iPhone", "54321", 64)
        {
            // Defina os valores específicos para o modelo iPhone
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}
