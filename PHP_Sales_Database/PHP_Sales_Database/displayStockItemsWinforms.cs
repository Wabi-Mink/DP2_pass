using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace displayItemsWinforms
{
    class displayItems
    {
        private string queryItem;

        public displayItems()
        {
        }

        public int searchItem(string qItem)
        {
            queryItem = qItem;
            
            var strLines = File.ReadLines(@"PATH AND FILE NAME"); // path and filename will be replaced with actual path of database
            foreach (var line in strLines)
            {
                if (line.Split(',')[1].Equals(qItem)) // replace array element with corresponding column for Item name

                return Int32.Parse(line.Split(',')[2]); // replace array element with corresponding column for amount
            }

            return 0;

        }
        
    }
}
