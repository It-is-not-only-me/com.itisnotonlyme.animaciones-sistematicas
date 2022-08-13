namespace ItIsNotOnlyMe.AnimacionesSistematicas
{
    public interface IIKRig
    {
        public void AgregarNodo(INodo nodo);

        public void AgregarVinculo(INodo nodoPrincipal, INodo nodoSecundario);
    }
}
