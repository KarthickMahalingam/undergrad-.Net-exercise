using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:/java/SEMESTER 7/PRACTICE/Karthick.accdb'");
        OleDbCommand cmd=new OleDbCommand();
        con.Open();
        cmd.CommandText="Insert into karthickdb(name,salary)values('" +TextBox1.Text +"','" +TextBox2.Text +"')";
        cmd.ExecuteNonQuery();
        Response.Write("<Script>'succes'</script>");


    }
}