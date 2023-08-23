using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace University
{
    public partial class FormInstructors : Form
    {
        public FormInstructors()
        {
            InitializeComponent();
        }

        sqlcont bgl = new sqlcont();

        void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from instructors", bgl.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void erase()
        {
            textID.Text = "";
            textNAME.Text = "";
            textSURNAME.Text = "";
            textMAIL.Text = "";
        }

        private void FormInstructors_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into instructors (insturctor_name,instructor_surname,instructor_mail) values(@p1,@p2,@p3)", bgl.connect());
            cmd.Parameters.AddWithValue("@p1", textNAME.Text);
            cmd.Parameters.AddWithValue("@p2", textSURNAME.Text);
            cmd.Parameters.AddWithValue("@p3", textMAIL.Text);
            cmd.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Instructor added", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textID.Text = dr["instructor_id"].ToString();
                textNAME.Text = dr["insturctor_name"].ToString();
                textSURNAME.Text = dr["instructor_surname"].ToString();
                textMAIL.Text = dr["instructor_mail"].ToString();
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update instructors set insturctor_name=@p1,instructor_surname=@p2,instructor_mail=@p3 where instructor_id=@p4",bgl.connect());
            cmd.Parameters.AddWithValue("@p1", textNAME.Text);
            cmd.Parameters.AddWithValue("@p2", textSURNAME.Text);
            cmd.Parameters.AddWithValue("@p3", textMAIL.Text);
            cmd.Parameters.AddWithValue("@p4", textID.Text);
            cmd.ExecuteNonQuery();
            bgl.connect().Close();
            list();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from instructors where instructor_id=@p1", bgl.connect());
            cmd.Parameters.AddWithValue("@p1", textID.Text);
            cmd.ExecuteNonQuery();
            bgl.connect().Close();
            list();
        }

        private void btnERASE_Click(object sender, EventArgs e)
        {
            erase();
        }
    }
}
