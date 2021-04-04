using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _WEBAPP
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] path_arr = LogGetter.GetLogFiles();
            Console.WriteLine(path_arr.Length);
            LogGetter[] logs = new LogGetter[path_arr.Length];
            for (int j = 0; j<path_arr.Length; j++)
            {
                logs[j] = new LogGetter();
            }


            int i = 0;
            foreach (var log in logs) 
            {

                log.InitObj(path_arr[i]);
                i++;
            }
            
            foreach (var log in logs)
            {
                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();
                cell1.Text = log.date;
                HyperLink link = new HyperLink();
                link.Text = "log";
                
                link.NavigateUrl = $"/logFiles/{log.file_name}";
                cell2.Controls.Add(link);
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                myTable.Rows.Add(row);
            }
            
        }

    }
}