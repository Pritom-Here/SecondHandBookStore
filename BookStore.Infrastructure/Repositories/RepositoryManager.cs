using BookStore.Core.Domain.Repositories;
using BookStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Infrastructure.Repositories
{
    internal sealed class RepositoryManager : IRepositoryManager
    {
        private readonly BookStoreDbContext _dbContext;

        public IBookRepository BookRepository { get; private set; }
        public IUnitOfWork UnitOfWork { get; private set; }

        public RepositoryManager(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
            BookRepository = new BookRepository(_dbContext);
            UnitOfWork = new UnitOfWork(_dbContext);
        }
    }
}
