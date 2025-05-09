using System;
using System.Collections.Generic;
using Books.Model;

namespace HomeLibrary.BLL;

public interface IService
{
    public bool Create(Book book);
    public IEnumerable<Book> GetAll();
    public IEnumerable<Book> GetByTitle(string title);
}
