using System;
using System.Collections.Generic;
using CatalogoSeries.Interfaces;

namespace CatalogoSeries
{
    public class SerieRepositore : IRepositorie<Series>
    {
        private List<Series> listSeries = new List<Series>();
        public void Atualiza(int id, Series objeto)
        {
            listSeries[id] = objeto;
        }

        public void Exclui(int id)
        {
            listSeries[id].Excluir();
        }

        public void insere(Series objeto)
        {
            listSeries.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listSeries;
        }

        public int proximoId()
        {
            return listSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listSeries[id];
        }
    }
}