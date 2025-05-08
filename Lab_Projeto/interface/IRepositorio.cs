public interface IRepositorio<T>
{
    void Adicionar(T item);
    List<T> ListarTodos();
}