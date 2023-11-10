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
  public partial class CheckIn : Form
  {
    public CheckIn()
    {
      InitializeComponent();
    }

    private void menu_Click(object sender, EventArgs e)
    {
      Form1 viewForm1 = new Form1();
      viewForm1.Show();
      Close();
    }

    //Checks in the book entered
    private void inBtn_Click(object sender, EventArgs e)
    {
      string book = bookNum.Text;
      string queryString = $"Update BookCatalog Set checked_out = 0, borrower = null, due_date = null where bookid = {book}";

      Query query = new Query();

      try
      {
        query.UpdateData(queryString);
        MessageBox.Show("Book Checked in");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }
  }
}
