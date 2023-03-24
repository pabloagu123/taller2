using Pasteles;

Pastel pastel1=new Pastel("pastel de vainilla",30);
pastel1.agregar_ingrediente(new Ingrediente("Azucar",3,3500));
pastel1.agregar_ingrediente(new Ingrediente("Harina",3,3000));
pastel1.agregar_ingrediente(new Ingrediente("Crema de vainilla",4,5000));
pastel1.agregar_ingrediente(new Ingrediente("Arequipe",2,2000));


Console.WriteLine("Cantidad de Ingredientes: "+pastel1.cantidad_ingredientes());
Console.WriteLine(pastel1.listar_ingredientes());
Console.WriteLine("Costo Total pastel: "+pastel1.calcular_costo());