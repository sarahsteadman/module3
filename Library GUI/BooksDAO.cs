using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_GUI
{
  internal class BooksDAO
  {
    string connectionString = "datasource=localhost;port=3306;username=root;password=hot4Travis;database-library";
    public List<Book> GetBooks()
    {
      List<Book> list = new List<Book>();

      MySqlConnection connection = new MySqlConnection(connectionString);
      connection.Open();


      return list;
    }
  }
}
