using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace Library_GUI
{
  internal class Query
  {
    private string connectionString = "Server=localhost;Database=library;Uid=root;Pwd=popasswopard;";

   //Get data from SQL for data tables and return it
    public DataTable LoadData(string query)
    {
      try
      {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
          connection.Open();

          using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
          {
            System.Data.DataTable dataTable = new System.Data.DataTable();

            adapter.Fill(dataTable);
            return dataTable;
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"{query}   Error: {ex.Message}");
        return null;
      }
    }

    //Update an SQL table
    public void UpdateData(string query)
    {
      try
      {

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
          connection.Open();

          using (MySqlCommand command = new MySqlCommand(query, connection))
          {
            command.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"{query}   Error: {ex.Message}");
      }
    }
    
    //Get a single item from SQL and return it's details in a list of strings
    public List<string> SingleRowQuery(string query)
    {
      List<string> info = new List<string>();
      try
      {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
          connection.Open();
          using (MySqlCommand command = new MySqlCommand(query, connection))
          {
            using (MySqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                  info.Add(reader[i].ToString());
                }
              }
            }
          }
        }
        return info;
      }
      catch (Exception ex)
      {
        MessageBox.Show($"{query} Error: {ex.Message}");
        return null;
      }
    }
    
    //Check to see if a specified value exists in a given column
    public bool ValueExists(string query, string column)
    {
      bool exists = false;
      try
      {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
          connection.Open();

          using (MySqlCommand command = new MySqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@valueToCheck", column);

            object result = command.ExecuteScalar();

            exists = (result != null && result != DBNull.Value);
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(query + "Error: " + ex.Message);
      }

      return exists;
    }

  }
}
