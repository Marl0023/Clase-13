using S13; 
/*
Desayuno d1 = new Desayuno();
d1.Nombre = "Chaufa especial";
d1.Precio = 10.5;
d1.Dias = "Lun,Mar,Mie";
Console.WriteLine(d1);
string[] lsita = d1.ListaDias();
foreach (string str in lsita) { 
    Console.WriteLine(str);
}

Desayuno d2 = new Desayuno();
d2.Nombre = "Sopa de casa";
Desayuno d3 = new Desayuno();
d3.Nombre = "Queque de choclo";
*/

Desayuno d1 = new Desayuno();
bool u = true;

do
{
    Console.WriteLine("Opciones del menu: Mostrar - Agregar - Eliminar - Salir");
    Console.Write("Ingrese una opcion: ");
    string opc = Console.ReadLine().ToLower().Trim();
    switch (opc)
    {
        case "eliminar":
            Console.Write("Ingrese el menu que desea eliminar: ");
            string eliminar = Console.ReadLine();
            d1.Eliminar(eliminar);
            break;
        case "agregar":
            Console.Write("Ingrese lo que desee eliminar: ");
            string agregar = Console.ReadLine().ToLower().Trim();
            d1.Agregar(agregar);
            break;
        case "mostrar":
            break;
        case "salir":
            u = false;
            break;
        default:
            Console.WriteLine("¡Error, vuelva a intentarlo!");
            break;
    } 

}while (u == true);
Console.WriteLine("Cerrando programa");
