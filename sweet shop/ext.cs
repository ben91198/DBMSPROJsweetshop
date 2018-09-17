using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sweet_shop
{
    class ext
    {
        public AutoCompleteStringCollection addcollection(string str,ref MySqlConnection con)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(str, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            
            reader.Close();
            con.Close();
            return MyCollection;
        }
    }
}
