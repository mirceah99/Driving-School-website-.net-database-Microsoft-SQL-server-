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

    


    public partial class Admin_page_0 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (1 != Convert.ToInt32(Session["sesiune"]))
                {
                    Response.Redirect("Pagina1");
                    
                }
            }
            catch
            {
                Response.Redirect("Pagina1");
            }
            Panel1.Visible = false;
            Panel2.Visible = false;
            InfoMesage.Visible = false;
            PanelStergeElevi.Visible = false;
            StergeInstructorPopUp.Visible = false;
            PanelUpdateIstructor.Visible = false;
            Panel5.Visible = false;
           
           

        }

        public DataTable interogare(string query )

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            
            InfoMesage.Visible = false;
            Label1.Text = "Date Instructor";
        }

        protected void AnuleazaInstructor_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }

        protected void AdaugaInstructor_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                try
                {
                    sqlCon.Open();
                    string completare = "";
                    if (Label1.Text == "Date Instructor") {  completare = "INSERT INTO Instructor VALUES('"; }
                    if (Label1.Text == "Date Profesor") {completare= "INSERT INTO Profesor VALUES('"; }
                        string query =  completare + NumeInstructor.Text + "' , '" + PrenumeInstructor.Text + "'" + ", '" + ExpirareInstructor.Text + "' , '" + CategorieInstructor.Text + "' , " + SalariuInstructor.Text + ", '" + CNPInstructor.Text + "')";
                    

                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                    //InfoMesage.Text = query;
                    DataTable dt = new DataTable();
                    //int raspuns = new int();

                    sda.Fill(dt);
                    //raspuns = Convert.ToInt32(dt.Rows[0][0]);
                    //Info.Text = Convert.ToString(dt.Rows[0][0]);
                    InfoMesage.Text = "Operatiune realizata cu succes!";
                    InfoMesage.BackColor = System.Drawing.Color.Green;

                    InfoMesage.Visible = true;
                }
                catch {
                    InfoMesage.Text = "Operatie esuata! Te rog verifica datele iar!";
                    InfoMesage.BackColor = System.Drawing.Color.Red;
                    InfoMesage.Visible = true;

                }
            }
            

        }

        protected void AdProfesor_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            InfoMesage.Visible = false;
            Label1.Text = "Date Profesor";
        }

        protected void AdElev_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                try
                {


                    //UMPLEREA LISTE DE INSTRUCTORI 


                    sqlCon.Open();
                    // aici este interogare pentru a vedea cine sunt insturcorii disponibili
                    string query = "select i.Nume +' '+ i.Prenume as NumeComplet, i.InstructorID as id from Instructor i ORDER BY NumeComplet";


                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                    
                    DataTable dt = new DataTable(); // acesta este raspunsul interogarii
                    
                    
                    sda.Fill(dt);
                    
                    NumeInstructorElev.DataSource = dt ; // atribuim raspunsul drop down list ului
                    NumeInstructorElev.DataTextField = "NumeComplet"; // ii spunem sa afiseze coloane nume complet 
                    NumeInstructorElev.DataValueField = "id";
                    NumeInstructorElev.DataBind();


                    //UMPLEREA LISTE DE PROFESORI


                    //sqlCon.Open();
                    // aici este interogare pentru a vedea cine sunt insturcorii disponibili
                    string query2 = "select p.Nume + ' ' + p.Prenume as NumeCompletProf, p.ProfesorID as id from Profesor p ORDER BY NumeCompletProf ";


                    SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                    SqlDataAdapter sda2 = new SqlDataAdapter(sqlCmd2);

                    DataTable dt2 = new DataTable(); // acesta este raspunsul interogarii


                    sda2.Fill(dt2);

                    ProfesorLegislatieElev.DataSource = dt2; // atribuim raspunsul drop down list ului
                    ProfesorLegislatieElev.DataTextField = "NumeCompletProf"; // ii spunem sa afiseze coloane nume complet 
                    ProfesorLegislatieElev.DataValueField = "id";
                    ProfesorLegislatieElev.DataBind();

                }
                catch
                {


                }
            }

        }

        protected void AdaugaElevGrid_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                try
                {
                    sqlCon.Open();
                    
                    string query = "INSERT INTO Elevi VALUES('" + NumeElev.Text + "' , '" + PrenumeElev.Text + "'" + ", '" + CnpElev.Text + "' , '" + TelefonElev.Text + "' , '" + CategorieElev.Text + "' , '" + SumaPlatitaElev.Text + "' , "+ NumeInstructorElev.SelectedValue + " , '" + DataScolarizarii.Text + "' , " +ProfesorLegislatieElev.SelectedValue+ " )" ;
                    

                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                    //InfoMesage.Text = query;
                    DataTable dt = new DataTable();
                    //int raspuns = new int();

                    sda.Fill(dt);
                    //raspuns = Convert.ToInt32(dt.Rows[0][0]);
                    //Info.Text = Convert.ToString(dt.Rows[0][0]);
                    InfoMesage.Text = "Operatiune realizata cu succes!";
                    InfoMesage.BackColor = System.Drawing.Color.Green;

                    InfoMesage.Visible = true;
                }
                catch
                {
                    InfoMesage.Text = "Operatie esuata! Te rog verifica datele iar!"  ;
                    InfoMesage.BackColor = System.Drawing.Color.Red;
                    InfoMesage.Visible = true;

                }
            }
        }

        protected void StergeInstuctor_Click(object sender, EventArgs e)
        {
            InfoMesage.Visible = false;
            StergeInstructorPopUp.Visible = true;
            StergeLabel.Text = "Sterge Instructor";
            Label13.Text = "Numele instructorului care va fi sters";

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                try
                {

                    //UMPLEREA LISTE DE INSTRUCTORI 

                    sqlCon.Open();
                    // aici este interogare pentru a vedea cine sunt insturcorii disponibili
                    string query = "select i.Nume +' '+ i.Prenume as NumeComplet, i.InstructorID as id from Instructor i ORDER BY NumeComplet";

                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);

                    DataTable dt = new DataTable(); // acesta este raspunsul interogarii

                    sda.Fill(dt);

                    ListaInstructoriStergere.DataSource = dt; // atribuim raspunsul drop down list ului
                    ListaInstructoriStergere.DataTextField = "NumeComplet"; // ii spunem sa afiseze coloane nume complet 
                    ListaInstructoriStergere.DataValueField = "id";
                    ListaInstructoriStergere.DataBind();


                    
                }
                catch
                {


                }
            }


        }

        protected void AnuleazaStergeInstructor_Click(object sender, EventArgs e)
        {
            StergeInstructorPopUp.Visible = false;

        }

        protected void StergeInstructorGrid_Click(object sender, EventArgs e)
        {
            if (StergeLabel.Text == "Sterge Instructor")
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
                {
                    try
                    {
                        sqlCon.Open();

                        string query = "update Elevi  set InstructorID = null where InstructorID = " + ListaInstructoriStergere.SelectedValue + "  delete from Instructor where InstructorID = " + ListaInstructoriStergere.SelectedValue;


                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                        //InfoMesage.Text = query;
                        DataTable dt = new DataTable();
                        //int raspuns = new int();

                        sda.Fill(dt);
                        //raspuns = Convert.ToInt32(dt.Rows[0][0]);
                        //Info.Text = Convert.ToString(dt.Rows[0][0]);
                        InfoMesage.Text = "Operatiune realizata cu succes!";

                        InfoMesage.BackColor = System.Drawing.Color.Green;

                        InfoMesage.Visible = true;
                    }
                    catch
                    {
                        InfoMesage.Text = "Operatie esuata! Te rog verifica datele iar!";
                        InfoMesage.BackColor = System.Drawing.Color.Red;
                        InfoMesage.Visible = true;

                    }
                }
            }
            if (StergeLabel.Text == "Sterge Profesor")
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
                {
                    try
                    {
                        sqlCon.Open();

                        string query = "update Elevi  set ProfesorID= null where ProfesorID =  " + ListaInstructoriStergere.SelectedValue + "  delete from Profesor where ProfesorID = " + ListaInstructoriStergere.SelectedValue;


                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                        //InfoMesage.Text = query;
                        DataTable dt = new DataTable();
                        //int raspuns = new int();

                        sda.Fill(dt);
                        //raspuns = Convert.ToInt32(dt.Rows[0][0]);
                        //Info.Text = Convert.ToString(dt.Rows[0][0]);
                        InfoMesage.Text = "Operatiune realizata cu succes!";

                        InfoMesage.BackColor = System.Drawing.Color.Green;

                        InfoMesage.Visible = true;
                    }
                    catch
                    {
                        InfoMesage.Text = "Operatie esuata! Te rog verifica datele iar!";
                        InfoMesage.BackColor = System.Drawing.Color.Red;
                        InfoMesage.Visible = true;

                    }
                }
            }
        }

        protected void Buton1StergeProfesor_Click(object sender, EventArgs e)
        {
            StergeLabel.Text = "Sterge Profesor";
            InfoMesage.Visible = false;
            StergeInstructorPopUp.Visible = true;
            
            Label13.Text = "Numele profesorului care va fi sters";

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                try
                {

                    //UMPLEREA LISTE DE INSTRUCTORI 

                    sqlCon.Open();
                    // aici este interogare pentru a vedea cine sunt insturcorii disponibili
                    string query = "select p.Nume +' '+ p.Prenume as NumeComplet, p.ProfesorID as id from Profesor p ORDER BY NumeComplet";

                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);

                    DataTable dt = new DataTable(); // acesta este raspunsul interogarii

                    sda.Fill(dt);

                    ListaInstructoriStergere.DataSource = dt; // atribuim raspunsul drop down list ului
                    ListaInstructoriStergere.DataTextField = "NumeComplet"; // ii spunem sa afiseze coloane nume complet 
                    ListaInstructoriStergere.DataValueField = "id";
                    ListaInstructoriStergere.DataBind();



                }
                catch
                {


                }
            }

            
        }

        protected void StergeElevB1_Click(object sender, EventArgs e)
        {
            InfoMesage.Visible = false;
            PanelStergeElevi.Visible = true;
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                try
                {

                    //UMPLEREA LISTE DE INSTRUCTORI 

                    sqlCon.Open();
                    // aici este interogare pentru a vedea cine sunt insturcorii disponibili
                    string query = "select e.Nume +' '+ e.Prenume + ' (' + e.CNP +')' as NumeComplet, e.ElevID as id from Elevi e ORDER BY NumeComplet";

                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);

                    DataTable dt = new DataTable(); // acesta este raspunsul interogarii

                    sda.Fill(dt);

                    ListaElevi.DataSource = dt; // atribuim raspunsul drop down list ului
                    ListaElevi.DataTextField = "NumeComplet"; // ii spunem sa afiseze coloane nume complet 
                    ListaElevi.DataValueField = "id";
                    ListaElevi.DataBind();



                }
                catch
                {


                }
            }


        }

        protected void AnuleazaStergeElevi_Click(object sender, EventArgs e)
        {
            PanelStergeElevi.Visible = false; 

        }

        protected void StergeElevB2_Click(object sender, EventArgs e)
        {
            try
            {
                interogare("delete from Elevi where ElevID = " + ListaElevi.SelectedValue);
                InfoMesage.Text = "Operatiune realizata cu succes!";
                InfoMesage.BackColor = System.Drawing.Color.Green;
                InfoMesage.Visible = true;

            }
            catch
            {
                InfoMesage.Text = "Operatie esuata! Te rog verifica datele iar!";
                InfoMesage.BackColor = System.Drawing.Color.Red;
                InfoMesage.Visible = true;


            }

        }

        protected void UpdateInstructorB1_Click(object sender, EventArgs e)
        {   
            Label16.Text = "Update Instructor";
            Label18.Text = "Alege Instructorul";
            PanelUpdateIstructor.Visible = true;
            InfoMesage.Visible = false;
            ValoareaActualaInstructor.Text = "";

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                try
                {

                    //UMPLEREA LISTE DE INSTRUCTORI 

                    sqlCon.Open();
                    // aici este interogare pentru a vedea cine sunt insturcorii disponibili
                    string query = "select i.Nume +' '+ i.Prenume as NumeComplet, i.InstructorID as id from Instructor i ORDER BY NumeComplet";

                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);

                    DataTable dt = new DataTable(); // acesta este raspunsul interogarii

                    sda.Fill(dt);

                    ListaInstructoriUpdateInstructor.DataSource = dt; // atribuim raspunsul drop down list ului
                    ListaInstructoriUpdateInstructor.DataTextField = "NumeComplet"; // ii spunem sa afiseze coloane nume complet 
                    ListaInstructoriUpdateInstructor.DataValueField = "id";
                    ListaInstructoriUpdateInstructor.DataBind();



                }
                catch
                {
                   

                }
            }



        }

        protected void AfiseazaValActualUpdateInstructor_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (Label16.Text == "Update Instructor")
                dt =  interogare("select " + DropDownList2.SelectedValue + " from Instructor " + "where InstructorID = " + ListaInstructoriUpdateInstructor.SelectedValue);
            if (Label16.Text == "Update profesor")
                dt = interogare("select " + DropDownList2.SelectedValue + " from Profesor " + "where ProfesorID = " + ListaInstructoriUpdateInstructor.SelectedValue);

            ValoareaActualaInstructor.Text = Convert.ToString(dt.Rows[0][0]);
            PanelUpdateIstructor.Visible = true;
            
        }

        protected void ModificaInstructor_Click(object sender, EventArgs e)
        {
            try
            {
               // InfoMesage.Text = "update Instructor set " + DropDownList2.SelectedValue + " = '" + UpdateInstructorTextBox.Text + "' where InstructorID = " + DropDownList2.SelectedValue;
               if(Label16.Text == "Update Instructor")
                interogare("update Instructor set " + DropDownList2.SelectedValue + " = '" + UpdateInstructorTextBox.Text + "' where InstructorID = " + ListaInstructoriUpdateInstructor.SelectedValue);
               if(Label16.Text == "Update profesor")
                    interogare("update Profesor set " + DropDownList2.SelectedValue + " = '" + UpdateInstructorTextBox.Text + "' where ProfesorID = " + ListaInstructoriUpdateInstructor.SelectedValue);


                InfoMesage.Text = "Operatiune realizata cu succes!";
                InfoMesage.BackColor = System.Drawing.Color.Green;
                InfoMesage.Visible = true;

            }
            catch
            {
                InfoMesage.Text = "Operatie esuata! Te rog verifica datele iar!";
                InfoMesage.BackColor = System.Drawing.Color.Red;
                InfoMesage.Visible = true;


            }
             



        }

        protected void UpdateProfsorB1_Click(object sender, EventArgs e)
        {
            Label16.Text = "Update profesor";
            Label18.Text = "Alege profesorul";
            PanelUpdateIstructor.Visible = true;
            InfoMesage.Visible = false;
            ValoareaActualaInstructor.Text = "";

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                try
                {

                    //UMPLEREA LISTE DE INSTRUCTORI 

                    sqlCon.Open();
                    // aici este interogare pentru a vedea cine sunt insturcorii disponibili
                    string query = "select p.Nume +' '+ p.Prenume as NumeComplet, p.ProfesorID as id from Profesor p ORDER BY NumeComplet";

                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);

                    DataTable dt = new DataTable(); // acesta este raspunsul interogarii

                    sda.Fill(dt);

                    ListaInstructoriUpdateInstructor.DataSource = dt; // atribuim raspunsul drop down list ului
                    ListaInstructoriUpdateInstructor.DataTextField = "NumeComplet"; // ii spunem sa afiseze coloane nume complet 
                    ListaInstructoriUpdateInstructor.DataValueField = "id";
                    ListaInstructoriUpdateInstructor.DataBind();



                }
                catch
                {


                }
            }
        }

        protected void AnuleazaUpdateInstructor_Click(object sender, EventArgs e)
        {

        }

        protected void UpdateElevB1_Click(object sender, EventArgs e)
        {
            Panel5.Visible = true;
            using(SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-OV0JI2B\SQLEXPRESS;Initial Catalog=Scoala_De_Soferi;Integrated Security=True"))
            {
                try
                {

                    //UMPLEREA LISTE DE INSTRUCTORI 

                    sqlCon.Open();
                    // aici este interogare pentru a vedea cine sunt insturcorii disponibili
                    string query = "select e.Nume +' '+ e.Prenume + ' (' + e.CNP +')' as NumeComplet, e.ElevID as id from Elevi e ORDER BY NumeComplet";

                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);

                    DataTable dt = new DataTable(); // acesta este raspunsul interogarii

                    sda.Fill(dt);

                    ListaElevi2.DataSource = dt; // atribuim raspunsul drop down list ului
                    ListaElevi2.DataTextField = "NumeComplet"; // ii spunem sa afiseze coloane nume complet 
                    ListaElevi2.DataValueField = "id";
                    ListaElevi2.DataBind();



                }
                catch
                {


                }


            }
        }

        protected void ValCurentElev_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (DropDownList3.SelectedValue != "Instructor" && DropDownList3.SelectedValue != "Profesor")
            {
                
                dt = interogare("select " + DropDownList3.SelectedValue + " from Elevi " + "where ElevID = " + ListaElevi2.SelectedValue);                
            }
            if (DropDownList3.SelectedValue == "Instructor")
            {
                dt = interogare("select i.Nume +' '+ i.Prenume from Instructor i join elevi e on e.InstructorID = i.InstructorID where e.ElevID =" + ListaElevi2.SelectedValue);
               // TextBox1.Text = ("select i.Nume +' '+ i.Prenume from Instructor i join elevi e on e.InstructorID = i.InstructorID where e.ElevID =" + ListaElevi2.SelectedValue);
            }
            if (DropDownList3.SelectedValue == "Profesor")
                dt = interogare("select p.Nume +' '+ p.Prenume from Profesor p join elevi e on e.ProfesorID = p.ProfesorID where e.ElevID ="+ ListaElevi2.SelectedValue);

          
            Label20.Text = Convert.ToString(dt.Rows[0][0]);
            Panel5.Visible = true;
        }

        protected void ModificaElev_Click(object sender, EventArgs e)
        {
            try 
            
            {
                if (DropDownList3.SelectedValue != "Instructor" && DropDownList3.SelectedValue != "Profesor")
                {
                    interogare("UPDATE Elevi set " + DropDownList3.SelectedValue + " = '" + TextBox1.Text + "' where ElevID =" + ListaElevi2.SelectedValue);
                   // TextBox1.Text = ("UPDATE Elevi set " + DropDownList3.SelectedValue + " = '" + TextBox1.Text + "' where ElevID =" + ListaElevi2.SelectedValue);
                }
                if (DropDownList3.SelectedValue == "Instructor")
                {
                    interogare("UPDATE Elevi SET InstructorID = (select top 1 InstructorID from Instructor where (Nume + ' ' + Prenume) = '" + TextBox1.Text + "') where ElevID =" + ListaElevi2.SelectedValue);

                }
                if (DropDownList3.SelectedValue == "Profesor")
                    interogare("UPDATE Elevi SET ProfesorID = (select top 1 ProfesorID from Profesor where (Nume + ' ' + Prenume) = '" + TextBox1.Text + "') where ElevID =" + ListaElevi2.SelectedValue);

                InfoMesage.Text = "Operatiune realizata cu succes!";
                InfoMesage.BackColor = System.Drawing.Color.Green;
                InfoMesage.Visible = true;



            }
            catch
            {
                InfoMesage.Text = "Operatie esuata! Te rog verifica datele iar!";
                InfoMesage.BackColor = System.Drawing.Color.Red;
                InfoMesage.Visible = true;




            }


        }

        protected void Statistici_Click(object sender, EventArgs e)
        {
            Response.Redirect("Statistici.aspx");
        }
    }
        
}