﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> GetAllAuthors();
        public List<Author> GetAuthors(string? job,string? search);
        public Author GetAuthor(int id);
    }
}
