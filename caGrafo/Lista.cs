using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Lista<TAD> : Object
    {
        public NohLista<TAD> getInicio()
        {
            return this.inicio;
        }
        public void setInicio(NohLista<TAD> noh)
        {
            this.inicio = noh;
        }

        public NohLista<TAD> getFim()
        {
            return this.fim;
        }
        public void setFim(NohLista<TAD> noh)
        {
            this.fim = noh;
        }

        NohLista<TAD> inicio;
        NohLista<TAD> fim;

        public Lista()
        {

        }

        public bool isEmpty()
        {
            if (inicio == null && fim == null)
                return true;
            else
                return false;
        }

        public void insereNoFim(TAD n)
        {
            NohLista<TAD> aux = new NohLista<TAD>(n);
            if (isEmpty())
            {
                inicio = aux;
                fim = aux;
            }
            else
            {
                aux.setPrior(fim);
                fim.setNext(aux);
                fim = aux;
            }
        }

        public void remove(TAD n)
        {
            if (isEmpty())
            {
                Console.WriteLine("Lista vazia!! Impossível Remover!!");
            }
            else
            {
                NohLista<TAD> aux = inicio;
                bool encontrou = false;
                do
                {
                    if (aux.getData().Equals(n))
                    {
                        encontrou = true;
                        break;
                    }
                    else
                        aux = aux.getNext();
                } while (aux != null);
                if (encontrou)
                {
                    if (aux.getPrior() == null && aux.getNext() == null)
                    {
                        inicio = null;
                        fim = null;
                        //Console.WriteLine("Item removido: " + aux.getData());
                    }
                    else if (aux.getPrior() == null)
                    {
                        aux.getNext().setPrior(aux.getPrior());
                        inicio = aux.getNext();
                        //Console.WriteLine("Item removido: " + aux.getData());
                    }
                    else if (aux.getNext() == null)
                    {
                        aux.getPrior().setNext(aux.getNext());
                        fim = aux.getPrior();
                        //Console.WriteLine("Item removido: " + aux.getData());
                    }
                    else
                    {
                        aux.getPrior().setNext(aux.getNext());
                        aux.getNext().setPrior(aux.getPrior());
                        //Console.WriteLine("Item removido: " + aux.getData());
                    }
                }
                else
                    Console.WriteLine("Item não Encontrado!!");
            }
        }

        public void imprime()
        {
            if (isEmpty())
            {
                Console.WriteLine("Lista vazia - Impossível Imprimir!");
            }
            else
            {
                NohLista<TAD> aux = new NohLista<TAD>();
                aux = inicio;
                Console.Write("Lista:   ");
                do
                {
                    Console.Write(aux.getData() + "    ");
                    aux = aux.getNext();
                } while (aux != null);
            }
        }

        public void inserirDepois(TAD elemento, TAD inserir)
        {
            NohLista<TAD> novoNoh = new NohLista<TAD>(inserir);
            if (isEmpty())
            {
                inicio = novoNoh;
                fim = novoNoh;
            }
            else
            {
                NohLista<TAD> aux = inicio;
                bool encontrou = false;
                do
                {
                    if (aux.getData().Equals(elemento))
                    {
                        encontrou = true;
                        break;
                    }
                    else
                        aux = aux.getNext();
                } while (aux != null);
                if (encontrou)
                {
                    if (aux == fim)
                    {
                        novoNoh.setPrior(aux);
                        aux.setNext(novoNoh);
                        fim = novoNoh;
                    }
                    else
                    {
                        novoNoh.setNext(aux.getNext());
                        novoNoh.setPrior(aux);
                        aux.setNext(novoNoh);
                        novoNoh.getNext().setPrior(novoNoh);
                    }
                }
                else
                    Console.WriteLine("Item não Encontrado!!");
            }
        }

        public void inserirAntes(TAD elemento, TAD inserir)
        {
            NohLista<TAD> novoNoh = new NohLista<TAD>(inserir);
            if (isEmpty())
            {
                inicio = novoNoh;
                fim = novoNoh;
            }
            else
            {
                NohLista<TAD> aux = inicio;
                bool encontrou = false;
                do
                {
                    if (aux.getData().Equals(elemento))
                    {
                        encontrou = true;
                        break;
                    }
                    else
                        aux = aux.getNext();
                } while (aux != null);
                if (encontrou)
                {
                    if (aux == inicio)
                    {
                        novoNoh.setNext(aux);
                        aux.setPrior(novoNoh);
                        inicio = novoNoh;
                    }
                    else
                    {
                        novoNoh.setPrior(aux.getPrior());
                        novoNoh.setNext(aux);
                        aux.setPrior(novoNoh);
                        novoNoh.getPrior().setNext(novoNoh);
                    }
                }
                else
                    Console.WriteLine("Item não Encontrado!!");
            }
        }
    }
}
