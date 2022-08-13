using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesSistematicas
{
    public interface INodo
    {
        Vector3 PosicionActual { get; }

        Vector3 Direccion { get; }
    }
}