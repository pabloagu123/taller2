namespace Pasteles;

public class Pastel:InterfazPastel
{
    public string nombre;
    public int tamaño;
    List<Ingrediente> listaIngredientes=new List<Ingrediente>();
    public Pastel(string nombre, int tamaño){
        this.nombre=nombre;
        this.tamaño=tamaño;
    }

    public void agregar_ingrediente(Ingrediente i)
    {
        listaIngredientes.Add(i);
    }

    public double calcular_costo()
    {
        double total=0;
        foreach (var ingrediente in listaIngredientes)
        {
            total+=(ingrediente.precio*ingrediente.cantidad);
        }
        return total;
    }

    public int cantidad_ingredientes()
    {
        return listaIngredientes.Count;
    }

    public string listar_ingredientes()
    {
        string salida="Lista de Ingredientes del pastel\n";
        foreach (var ingrediente in listaIngredientes)
        {
            salida+=ingrediente.nombre+" Cantidad: "+ingrediente.cantidad+"\n";
        }
        return salida;
    }
}