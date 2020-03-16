namespace Vueling.Application.Logic.Contracts
{
    public interface ICreate<T>
    {

        T Create(T model);

    }
}
