using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using System.IO;

// this is meant to be the backend. yes it is a crude and simple example  
namespace BooksSingleTableDb
{
    public class Database
    {
        public const string CONNECTION_STRING = "Data Source=Books.db;Version=3";

        public void SeedDatabase()
        {
            try
            {
                // yes this a bit backhanded though it does make it obvious that I want it to do nothing
                // if the db already exists (more to highlight the situation)
                if (File.Exists("Books.db"))
                {
                    // do nothing
                }
                else
                {
                    string seed = File.ReadAllText("dbScript.txt");

                    using (var db = new SQLiteConnection(CONNECTION_STRING).OpenAndReturn())
                    {
                        var cmd = db.Execute(seed);
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Problem creating db " + ex);
            }
        }

        public List<BooksWithAuthorName> GetAllBooksWithAuthors()
        {
            using (SQLiteConnection db = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    string query = "SELECT * FROM BooksWithAuthor";
                    List<BooksWithAuthorName> result = db.Query<BooksWithAuthorName>(query).ToList();
                    return result;
                }
                catch
                {
                    return new List<BooksWithAuthorName>();
                }
            }
        }
        
        public List<Author> GetAllAuthors()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    string query = "SELECT * FROM authors";
                    var list = db.Query<Author>(query).ToList();
                    return list;
                }
                catch (Exception ex)
                {
                    return new List<Author>();
                    ;       //this line just to do quick debug can't be bothered with an error log txt file
                }
            }
        }

        #region AddEditAuthorsAndBooks
        public void insertAuthor(string authorName)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING).OpenAndReturn())
            using (var trans = db.BeginTransaction())
            {
                try
                {
                    string query = "INSERT INTO authors (authorName) VALUES (@an)";
                    var param = new { an = authorName };
                    db.Execute(query, param, trans);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                }
            }
        }

        public void updateAuthor(string authorId, string authorName)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING).OpenAndReturn())
            using (var trans = db.BeginTransaction())
            {
                try
                {
                    string query = "UPDATE authors SET authorName = @an WHERE authorId = @id";
                    var param = new { an = authorName, id = authorId };
                    db.Execute(query, param, trans);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                }
            }
        }

        public void InsertBook(string bookTitle, string bookGenre, string authorDropdown)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING).OpenAndReturn())
            using (var trans = db.BeginTransaction())
            {
                try
                {
                    string query = "INSERT INTO books (bookTitle, bookGenre, author) VALUES (@bt, @bg, @a)";
                    var param = new { bt = bookTitle, bg = bookGenre, a = authorDropdown };
                    db.Execute(query, param, trans);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                }
            }
        }

        public void updateBooks(string bookTitle, string bookGenre, string authorDropdown, string bookId)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING).OpenAndReturn())
            using (var trans = db.BeginTransaction())
            {
                try
                {
                    string query = "UPDATE books SET bookTitle = @bt, bookGenre = @bg, author = @a WHERE bookId = @bi";
                    var param = new { bt = bookTitle, bg = bookGenre, a = authorDropdown, bi = bookId };
                    db.Execute(query, param, trans);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                }
            }
        }
        #endregion

        #region AuthorNavigationButtons
        public Author getFirstAuthor()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM authors ORDER BY authorId ASC LIMIT 1";
                var result = db.QuerySingle<Author>(query);
                return result;
            }   
        }

        public Author getLastAuthor()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM authors ORDER BY authorId DESC LIMIT 1";
                var result = db.QuerySingle<Author>(query);
                return result;
            }
        }

        public Author getNextAuthor(string authorId)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM authors WHERE authorId > @id LIMIT 1";
                var param = new { id = authorId};
                var result = db.QuerySingle<Author>(query, param);
                return result;
            }
        }

        public Author getPreviousAuthor(string authorId)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM authors WHERE authorId < @id ORDER BY authorId DESC LIMIT 1";
                var param = new { id = authorId };
                var result = db.QuerySingle<Author>(query, param);
                return result;
            }
        }
        #endregion

        #region BookNavigationButtons
        public BooksWithAuthorName getFirstBook()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor ORDER BY bookId ASC LIMIT 1";
                var result = db.QuerySingle<BooksWithAuthorName>(query);
                return result;
            }
        }

        public BooksWithAuthorName getLastBook()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor ORDER BY bookId DESC LIMIT 1";
                var result = db.QuerySingle<BooksWithAuthorName>(query);
                return result;
            }
        }

        public BooksWithAuthorName getNextBook(string bookId)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor WHERE bookId > @id LIMIT 1";
                var param = new { id = bookId };
                var result = db.QuerySingle<BooksWithAuthorName>(query, param);
                return result;
            }
        }

        public BooksWithAuthorName getPreviousBook(string bookId)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor WHERE bookId < @id ORDER BY bookId DESC LIMIT 1";
                var param = new { id = bookId };
                var result = db.QuerySingle<BooksWithAuthorName>(query, param);
                return result;
            }
        }
        #endregion

        #region AllBooksNavigation
        public BooksWithAuthorName getFirstBookAndAuthor()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor ORDER BY bookId ASC LIMIT 1";
                var result = db.QuerySingle<BooksWithAuthorName>(query);
                return result;
            }
        }

        public BooksWithAuthorName getLastBookAndAuthor()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor ORDER BY bookId DESC LIMIT 1";
                var result = db.QuerySingle<BooksWithAuthorName>(query);
                return result;
            }
        }

        public BooksWithAuthorName getNextBookAndAuthor(string bookId)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor WHERE bookId > @id LIMIT 1";
                var param = new { id = bookId };
                var result = db.QuerySingle<BooksWithAuthorName>(query, param);
                return result;
            }
        }

        public BooksWithAuthorName getPreviousBookAndAuthor(string bookId)
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor WHERE bookId < @id ORDER BY bookId DESC LIMIT 1";
                var param = new { id = bookId };
                var result = db.QuerySingle<BooksWithAuthorName>(query, param);
                return result;
            }
        }
        #endregion

    }
}
