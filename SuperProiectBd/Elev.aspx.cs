using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace SuperProiectBd
{
    public partial class Elev : System.Web.UI.Page
    {
        public DataTable interogare(string query)

        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (2 != Convert.ToInt32(Session["sesiune"]))
                {
                    Response.Redirect("Pagina1");

                }
            }
            catch
            {
                Response.Redirect("Pagina1");
            }
            DataTable dt = interogare("select Nume + ' ' + Prenume from Elevi where ElevID =  " + Convert.ToInt32(Session["id"]));
            Label1.Text = Convert.ToString(dt.Rows[0][0]);

            DataTable dt2 = interogare("Select o.Data, o.NrSedinta as 'Numarul Sedintei',o.Locatia, i.Nume +' '+ i.Prenume as 'Instuctorul' from OraCondus o join Instructor i on (o.InstructorAutoID = i.InstructorID) where o.ElevID =" + Convert.ToInt32(Session["id"]) + "order by o.Data");
            GridView1.DataSource = dt2;
            GridView1.DataBind();

            DataTable dt3 = interogare(" select o.Data, o.TitlulLectiei as 'Titlul lectiei', p.Nume + ' ' + p.Prenume as 'Nume Profesor' from OraLegislatie o join EleviLegislatie e on (o.OraLegislatieID = e.OraLegislatieID) join Profesor p on ( o.ProfesorLegislatieID = p.ProfesorID) where e.ElevID = " + Convert.ToInt32(Session["id"]) + " order by o.Data");
            GridView2.DataSource = dt3;
            GridView2.DataBind();

            DataTable dt4 = interogare("  select distinct p.Nume +' '+ p.Prenume as Nume, p.DataExpriariiLicentei as 'Data Expriarii Licentei' from Profesor p join OraLegislatie o on (p.ProfesorID = o.ProfesorLegislatieID)  where o.OraLegislatieID in (select distinct el.OraLegislatieID from EleviLegislatie el where el.ElevID = " + Convert.ToInt32(Session["id"]) + ")");
            GridView3.DataSource = dt4;
            GridView3.DataBind();

            DataTable dt5 = interogare("select distinct i.Nume + ' ' + i.Prenume as Nume , i.DataExpriariiLicentei as 'Data Expriarii Licentei'  from Instructor i join OraCondus o on (i.InstructorID = o.InstructorAutoID) where ElevID = " + Convert.ToInt32(Session["id"]) );
            GridView4.DataSource = dt5;
            GridView4.DataBind();
        }

        
    }
}