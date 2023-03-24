namespace Monoplaza;

public abstract class MonoplazaAbstract : InterfazMonoplaza
{
    string escuderia;
    bool encendido;
    bool movimiento;
    public MonoplazaAbstract(string escuderia){
        this.escuderia = escuderia;
        this.encendido = false;
        this.movimiento = false;
    }

    public void Encender()
    {
        if (!encendido)
        {
            Console.WriteLine("El monoplaza está encendido.");
            encendido = true;
        }
        else
        {
            Console.WriteLine("El monoplaza ya está encendido.");
        }
    }
    public void Apagar()
    {
        if (encendido && !movimiento)
        {
            Console.WriteLine("El monoplaza está apagado.");
            encendido = false;
        }
        else if (!encendido)
        {
            Console.WriteLine("El monoplaza ya está apagado.");
        }
        else
        {
            Console.WriteLine("El monoplaza está en movimiento, no se puede apagar.");
        }
    }

    public void Detener()
    {
        if (encendido && movimiento)
        {
            Console.WriteLine("El monoplaza se ha detenido.");
            movimiento = false;
        }
        else if (!encendido)
        {
            Console.WriteLine("El monoplaza está apagado, no se puede detener.");
        }
        else
        {
            Console.WriteLine("El monoplaza ya está detenido.");
        }
    }
    public void Mover()
    {
        if (encendido && !movimiento)
        {
            Console.WriteLine("El monoplaza está en movimiento.");
            movimiento = true;
        }
        else if (!encendido)
        {
            Console.WriteLine("El monoplaza está apagado, no se puede mover.");
        }
        else
        {
            Console.WriteLine("El monoplaza ya está en movimiento.");
        }
    }
    
}