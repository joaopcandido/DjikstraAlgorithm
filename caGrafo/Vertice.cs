using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Vertice
    {
        String name;
        bool state; //True: vertice fechado; False: vertice aberto
        Lista<Aresta> arestas;
        Vertice antecessor;
        int distParcial;

        public Vertice()
        {
            arestas = new Lista<Aresta>();
        }

        public Vertice(String name)
        {
            this.name = name;
            this.state = false;
            arestas = new Lista<Aresta>();
        }

        public String getName()
        {
            return this.name;
        }
        public void setName(String noh)
        {
            this.name = noh;
        }

        public bool getState()
        {
            return this.state;
        }
        public void setState(bool bin)
        {
            this.state = bin;
        }

        public Lista<Aresta> getArestas()
        {
            return this.arestas;
        }
        public void setArestas(Lista<Aresta> list)
        {
            this.arestas = list;
        }

        public Vertice getAntecessor()
        {
            return this.antecessor;
        }
        public void setAntecessor(Vertice noh)
        {
            this.antecessor = noh;
        }

        public int getDistParcial()
        {
            return this.distParcial;
        }
        public void setDistParcial(int d)
        {
            this.distParcial = d;
        }
    }
}
