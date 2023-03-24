namespace Monoplaza;

public class Circuito
{
    string nombre_circuito;
    int numero_de_vueltas;

    MonoplazaAbstract monoplaza;
    public Circuito(string nombre_circuito, int numero_de_vueltas)
    {
        this.nombre_circuito = nombre_circuito;
        this.numero_de_vueltas = numero_de_vueltas;
        this.monoplaza = null;
    }
    public void agregar_monoplaza(MonoplazaAbstract monoplaza)
    {
        if (this.monoplaza == null)
        {
            this.monoplaza = monoplaza;
        }
    }


    public void sacar_monoplaza()
    {
        if (this.monoplaza != null)
        {
            this.monoplaza = null;
        }
    }

    public void realizar_prueba()
    {
        if (this.monoplaza == null)
        {
            Console.WriteLine("En el circuito no hay Ningun Monoplazo");

        }
        else
        {
            //realizar prueba
            Console.WriteLine("Realizar Prueba a: "+monoplaza.GetType());
            Random aleatorio = new Random();
            int mejor_tiempo = 999999;

            monoplaza.Encender();
            monoplaza.Mover();
            for (int i = 0; i < numero_de_vueltas; i++)
            {
                int tiempo = aleatorio.Next(100000, 999999);
                Console.WriteLine($"Vuelta {i + 1}: tiempo: {tiempo}");
                if (tiempo < mejor_tiempo)
                {
                    mejor_tiempo = tiempo;
                }
            }

            monoplaza.Detener();
            monoplaza.Apagar();
            Console.WriteLine($"Mejor Tiempo: {mejor_tiempo}\n");

            tiempos_podio[i] = mejor_tiempo;
            i++;

            if (tiempos_podio[2] != 0)//termino la carrera de los 3 carros
            {
                Console.WriteLine("Podion\n");
                for (int i = 0; i < tiempos_podio.Length; i++)
                {
                    Console.WriteLine( " Tiempo: " + tiempos_podio[i]);
                }

            }
        }

    }
    static int[] tiempos_podio = new int[3];
    static int i = 0;

}