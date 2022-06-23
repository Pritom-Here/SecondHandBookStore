using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Domain.Repositories
{
    public interface IRepositoryManager
    {
        public IBookRepository BookRepository { get; }
        public IUnitOfWork UnitOfWork { get; }

    }
}
