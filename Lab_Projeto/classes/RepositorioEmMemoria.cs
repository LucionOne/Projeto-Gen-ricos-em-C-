public class RepositorioEmMemoria<T> : IRepositorio<T>
{
    private List<T> itens = new List<T>();

    public void Adicionar(T item) => itens.Add(item);

    public List<T> ListarTodos() => itens;
    

}