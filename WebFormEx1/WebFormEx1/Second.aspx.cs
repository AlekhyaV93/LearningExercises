using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebFormEx1
{
    public partial class Second : System.Web.UI.Page
    {
        public string str = "data source=.; database=alekhyaPractice; integrated security=SSPI";

        public string conStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable("Employee Data");
            dt.Columns.Add("ID", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Employee Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Department", System.Type.GetType("System.String"));

            object[] one = { 1, "Alu", "ECE" };
            object[] two = { 2, "Avi", "IT" };
            object[] three = { 3, "Sandy", "CSE" };

            dt.Rows.Add(one);
            dt.Rows.Add(two);
            dt.Rows.Add(three);

            
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            GridView1.DataSource = ds;
            GridView1.DataBind();*/
             

           using (

            SqlConnection con = new SqlConnection(conStr)

                )
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select ID,name,email,join_date from Student", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                List<string> datalst = new List<string>();
                while (sdr.Read())
                {
                    string name = sdr.GetString(1);
                    DateTime jdate = sdr.GetDateTime(3);

                    //datalst = new List<object>();
                    datalst.Add(sdr.GetInt32(0) + " " + sdr["name"].ToString() + " " + sdr["email"] + " " + sdr["join_date"]);
                }
                Response.Write("afdsgfhgg");
                GridView1.DataSource = datalst;
                GridView1.DataBind();

                /*SqlDataAdapter sda = new SqlDataAdapter("select * from Student", con);
                DataSet ds=new DataSet();
                sda.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                 * */

            }

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            //lblResult.Text = txtName.Text + " " + txtCity.Text + " " + txtStreet.Text + " " + txtState.Text;
            //string st = txtName.Text + " " + txtStreet.Text + " " + txtCity.Text + " " + txtState.Text + " " + CalenderCtrl1.SelectedDate; 
            //displayRow.InnerHtml = st;
            using (

            SqlConnection con = new SqlConnection(str)
                )
            {

                con.Open();
                /*SqlCommand cmd = new SqlCommand("insert into Student(ID,name,email,join_date) values(@id,@name,@email,@date)", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@date", CalenderCtrl1.SelectedDate);*/

                SqlCommand cmd = new SqlCommand("insert_student", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", txtID.Text);
                cmd.Parameters.Add("@name", txtName.Text);
                cmd.Parameters.Add("@email", txtemail.Text);
                cmd.Parameters.Add("@date", CalenderCtrl1.SelectedDate);



                int status = cmd.ExecuteNonQuery();
                if (status >= 1)
                {
                    displayRow.InnerHtml = "Student has been added successfully ";
                }


            }
        }



    }
}