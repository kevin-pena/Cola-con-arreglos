using System;

class ColaConArreglos
{
    private int[] arreglo;
    private int frente;
    private int final;
    private int capacidad;

    public ColaConArreglos(int capacidad)
    {
        this.capacidad = capacidad;
        this.arreglo = new int[capacidad];
        this.frente = 0;
        this.final = -1; // Cola vacía
    }

    public void Enqueue(int elemento)
    {
        if (final < capacidad - 1)
        {
            arreglo[++final] = elemento;
            Console.WriteLine($"Elemento {elemento} agregado a la cola.");
        }
        else
        {
            Console.WriteLine("Error: Cola llena, no se puede agregar más elementos.");
        }
    }

    public int Dequeue()
    {
        if (frente <= final)
        {
            int elementoEliminado = arreglo[frente++];
            Console.WriteLine($"Elemento {elementoEliminado} eliminado de la cola.");
            return elementoEliminado;
        }
        else
        {
            Console.WriteLine("Error: Cola vacía, no se puede eliminar más elementos.");
            return -1; // Valor sentinela para indicar error
        }
    }

    public void MostrarCola()
    {
        Console.WriteLine("Elementos en la cola:");
        for (int i = frente; i <= final; i++)
        {
            Console.WriteLine(arreglo[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        ColaConArreglos cola = new ColaConArreglos(5);

        cola.Enqueue(1);
        cola.Enqueue(2);
        cola.Enqueue(3);

        cola.MostrarCola();

        cola.Dequeue();
        cola.MostrarCola();
    }
}
