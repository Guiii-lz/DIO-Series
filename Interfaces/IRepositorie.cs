using System.Collections.Generic;

namespace CatalogoSeries.Interfaces
{
    public interface IRepositorie<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);
        void insere(T objeto);
        void Exclui(int id);
        void Atualiza(int id, T objeto);
        int proximoId();
    }
}