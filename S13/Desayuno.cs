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

        byte[] nom = new byte[4];
        int posicion = 0;
        public override string? ToString()
        {
            return $"Desayuno {Nombre} s/{Precio}. Servidos los {Dias}.";
        }
        public string[] ListaDias() { 
            return Dias.Split(',');
        }
        public void eliminar(byte opcion)
        {
            int indice = Array.IndexOf(nom, opcion);

            if (indice != -1)
            {
                for (int i = indice; i < nom.Length - 1; i++)
                {
                    nom[i] = nom[i + 1];
                }
                Array.Resize(ref nom, nom.Length - 1);
                posicion--;
                Console.WriteLine("\nLa opcion fue eliminada correcatamente");
            }
            else
            {
                Console.WriteLine("\nNo se puede eliminar porque no existe");
            }
        }
    }
    
    
}
