/*********************************************************
 * C:\Users\nicomp\Google Drive\IT 3047-001 Web Server App Dev\JSON\JSON
 * Clicking "Publish: in VS will create a repo in the folder where the project is. Awesome. 
 * Be sure the .sln file is in the same folder as the project before clicking "publish" in VS.
 * 
 * Install NewtonSoft.json using nuGet
 * 
 * This is also helpful: https://www.youtube.com/watch?v=j28OXdlJ2EI
 * 
 * *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            txtJson.Text = "{\"lastName\":\"Nicholson\"}";
        }
    }

    protected void btnConvert_Click(object sender, EventArgs e) {
        Person p = new Person("","", 0,null,"");
        Newtonsoft.Json.JsonConvert.PopulateObject(txtJson.Text, p);

        txtLastName.text = p.lastName;
    }
}