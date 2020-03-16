using System.Collections.Generic;

namespace Vueling.Infraestructure.Repository.Contracts
{
    public interface IRead<out T>
    {

        IEnumerable<T> ReadAll();

    }
}
