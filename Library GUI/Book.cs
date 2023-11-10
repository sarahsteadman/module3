using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_GUI
{
  internal class Book
  {
    public int bookID {  get; set; }
    public string title { get; set; }
    public string Author { get; set; }
    public string isbn { get; set; }
    public string genre {  get; set; }
    public bool checkedOut { get; set; }
    public int borrower {  get; set; }
    public DateTime dueDate { get; set; }
  }
}
