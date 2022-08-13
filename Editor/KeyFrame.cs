using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesSistematicas
{
    public struct KeyFrame
    {
        public struct Movimiento
        {
            public INodo NodoActual;
            public Vector3 PosicionFinal;
        }

        private Dictionary<INodo, Vector3> _movimientos;

        public KeyFrame(List<Movimiento> movimientos)
        {
            _movimientos = new Dictionary<INodo, Vector3>();
            foreach (Movimiento movimiento in movimientos)
                _movimientos.Add(movimiento.NodoActual, movimiento.PosicionFinal);
        }

        public Vector3 this[INodo nodo] { get => _movimientos.ContainsKey(nodo) ? _movimientos[nodo] : nodo.PosicionActual; }
    }
}
