using UnityEngine;
using ItIsNotOnlyMe.AnimacionesSistematicas;

public class NodoBehaviour : MonoBehaviour, INodo
{
    public Vector3 PosicionActual => transform.position;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(PosicionActual, 0.5f);
        Gizmos.color = Color.white;
    }
}
