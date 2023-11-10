using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_GUI
{
  public partial class Form1 : Form
  {
    BindingSource booksBindingSource = new BindingSource();
    public Form1()
    {
      InitializeComponent();
    }


    //All below functions take user to different pages when a button is clicked
    private void books_Click(object sender, EventArgs e)
    {
      Search viewSearch = new Search();
      viewSearch.Tag = this;
      viewSearch.Show(this);
      Hide();
    }

    private void Members_Click(object sender, EventArgs e)
    {
      Members viewMembers = new Members();
      viewMembers.Tag = this;
      viewMembers.Show(this);
      Hide();
    }

    private void checkOut_Click(object sender, EventArgs e)
    {
      CheckOut viewCheckOut = new CheckOut();
      viewCheckOut.Tag = this;
      viewCheckOut.Show(this);
      Hide();
    }

    private void checkIn_Click(object sender, EventArgs e)
    {
      CheckIn viewCheckIn = new CheckIn();
      viewCheckIn.Tag = this;
      viewCheckIn.Show(this);
      Hide();
    }
  }
}
