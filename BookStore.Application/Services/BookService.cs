using BookStore.Application.Abstractions;
using BookStore.Core.Contracts.Dto;
using BookStore.Core.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    internal sealed class BookService : IBookService
    {
        private readonly IRepositoryManager _repositoryManager;

        public BookService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public Task CreateAsync(BookDto book)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BookDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BookDto> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
