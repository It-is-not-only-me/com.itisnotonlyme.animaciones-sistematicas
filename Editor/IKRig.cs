using System.Collections;
using System.Collections.Generic;

namespace ItIsNotOnlyMe.AnimacionesSistematicas
{
    public class IKRig : IIKRig
    {
        private struct Vinculo
        {
            public INodo NodoPrincipal, NodoSecundario;

            public Vinculo(INodo nodoPrincipal, INodo nodoSecundario)
            {
                NodoPrincipal = nodoPrincipal;
                NodoSecundario = nodoSecundario;
            }
        }

        private List<INodo> _nodos;
        private List<Vinculo> _vinculos;

        public IKRig()
        {
            _nodos = new List<INodo>();
            _vinculos = new List<Vinculo>();
        }   

        public void AgregarNodo(INodo nodo)
        {
            _nodos.Add(nodo);
        }

        public void AgregarVinculo(INodo nodoPrincipal, INodo nodoSecundario)
        {
            _vinculos.Add(new Vinculo(nodoPrincipal, nodoSecundario));
        }
    }
}
