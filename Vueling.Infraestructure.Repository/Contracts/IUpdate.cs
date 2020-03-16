namespace Vueling.Infraestructure.Repository.Contracts
{
    public interface IUpdate<T>
    {

        T Update(T model);

    }
}
