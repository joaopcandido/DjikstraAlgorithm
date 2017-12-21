using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Aresta
    {
        Vertice destiny;
        int distance;

        public Aresta()
        {

        }

        public Aresta(Vertice v, int d)
        {
            destiny = v;
            distance = d;
        }

        public Vertice getDestiny()
        {
            return destiny;
        }
        public void setDestiny(Vertice v)
        {
            destiny = v;
        }

        public int getDistance()
        {
            return distance;
        }
        public void setDistance(int d)
        {
            distance = d;
        }
    }
}
