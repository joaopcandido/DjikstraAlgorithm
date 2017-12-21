using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class NohLista<TAD> : Object
    {
        NohLista<TAD> prior;
        TAD data;
        NohLista<TAD> next;

        public NohLista()
        {

        }
        public NohLista(TAD n)
        {
            this.data = n;
        }

        public TAD getData()
        {
            return this.data;
        }
        public void setData(TAD n)
        {
            this.data = n;
        }

        public NohLista<TAD> getPrior()
        {
            return this.prior;
        }
        public void setPrior(NohLista<TAD> noh)
        {
            this.prior = noh;
        }

        public NohLista<TAD> getNext()
        {
            return this.next;
        }
        public void setNext(NohLista<TAD> noh)
        {
            this.next = noh;
        }
    }
}
