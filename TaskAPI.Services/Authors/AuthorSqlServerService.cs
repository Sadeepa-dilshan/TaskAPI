using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }

        public List<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }
    }
}
