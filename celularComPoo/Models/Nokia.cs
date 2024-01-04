using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celularComPoo.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero, "Nokia", "12345", 16)
        {
            // Defina os valores específicos para o modelo Nokia
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }
}
