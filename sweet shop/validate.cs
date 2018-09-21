using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace sweet_shop
{
    class validate
    {
        public bool valname(string name)
        {
            if (!Regex.Match(name, "^[a-z A-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid name");
                return false;
            }
            return true;
        }
        public bool mob_no(string name)
        {
            if (!Regex.Match(name, "^[0-9]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid phone number");
                return false;
            }
            return true;
        }
    }
}
