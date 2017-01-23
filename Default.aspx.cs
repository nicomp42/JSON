﻿/*********************************************************
 * Repo at https://github.com/nicomp42/JSON
 * 
 * C:\Users\nicomp\Google Drive\IT 3047-001 Web Server App Dev\JSON\JSON
 * Clicking "Publish: in VS will create a repo in the folder where the project is. Awesome. 
 * Be sure the .sln file is in the same folder as the project before clicking "publish" in VS: do a "File/Save As" on the .sln file
 * 
 * Install NewtonSoft.json into the VS Project using nuGet. It's easy and fun. 
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
            // This really fun because of the quoted string inside a C# String
            txtJson.Text = "{\"lastName\":\"Nicholson\",\"Friends\":[\"Brenda\",\"Hannah\",\"Barry\"]}";
        }
    }

    protected void btnConvert_Click(object sender, EventArgs e) {
        Person p = new Person("","", 0,null,"");

        // Decode from Json string to a C# object
        Newtonsoft.Json.JsonConvert.PopulateObject(txtJson.Text, p);

        txtLastName.Text = p.lastName;

        string friendsCSV = string.Join(",", p.friends.ToArray());

        txtFriends.Text = friendsCSV;
    }
}