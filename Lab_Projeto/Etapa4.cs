using System;
using System.Collections.Generic;
using System.Linq;

namespace LabProjeto
{
    public class Entidade
    {
        public int Id { get; set; }
    }

    public class Repositorio<T> where T : Entidade
    {
        private List<T> _itens = new List<T>();

        public void Adicionar(T item)
        {
            _itens.Add(item);
        }
        
        public T? BuscarPorId(int id)
        {
            return _itens.FirstOrDefault(item => item.Id == id);
        }
    }

    public class RepositorioComInstancia<T> where T : new()
    {
        public T CriarItem() => new T();
    }

    public class Cliente : Entidade
    {
        public string? Nome { get; set; }

        public Cliente() { }
    }
}
