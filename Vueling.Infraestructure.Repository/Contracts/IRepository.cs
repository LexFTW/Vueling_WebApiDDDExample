namespace Vueling.Infraestructure.Repository.Contracts
{
    public interface IRepository<T> : ICreate<T>,
                                      IRead<T>,
                                      IUpdate<T>,
                                      IDelete
    {
    }
}
