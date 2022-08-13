using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItIsNotOnlyMe.AnimacionesSistematicas;
using System;

public class Personaje : MonoBehaviour, IIKRig
{
    [System.Serializable]
    public struct Vinculo
    {
        public NodoBehaviour NodoPrincipal, NodoSecundario;

        public Vinculo(NodoBehaviour nodoPrincipal, NodoBehaviour nodoSecundario)
        {
            NodoPrincipal = nodoPrincipal;
            NodoSecundario = nodoSecundario;
        }
    }

    [SerializeField] private List<NodoBehaviour> _nodos = new List<NodoBehaviour>();
    [SerializeField] private List<Vinculo> _vinculos = new List<Vinculo>();

    private IKRig _ikRig;

    private void Awake()
    {
        _ikRig = new IKRig();
        foreach (NodoBehaviour nodo in _nodos)
            AgregarNodo(nodo);
        foreach (Vinculo vinculo in _vinculos)
            AgregarVinculo(vinculo.NodoPrincipal, vinculo.NodoSecundario);
    }

    public void AgregarNodo(INodo nodo)
    {
        _ikRig.AgregarNodo(nodo);
    }

    public void AgregarVinculo(INodo nodoPrincipal, INodo nodoSecundario)
    {
        _ikRig.AgregarVinculo(nodoPrincipal, nodoSecundario);
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        foreach (NodoBehaviour nodo in _nodos)
            Gizmos.DrawSphere(nodo.PosicionActual, 0.5f);

        Gizmos.color = Color.blue;
        foreach (Vinculo vinculo in _vinculos)
            Gizmos.DrawLine(vinculo.NodoPrincipal.PosicionActual, vinculo.NodoSecundario.PosicionActual);

        Gizmos.color = Color.white;
    }
}
