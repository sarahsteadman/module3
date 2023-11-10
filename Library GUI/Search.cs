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
  public partial class Search : Form
  {
    public Search()
    {
      InitializeComponent();
    }

    //Fill Combobox on load
    private void Search_Load(object sender, EventArgs e)
    {
      List<String> comboContents = new List<string>
      {
        "Book Id", "Title", "Author", "Genre"
      };

      comboBox1.Items.AddRange(comboContents.ToArray());
    }

    //Return to menu button
    private void menu_Click(object sender, EventArgs e)
    {
      Form1 viewForm1 = new Form1();
      viewForm1.Show();
      Close();
    }

    //Fill data grid with requested SQL data when button is clicked
    private void button1_Click(object sender, EventArgs e)
    {
      string queryString = "";
      string selection = "";
      string search = "";
      if (string.IsNullOrEmpty(searchBox.Text))
      {
        queryString = $"Select bookid, title, author, isbn, genre, checked_out from bookcatalog;";
      }
      else
      {
        if (comboBox1.Text == "Book Id")
        {
          selection = "bookid";
          search = searchBox.Text;
        }
        else
        {
          selection = comboBox1.Text;
          search = '"' + searchBox.Text + '"';
        }
        queryString = $"Select bookid, title, author, isbn, genre, checked_out from bookcatalog where {selection} = {search}";
      }

      Query query = new Query();
      dataGridView1.DataSource = query.LoadData(queryString);

    }
  }
}
