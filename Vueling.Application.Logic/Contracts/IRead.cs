using System.Collections.Generic;

namespace Vueling.Application.Logic.Contracts
{
    public interface IRead<out T>
    {

        IEnumerable<T> ReadAll();

    }
}
