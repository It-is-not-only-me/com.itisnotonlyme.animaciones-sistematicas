using UnityEngine;
using ItIsNotOnlyMe.AnimacionesSistematicas;

public class NodoBehaviour : MonoBehaviour, INodo
{
    public Vector3 PosicionActual => transform.position;

    public Vector3 Direccion => transform.rotation * Vector3.forward;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(PosicionActual, 0.5f);
        Gizmos.DrawLine(PosicionActual, PosicionActual + Direccion);
        Gizmos.color = Color.white;
    }
}
