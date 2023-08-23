using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace University
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        sqlcont cnt = new sqlcont();

        private void FormStudent_Load(object sender, EventArgs e)
        {
            list();
        }

        void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from student", cnt.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void erase()
        {
            textID2.Text = "";
            textNAME2.Text = "";
            textSURNAME2.Text = "";
            textMAIL2.Text = "";
        }

        private void btnSAVE2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into student (student_name,student_surname,student_dept) values(@p1,@p2,@p3)", cnt.connect());
            cmd.Parameters.AddWithValue("@p1", textNAME2.Text);
            cmd.Parameters.AddWithValue("@p2", textSURNAME2.Text);
            cmd.Parameters.AddWithValue("@p3", textMAIL2.Text);
            cmd.ExecuteNonQuery();
            cnt.connect().Close();
            MessageBox.Show("Student added","info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void btnUPDATE2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update student set student_name=@p1,student_surname=@p2,student_dept=@p3 where student_id=@p4", cnt.connect());
            cmd.Parameters.AddWithValue("@p1", textNAME2.Text);
            cmd.Parameters.AddWithValue("@p2", textSURNAME2.Text);
            cmd.Parameters.AddWithValue("@p3", textMAIL2.Text);
            cmd.Parameters.AddWithValue("@p4", textID2.Text);
            cmd.ExecuteNonQuery();
            cnt.connect().Close();
            MessageBox.Show("Student updated","info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void btnDELETE2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from student where student_id=@p1", cnt.connect());
            cmd.Parameters.AddWithValue("@p1", textID2.Text);
            cmd.ExecuteNonQuery();
            cnt.connect().Close();
            list();
        }

        private void btnERASE2_Click(object sender, EventArgs e)
        {
            erase();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textID2.Text = dr["student_id"].ToString();
                textNAME2.Text = dr["student_name"].ToString();
                textSURNAME2.Text = dr["student_surname"].ToString();
                textMAIL2.Text = dr["student_dept"].ToString();
            }
        }
    }
}
