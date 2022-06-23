using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Domain.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        Task<int> CompleteAsync();
    }
}
