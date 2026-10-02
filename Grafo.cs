class Grafo
{
    private Dictionary<string, List<string>> adyacencia;

    public Grafo()
    {
        adyacencia = new Dictionary<string, List<string>>();
    }

    public void AgregarVertice(string vertice)
    {
        if (!adyacencia.ContainsKey(vertice))
        {
            adyacencia[vertice] = new List<string>();
        }
    }

    public void AgregarArista(string origen, string destino)
    {
        if (adyacencia.ContainsKey(origen) && adyacencia.ContainsKey(destino))
        {
            adyacencia[origen].Add(destino);
            adyacencia[destino].Add(origen);
        }
    }

public void MostrarGrafo()
{
    Console.WriteLine("\nLISTA DE ADYACENCIA:");

    foreach (var vertice in adyacencia)
    {
        Console.Write(vertice.Key + " -> ");

        foreach (var vecino in vertice.Value)
        {
            Console.Write(vecino + " ");
        }

        Console.WriteLine();
    }
}
public void BFS(string inicio)
{
    HashSet<string> visitados = new HashSet<string>();
    Queue<string> cola = new Queue<string>();

    visitados.Add(inicio);
    cola.Enqueue(inicio);

    Console.WriteLine("\nRECORRIDO BFS:");

    while (cola.Count > 0)
    {
        string actual = cola.Dequeue();
        Console.Write(actual + " ");

        foreach (string vecino in adyacencia[actual])
        {
            if (!visitados.Contains(vecino))
            {
                visitados.Add(vecino);
                cola.Enqueue(vecino);
            }
        }
    }

    Console.WriteLine();
}
public void DFS(string inicio)
{
    HashSet<string> visitados = new HashSet<string>();

    Console.WriteLine("\nRECORRIDO DFS:");

    DFSRecursivo(inicio, visitados);

    Console.WriteLine();
}

private void DFSRecursivo(string actual, HashSet<string> visitados)
{
    visitados.Add(actual);
    Console.Write(actual + " ");

    foreach (string vecino in adyacencia[actual])
    {
        if (!visitados.Contains(vecino))
        {
            DFSRecursivo(vecino, visitados);
        }
    }
}}