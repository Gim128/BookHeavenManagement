using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BookHeavenManagement.Models;
using BookHeavenManagement.Utilities;

namespace BookHeavenManagement.Services
{
    public class BookService : IBookService
    {
        public int AddBook(Book book)
        {
            string query = @"INSERT INTO Books (ISBN, Title, Author, Genre, Price, QuantityInStock, SupplierID, Description)
                           VALUES (@ISBN, @Title, @Author, @Genre, @Price, @Quantity, @SupplierID, @Description);
                           SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ISBN", book.ISBN),
                new SqlParameter("@Title", book.Title),
                new SqlParameter("@Author", book.Author),
                new SqlParameter("@Genre", book.Genre),
                new SqlParameter("@Price", book.Price),
                new SqlParameter("@Quantity", book.QuantityInStock),
                new SqlParameter("@SupplierID", book.SupplierID ?? (object)DBNull.Value),
                new SqlParameter("@Description", book.Description ?? (object)DBNull.Value)
            };

            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
        }

        public bool DeleteBook(int bookId)
        {
            string query = "DELETE FROM Books WHERE BookID = @BookID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BookID", bookId)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAllBooks()
        {
            string query = @"SELECT b.BookID, b.ISBN, b.Title, b.Author, b.Genre, b.Price, 
                           b.QuantityInStock, s.Name AS Supplier
                           FROM Books b LEFT JOIN Suppliers s ON b.SupplierID = s.SupplierID";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public Book GetBookById(int bookId)
        {
            string query = "SELECT * FROM Books WHERE BookID = @BookID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BookID", bookId)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return new Book
                {
                    BookID = (int)result.Rows[0]["BookID"],
                    ISBN = result.Rows[0]["ISBN"].ToString(),
                    Title = result.Rows[0]["Title"].ToString(),
                    Author = result.Rows[0]["Author"].ToString(),
                    Genre = result.Rows[0]["Genre"].ToString(),
                    Price = (decimal)result.Rows[0]["Price"],
                    QuantityInStock = (int)result.Rows[0]["QuantityInStock"],
                    SupplierID = result.Rows[0]["SupplierID"] as int?,
                    Description = result.Rows[0]["Description"].ToString()
                };
            }
            return null;
        }

        public DataTable SearchBooks(string searchTerm)
        {
            string query = @"SELECT * FROM Books 
                           WHERE Title LIKE @Search OR Author LIKE @Search OR ISBN LIKE @Search";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Search", $"%{searchTerm}%")
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public bool UpdateBook(Book book)
        {
            {
                string query = @"UPDATE Books SET ISBN = @ISBN, Title = @Title, Author = @Author,
                           Genre = @Genre, Price = @Price, QuantityInStock = @Quantity,
                           SupplierID = @SupplierID, Description = @Description
                           WHERE BookID = @BookID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@BookID", book.BookID),
                new SqlParameter("@ISBN", book.ISBN),
                new SqlParameter("@Title", book.Title),
                new SqlParameter("@Author", book.Author),
                new SqlParameter("@Genre", book.Genre),
                new SqlParameter("@Price", book.Price),
                new SqlParameter("@Quantity", book.QuantityInStock),
                new SqlParameter("@SupplierID", book.SupplierID ?? (object)DBNull.Value),
                new SqlParameter("@Description", book.Description ?? (object)DBNull.Value)
                };

                return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
            }
        }
    }

}
