using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Authors
{
    public interface IAuthorRepository : IRepository<Author, Guid>
    {
        Task<Author> FindByNameAsync(string name);

        Task<List<Author>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
            );
        //Task GetAsync(Guid id);
        //Task InsertAsync(Author author);
        //Task UpdateAsync(object author);
        //Task DeleteAsync(Guid id);
        //Task CountAsync(object p);
    }
}
