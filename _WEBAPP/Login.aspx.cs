using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace _WEBAPP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        const string config = @"C:\inetpub\wwwroot\config.json";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {
            var credentials = GetCredentials();
            string usrname = credentials.Item1;
            string password = credentials.Item2;
            if (TextBoxUsername.Text == usrname)
            {
                if (TextBoxPassword.Text == password)
                {

                    //do redirect to logger
                    /*
                    foreach (var a in LogGetter.GetLogFiles())
                    {
                        Response.Write(a);
                    }
                    */
                    Response.Redirect("LogListPage.aspx");


                   
                }
                else
                {
                    Response.Write("Authentification failed wrong pass");

                }
            }
            else
            {
                Response.Write("Authentification failed wrong usrname");
            }
        }
        protected Tuple<string,string> GetCredentials()
        {
            string username;
            string password;
            StreamReader r = new StreamReader(config);
            string json = r.ReadToEnd();
            dynamic config_file = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            username = config_file.username;
            password = config_file.password;
            return new Tuple<string,string>(username,password);
        }
    }
}