using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleToDoList
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=RYMATIC;Initial Catalog=STDL;Integrated Security=True;");
        string smain = "SELECT * FROM Main";
        string simp= "SELECT * FROM Main WHERE imp=1";
        string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/PhamTrungDung213",
                    UseShellExecute = true
                });
            }
            catch
            {
            }
        }

        public void loadData(string a)
        {
            try
            {
                conn.Open();
                //dung adapter de dien du lieu vao datatable
                SqlDataAdapter adapter = new SqlDataAdapter(a, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                dtSQL.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load sql: " + ex.Message);
            }
        }

        public int data(string sql)
        {
            int i = -1;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi doc lenh!");
                i = -1;
            }
            finally
            {
                conn.Close();
            }
            return i;
        }

        public void clear()
        {
            txtAdd.Text = "";
            dtAdd.Text = DateTime.Now.ToString();
            cbImp.Checked = false;
        }

        public void disable()
        { 
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnUp.Enabled = false;
        }

        public void enable()
        {
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnUp.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData(smain);
            clear();
            disable();
        }

        private void dtSQL_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i=e.RowIndex;
            a= dtSQL.Rows[i].Cells["id"].Value.ToString();
            txtAdd.Text = dtSQL.Rows[i].Cells["note"].Value.ToString();
            dtAdd.Text = dtSQL.Rows[i].Cells["dl"].Value.ToString();
            string ch=dtSQL.Rows[i].Cells["imp"].Value.ToString();
            if(ch == "True"){
                cbImp.Checked = true;
            }
            else
            {
                cbImp.Checked = false;
            }
            enable();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            loadData(smain);
            clear();
            disable();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            loadData(simp);
            clear();
            disable();
        }

        //CRUD:
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nt= txtAdd.Text;
            string ng=dtAdd.Value.ToString("yyyy-MM-dd");
            int im= cbImp.Checked ? 1 : 0;
            string sql = "INSERT INTO Main(note, dl, imp) VALUES(N'" + nt + "', '" + ng + "', " + im + ")";
            int k = data(sql);
            if (k > 0)
            {
                MessageBox.Show("Thêm thành công!","Notice!",MessageBoxButtons.OK);
                loadData(smain);
                clear();
                disable();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Notice!", MessageBoxButtons.OK);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Main WHERE id=" + a;
            int k = data(sql);
            if (k > 0)
            {
                MessageBox.Show("Xóa thành công!", "Notice!", MessageBoxButtons.OK);
                loadData(smain);
                clear();
                disable();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Notice!", MessageBoxButtons.OK);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string nt = txtAdd.Text;
            string ng = dtAdd.Value.ToString("yyyy-MM-dd");
            int im = cbImp.Checked ? 1 : 0;
            string sql = "UPDATE Main SET note=N'" + nt + "', dl='" + ng + "', imp=" + im + " WHERE id=" + a;
            int k = data(sql);
            if (k > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Notice!", MessageBoxButtons.OK);
                loadData(smain);
                clear();
                disable();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Notice!", MessageBoxButtons.OK);
            }
        }

        //Search:
        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //dung adapter de dien du lieu vao datatable
                string sql="SELECT * FROM Main WHERE note LIKE '%" + txtSearch.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                dtSQL.DataSource = dt;
                clear();
                disable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tim kiem: " + ex.Message);
            }
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = txtAdd.TextLength > 0;
        }
    }
}
