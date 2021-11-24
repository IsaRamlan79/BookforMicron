﻿using BookforMicron.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookforMicron.Repositiories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int id);

        Task<Book> Create(Book book);

        Task Update(Book book);
        Task Delete(int id);


    }
}
