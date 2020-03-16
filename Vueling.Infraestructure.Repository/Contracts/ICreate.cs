namespace Vueling.Infraestructure.Repository.Contracts
{
    public interface ICreate<T>
    {

        T Create(T model);

    }
}
