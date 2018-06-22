using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using System.IO;

namespace BooksSingleTableDb
{   
    /// <summary>
    /// This class has all of the methods for creating and interacting with the database
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Variable available to all of the methods in the class
        /// </summary>
        public const string CONNECTION_STRING = "Data Source=Books.db;Version=3";

        /// <summary>
        /// Create database method, the database script handles if the table have already been made
        /// so it will not overwrite the existing database
        /// </summary>
        public void SeedDatabase()
        {
            try
            {
                string seed = File.ReadAllText("dbScript.txt");

                using (var db = new SQLiteConnection(CONNECTION_STRING).OpenAndReturn())
                {
                    var cmd = db.Execute(seed);
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Problem creating db " + ex);
            }
        }

        /// <summary>
        /// Query to get all of the records in the BooksWithAuthor view
        /// </summary>
        /// <returns>A list containing all of the records in the BooksWithAuthor view</returns>
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

        /// <summary>
        /// Query to get all of the records in the authors table
        /// </summary>
        /// <returns>A list containing all of the records in the authors table</returns>
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
                catch 
                {
                    return new List<Author>();
                }
            }
        }

        #region AddEditAuthorsAndBooks
        /// <summary>
        /// Query to Insert records in the authors table
        /// </summary>
        /// <param name="authorName">The value for this param is taken from txtAuthorName from frmMain</param>
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

        /// <summary>
        /// Query to Update records in the authors table
        /// </summary>
        /// <param name="authorId">The value for this param is taken from lblAuthorID from frmMain</param>
        /// <param name="authorName">The value for this param is taken from txtAuthorName from frmMain</param>
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

        /// <summary>
        /// Query to Insert records in the authors table
        /// </summary>
        /// <param name="bookTitle">The value for this param is taken from txtBookTitle from frmMain</param>
        /// <param name="bookGenre">The value for this param is taken from txtBookGenre from frmMain</param>
        /// <param name="authorDropdown">The value for this param is taken from cboAuthor from frmMain</param>
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
        
        /// <summary>
        /// Query to Update records in the authors table
        /// </summary>
        /// <param name="bookTitle">The value for this param is taken from txtBookTitle from frmMain</param>
        /// <param name="bookGenre">The value for this param is taken from txtBookGenre from frmMain</param>
        /// <param name="authorDropdown">The value for this param is taken from cboAuthor from frmMain</param>
        /// <param name="bookId">The value for this param is taken from lblBookEditID from frmMain</param>
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
        /// <summary>
        /// Query to get the first record in the authors table
        /// </summary>
        /// <returns>An object containing a single row in the authors table</returns>
        public Author getFirstAuthor()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM authors ORDER BY authorId ASC LIMIT 1";
                var result = db.QuerySingle<Author>(query);
                return result;
            }   
        }

        /// <summary>
        /// Query to get the last record in the authors table
        /// </summary>
        /// <returns>An object containing a single row in the authors table</returns>
        public Author getLastAuthor()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM authors ORDER BY authorId DESC LIMIT 1";
                var result = db.QuerySingle<Author>(query);
                return result;
            }
        }

        /// <summary>
        /// Query to get the next record in the authors table
        /// </summary>
        /// <param name="authorId">The value for this param is taken from lblAuthorID from frmMain</param>
        /// <returns>An object containing a single row in the authors table</returns>
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

        /// <summary>
        /// Query to get the previous record in the authors table
        /// </summary>
        /// <param name="authorId">The value for this param is taken from lblAuthorID from frmMain</param>
        /// <returns>An object containing a single row in the authors table</returns>
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
        
        #region AllBooksNavigation
        /// <summary>
        /// Query to get the first record in the BooksWithAuthor view
        /// </summary>
        /// <returns>An object containing a single row in the BooksWithAuthor view</returns>
        public BooksWithAuthorName getFirstBookAndAuthor()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor ORDER BY bookId ASC LIMIT 1";
                var result = db.QuerySingle<BooksWithAuthorName>(query);
                return result;
            }
        }

        /// <summary>
        /// Query to get the last record in the BooksWithAuthor view
        /// </summary>
        /// <returns>An object containing a single row in the BooksWithAuthor view</returns>
        public BooksWithAuthorName getLastBookAndAuthor()
        {
            using (var db = new SQLiteConnection(CONNECTION_STRING))
            {
                var query = "SELECT * FROM BooksWithAuthor ORDER BY bookId DESC LIMIT 1";
                var result = db.QuerySingle<BooksWithAuthorName>(query);
                return result;
            }
        }
        
        /// <summary>
        /// Query to get the next record in the BooksWithAuthor view
        /// </summary>
        /// <param name="bookId">The value for this param is taken from lblBookEditID for 
        /// the book add and edit and lblBookId for the book navigation on frmMain</param>
        /// <returns>An object containing a single row in the BooksWithAuthor view</returns>
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

        /// <summary>
        /// Query to get the previous record in the BooksWithAuthor view
        /// </summary>
        /// <param name="bookId">The value for this param is taken from lblBookEditID for 
        /// the book add and edit and lblBookId for the book navigation on frmMain</param>
        /// <returns>An object containing a single row in the BooksWithAuthor view</returns>
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
