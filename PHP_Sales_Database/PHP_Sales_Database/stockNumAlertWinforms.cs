using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace displayItemsWinforms
{
    class stockNumAlertWinforms
    {

        private string message;
        public stockNumAlertWinforms()
        {
        }

        public void stockAlert()
        {
            var strLines = File.ReadLines(@"PATH AND FILE NAME"); // path and filename will be replaced with actual path of database
            foreach (var line in strLines)
            {
                if (Int32.Parse(line.Split(',')[4]) < 10) // replace array element with corresponding column for AMOUNT
                {
                    message = "alert " + line.Split(',')[1] + " is at low stock, only " + line.Split(',')[4] + " left"; // replace array elements with corresponding column for ITEM NAME and AMOUNT
                    MessageBox.Show(message);
                }
            }

            

        }

    }
}
