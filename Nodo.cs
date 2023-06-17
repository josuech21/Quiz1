namespace Capa_Modelo.Nodo
{
    public abstract class Nodo<T,N>
    {
        public abstract T Valor{get;set;}

        public abstract N Siguiente { get; set; }
    }
}
