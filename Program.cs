using System.Diagnostics;

Stopwatch tiempo = Stopwatch.StartNew();

Console.WriteLine("==================================");
Console.WriteLine("   PRACTICA 4 - GRAFOS EN C#");
Console.WriteLine("==================================");

Console.WriteLine("\nEJEMPLO 1");

// Crear un nuevo grafo
Grafo grafo1 = new Grafo();

// Agregar los vertices
grafo1.AgregarVertice("A");
grafo1.AgregarVertice("B");
grafo1.AgregarVertice("C");
grafo1.AgregarVertice("D");
grafo1.AgregarVertice("E");

// Agregar las aristas
grafo1.AgregarArista("A", "B");
grafo1.AgregarArista("A", "C");
grafo1.AgregarArista("B", "D");
grafo1.AgregarArista("C", "D");
grafo1.AgregarArista("D", "E");

// Mostrar el grafo
grafo1.MostrarGrafo();

// Recorrido en anchura
grafo1.BFS("A");

// Recorrido en profundidad
grafo1.DFS("A");

Console.WriteLine("\n==============================");
Console.WriteLine("EJEMPLO 2 - LUGARES DE UNA CIUDAD");
Console.WriteLine("==============================");

// Crear el segundo grafo
Grafo grafo2 = new Grafo();

// Agregar los vertices
grafo2.AgregarVertice("Parque");
grafo2.AgregarVertice("Escuela");
grafo2.AgregarVertice("Hospital");
grafo2.AgregarVertice("Mercado");
grafo2.AgregarVertice("Terminal");

// Agregar las conexiones
grafo2.AgregarArista("Parque", "Escuela");
grafo2.AgregarArista("Parque", "Hospital");
grafo2.AgregarArista("Escuela", "Mercado");
grafo2.AgregarArista("Hospital", "Mercado");
grafo2.AgregarArista("Mercado", "Terminal");

// Mostrar el grafo
grafo2.MostrarGrafo();

// Recorrido en anchura
grafo2.BFS("Parque");

// Recorrido en profundidad
grafo2.DFS("Parque");

Console.WriteLine("\n==============================");
Console.WriteLine("EJEMPLO 3 - GRAFO DESDE ARCHIVO datos1.txt");
Console.WriteLine("==============================");

Grafo grafo3 = new Grafo();

string[] lineas = File.ReadAllLines("datos1.txt");

foreach (string linea in lineas)
{
    string[] datos = linea.Split(',');

    string origen = datos[0];
    string destino = datos[1];

    grafo3.AgregarVertice(origen);
    grafo3.AgregarVertice(destino);

    grafo3.AgregarArista(origen, destino);
}

grafo3.MostrarGrafo();

grafo3.BFS("Parque");

grafo3.DFS("Parque");

Console.WriteLine("\n==========================================");
Console.WriteLine("EJEMPLO 4 - GRAFO DESDE ARCHIVO datos2.txt");
Console.WriteLine("==========================================");

// Crear el cuarto grafo
Grafo grafo4 = new Grafo();

// Leer las conexiones desde datos2.txt
string[] lineas2 = File.ReadAllLines("datos2.txt");

foreach (string linea in lineas2)
{
    string[] datos = linea.Split(',');

    string origen = datos[0];
    string destino = datos[1];

    grafo4.AgregarVertice(origen);
    grafo4.AgregarVertice(destino);

    grafo4.AgregarArista(origen, destino);
}

// Mostrar el grafo
grafo4.MostrarGrafo();

// Recorrido en anchura
grafo4.BFS("Casa");

// Recorrido en profundidad
grafo4.DFS("Casa");

// Detener el cronometro
tiempo.Stop();

Console.WriteLine("\n==================================");
Console.WriteLine("TIEMPO DE EJECUCION");
Console.WriteLine("==================================");
Console.WriteLine($"Tiempo total: {tiempo.Elapsed.TotalMilliseconds:F4} ms");
