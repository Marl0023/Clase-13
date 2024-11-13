using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S13
{
    public class Desayuno
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Dias { get; set; }

        public override string? ToString()
        {
            return $"Desayuno {Nombre} s/{Precio}. Servidos los {Dias}.";
        }
        public string[] ListaDias() { 
            return Dias.Split(',');
        }
        private string[] menu = new string[] { "chaufa", "Pan con pollo", "Pan con lomo" }; 


    }
    
    
}
