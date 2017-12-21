using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo();

            grafo.addVertice("Capinopolis");
            grafo.addVertice("Itumbiara");
            grafo.addVertice("Centralina");
            grafo.addVertice("Ituiutaba");
            grafo.addVertice("Tupaciguara");
            grafo.addVertice("Monte Alegre");
            grafo.addVertice("Douradinhos");
            grafo.addVertice("Uberlândia");
            grafo.addVertice("Araguari");
            grafo.addVertice("Cascalho Rico");
            grafo.addVertice("Grupiara");
            grafo.addVertice("Estrela do Sul");
            grafo.addVertice("Romaria");
            grafo.addVertice("Indianópolis");
            grafo.addVertice("Santa Juliana");

            grafo.addAresta("Capinopolis", "Centralina", 40);
            grafo.addAresta("Capinopolis", "Ituiutaba", 30);
            grafo.addAresta("Itumbiara", "Tupaciguara", 55);
            grafo.addAresta("Itumbiara", "Centralina", 20);
            grafo.addAresta("Centralina", "Monte Alegre", 75);
            grafo.addAresta("Ituiutaba", "Monte Alegre", 85);
            grafo.addAresta("Ituiutaba", "Douradinhos", 90);
            grafo.addAresta("Tupaciguara", "Uberlândia", 60);
            grafo.addAresta("Tupaciguara", "Monte Alegre", 44);
            grafo.addAresta("Douradinhos", "Monte Alegre", 28);
            grafo.addAresta("Uberlândia", "Monte Alegre", 60);
            grafo.addAresta("Uberlândia", "Douradinhos", 63);
            grafo.addAresta("Uberlândia", "Araguari", 30);
            grafo.addAresta("Uberlândia", "Romaria", 78);
            grafo.addAresta("Uberlândia", "Indianópolis", 45);
            grafo.addAresta("Araguari", "Cascalho Rico", 28);
            grafo.addAresta("Araguari", "Estrela do Sul", 34);
            grafo.addAresta("Romaria", "Estrela do Sul", 27);
            grafo.addAresta("Romaria", "Santa Juliana", 28);
            grafo.addAresta("Indianópolis", "Santa Juliana", 40);
            grafo.addAresta("Cascalho Rico", "Grupiara", 32);
            grafo.addAresta("Estrela do Sul", "Grupiara", 38);
            //grafo.addAresta(, , );

            Console.WriteLine("Menor caminho a ser percorrido de: \n");
            Console.WriteLine("1) Ituiutaba para Romaria: ");
            Console.WriteLine(grafo.encontrarCaminho("Ituiutaba", "Romaria") + "\n");
            Console.WriteLine("2) Itumbiara para Santa Juliana: ");
            Console.WriteLine(grafo.encontrarCaminho("Itumbiara", "Santa Juliana"));

            Console.Read();
        }
    }
}
