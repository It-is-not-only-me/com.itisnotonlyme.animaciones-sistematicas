using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesSistematicas
{
    public class Nodo : INodo
    {
        public Vector3 PosicionActual { get => _posicion; }

        private Vector3 _posicion;
    }
}
