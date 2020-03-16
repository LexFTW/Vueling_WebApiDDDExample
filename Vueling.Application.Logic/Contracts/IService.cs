namespace Vueling.Application.Logic.Contracts
{
    public interface IService<T> : ICreate<T>,
                                      IRead<T>,
                                      IUpdate<T>,
                                      IDelete
    {
    }
}
