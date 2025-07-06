namespace myfinance_web_dotnet_o8.Services
{
    public interface IRepository<T> where T : class
    {
        void Salvar(T item);
        void Excluir(int id);
        List<T> ListarRegistros();
        T RetornarRegistro(int id);
    }
}