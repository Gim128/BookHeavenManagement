using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHeavenManagement.Models;

namespace BookHeavenManagement.Services
{
    public interface IBookService
    {
        DataTable GetAllBooks();
        Book GetBookById(int bookId);
        int AddBook(Book book);
        bool UpdateBook(Book book);
        bool DeleteBook(int bookId);
        DataTable SearchBooks(string searchTerm);
    }
}
