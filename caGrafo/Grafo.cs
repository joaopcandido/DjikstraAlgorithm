using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Grafo
    {
        Lista<Vertice> vertices;
        static int infinito = 99999;

        public Grafo()
        {
            vertices = new Lista<Vertice>();
        }

        public bool isEmpty()
        {
            if (vertices.isEmpty())
                return true;
            else
                return false;
        }

        public Vertice encontrarVertice(String nome)
        {
            Vertice aux = new Vertice();
            NohLista<Vertice> percorrer = vertices.getInicio();

            bool encontrou = false;

            if (isEmpty())
                return null;
            else
            {
                do
                {
                    if (percorrer.getData().getName().Equals(nome))
                    {
                        encontrou = true;
                        aux = percorrer.getData();
                        break;
                    }
                    percorrer = percorrer.getNext();
                } while (percorrer != null);

                if (encontrou)
                    return aux;
                else
                    return null;
            }
            
        }

        public void addVertice(String data)
        {
            Vertice find = encontrarVertice(data);

            if (find == null)
            {
                Vertice newVertice = new Vertice(data);
                vertices.insereNoFim(newVertice);
            }

            else
                Console.WriteLine("Vértice já existente!! Impossível adicionar!!");
        }

        public void addAresta(String s1, String s2, int dist)
        {
            if (isEmpty())
            {
                Console.WriteLine("Grafo vazio!! Impossível construir caminho!");
            }
            else
            {
                Vertice aux1 = encontrarVertice(s1);
                Vertice aux2 = encontrarVertice(s2);

                //Criar aresta se encontrar:
                if (aux1 != null && aux2 != null)
                {
                    Aresta a1 = new Aresta(aux2, dist);
                    aux1.getArestas().insereNoFim(a1);

                    Aresta a2 = new Aresta(aux1, dist);
                    aux2.getArestas().insereNoFim(a2);
                }


                else
                    Console.WriteLine("Vértices não encontrados!! Impossível adicionar caminho!!");
            }
        }

        public String encontrarCaminho(String orig, String dest)
        {
            Vertice origV = encontrarVertice(orig);
            Vertice destV = encontrarVertice(dest);
            Lista<Vertice> fila = new Lista<Vertice>();
            fila.insereNoFim(origV);

            NohLista<Vertice> percorrer = vertices.getInicio();
            do
            {
                if (percorrer.getData().Equals(origV))
                {
                    percorrer.getData().setDistParcial(0);
                    percorrer.getData().setState(false);
                }
                else
                {
                    percorrer.getData().setDistParcial(infinito);
                    percorrer.getData().setState(false);
                }
                percorrer = percorrer.getNext();
            } while (percorrer != null);

            encontrarCaminho(origV, destV, fila);


            origV = encontrarVertice(orig);
            destV = encontrarVertice(dest);
            Vertice percVertices = destV;
            String caminhoFinal = percVertices.getName() + "(" + percVertices.getDistParcial().ToString() + "km)" + "\n";
            do
            {
                percVertices = percVertices.getAntecessor();
                caminhoFinal = percVertices.getName() + "(" + percVertices.getDistParcial().ToString() + "km)" + "  ->  " + caminhoFinal;
            } while (percVertices != origV);

            return caminhoFinal;
        }

        private void encontrarCaminho(Vertice percorrer, Vertice dest, Lista<Vertice> filaVisitar)
        {
            NohLista<Aresta> arestaAux = percorrer.getArestas().getInicio();
            Vertice verticeDaAresta;

            //Laço para verificar se a distância parcial até aquele nó é menor que a já existente:
            do
            {
                int d = percorrer.getDistParcial() + arestaAux.getData().getDistance();
                verticeDaAresta = arestaAux.getData().getDestiny();

                if (d < arestaAux.getData().getDestiny().getDistParcial())
                {
                    verticeDaAresta.setDistParcial(d);
                    verticeDaAresta.setAntecessor(percorrer);
                    verticeDaAresta.setState(false);
                    filaVisitar.insereNoFim(verticeDaAresta);
                }

                arestaAux = arestaAux.getNext();

            } while (arestaAux != null);

            percorrer.setState(true);

            do
            {
                if (!filaVisitar.getInicio().getData().getState())
                {
                    encontrarCaminho(filaVisitar.getInicio().getData(), dest, filaVisitar);
                }
                else
                {
                    filaVisitar.remove(filaVisitar.getInicio().getData());
                }
            } while (filaVisitar.getInicio() != null);

        }
    }
}
