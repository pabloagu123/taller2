namespace Pasteles;

public interface InterfazPastel
{
    public void agregar_ingrediente(Ingrediente i);
    public int cantidad_ingredientes();
    public string listar_ingredientes();
    public double calcular_costo();
    
}