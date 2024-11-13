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

        public void Eliminar(string emenu)
        {
            int index = Array.IndexOf(menu, emenu);
            if (index == -1)
            {
                Console.WriteLine("Nombre no encontrado");
                return;
            }
            string[] nuevomenu2 = new string[menu.Length - 1];
            for (int i = 0, j = 0; i < menu.Length; i++)
            {
                if (i != index)
                {
                    nuevomenu2[j] = menu[i];
                    j++;
                }
            }
            menu = nuevomenu2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Menu {emenu} Elimando Correctamente");
            Console.ResetColor();
        }
    }
    
    
}
