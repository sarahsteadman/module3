using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_GUI
{
  public partial class CheckOut : Form
  {
    public CheckOut()
    {
      InitializeComponent();
    }

    //Return to Menu
    private void menu_Click(object sender, EventArgs e)
    {
      Form1 viewForm1 = new Form1();
      viewForm1.Show();
      Close();
    }

    //Fill available books grid on page load
    private void CheckOut_Load(object sender, EventArgs e)
    {
      Query query = new Query();

      availableBooks.DataSource = query.LoadData("Select bookid, title, author from bookcatalog where checked_out = 0;");
    }

    //Checks out the requested book to the library card number that has been selected
    private void outBtn_Click(object sender, EventArgs e)
    {
      Query query = new Query();

      string cardQuery = $"select * from librarymembers where librarycardnumber = '{card.Text}';";
      if (query.ValueExists(cardQuery, "librarycardnumber"))
      {
        try
        {
          List<String> member = query.SingleRowQuery(cardQuery);
          List<String> item = query.SingleRowQuery($"Select * from bookcatalog where bookid = {book.Text};");

          string due_date = DateTime.Today.AddDays(28).ToString("yyyy-MM-dd");
          string queryString = $"Update BookCatalog Set checked_out = 1, borrower = {member[0]}, due_date = '{due_date}' where bookid = {book.Text};";

          query.UpdateData(queryString);
          MessageBox.Show($"{item[1]} has been checked out to {member[2]} {member[3]}");

          availableBooks.DataSource = query.LoadData("Select bookid, title, author from bookcatalog where checked_out = 0;");
          book.Text = "";
          card.Text = "";

        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex.Message);
        }
      }

    }
  }
}
