
using AlvinMartinezSem8ConexBD.Models;
using AlmacenContext basedatos = new AlmacenContext();

Producto producto = new Producto();

Console.WriteLine("----------------------------------");
Console.WriteLine("Ingrese el nombre de el producto: ");
Console.WriteLine("----------------------------------");
producto.Nombre = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("-------------------------------------");
Console.WriteLine("Ingrese la descripcion del Producto: ");
Console.WriteLine("-------------------------------------");
producto.Descripcion = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("----------------------------------");
Console.WriteLine("Ingrese el Precio del producto : ");
Console.WriteLine("----------------------------------");
producto.Precio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ingrese la cantidad de producto disponible: ");
Console.WriteLine("--------------------------------------------");
producto.Stock = Convert.ToInt32(Console.ReadLine());


basedatos.Productos.Add(producto);
basedatos.SaveChanges();

var Listado = basedatos.Productos;

Console.WriteLine("...........................................");
Console.WriteLine("Los Productos registrados actaulmente son: ");
foreach (var productos in Listado)
{
    
    Console.WriteLine($" - {productos.Nombre}");
   
}

Console.WriteLine("...........................................");