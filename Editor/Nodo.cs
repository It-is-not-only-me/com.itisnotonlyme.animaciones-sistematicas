using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesSistematicas
{
    public class Nodo : INodo
    {
        public Vector3 PosicionActual { get => _posicion; }
        public Vector3 Direccion { get => _direccion; }

        private Vector3 _posicion, _direccion;
    }
}
