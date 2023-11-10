using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_GUI
{
  public partial class Members : Form
  {
    public Members()
    {
      InitializeComponent();
    }
    //Return to Menu Button
    private void menu_Click(object sender, EventArgs e)
    {
      Form1 viewForm1 = new Form1();
      viewForm1.Show();
      Close();
    }

    //Fill combo box on load
    private void Members_Load(object sender, EventArgs e)
    {
      List<String> comboContents = new List<string>
      {
        "ID", "Library Card"
      };

      comboBox1.Items.AddRange(comboContents.ToArray());
    }

    //Find Member information that has been searched for when button is clicked
    private void button1_Click(object sender, EventArgs e)
    {

      if (!string.IsNullOrEmpty(searchBox.Text))
      {
        string search = "";
        string selection = "";

        if (comboBox1.Text == "ID")
        {
          selection = "MemberID";
          search = searchBox.Text;
        }
        else if (comboBox1.Text == "Library Card")
        {
          selection = "LibraryCardNumber";
          search = '"' + searchBox.Text + '"';
        }
        search = '"' + searchBox.Text + '"';
        Query query = new Query();

        try
        {
          List<String> memberInfo = query.SingleRowQuery($"Select memberid, librarycardnumber, firstname, lastname from librarymembers where {selection} = {search};");

          memId.Text = $"ID: {memberInfo[0]}";
          card.Text = $"Card Number: {memberInfo[1]}";
          name.Text = $"Name: {memberInfo[2]} {memberInfo[3]}";
          string queryString = $"Select bookid, title, author, due_date from bookcatalog where borrower = {memberInfo[0]};";
          dataGridView1.DataSource = query.LoadData(queryString);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }


      }
    }

  }
}
