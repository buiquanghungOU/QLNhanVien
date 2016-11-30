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
using System.Configuration;

namespace BTBuoi6
{
    public partial class Form1 : Form
    {
        string cnStr = "";
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                    cn.Open();
                /*if (cn.State == ConnectionState.Open)
                   MessageBox.Show("Ket noi thanh cong", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void DisConnect()
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }

        public List<Employee> GetEmployee(string sql)
        {
            Connect();
            List<Employee> list = new List<Employee>();
            try
            {
                //string sql = "SELECT * FROM Nhanvien";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                int id;
                string lastName, firstName, address, phone;
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    lastName = dr.GetString(1);
                    firstName = dr.GetString(2);
                    address = dr.GetString(3);
                    phone = dr.GetString(4);
                    Employee nv = new Employee(id, lastName, firstName, address, phone);
                    list.Add(nv);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DisConnect();
            }
            return list;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Nhanvien WHERE ";
            if (rbtTimTheoMa.Checked == true)
                sql += "MaNV = " + txtNhap.Text;
            else if (rbtTimTheoHo.Checked == true)
                sql += "HoNV LIKE '%" + txtNhap.Text + "%'";
            else 
                sql += "Ten LIKE '%" + txtNhap.Text + "%'";
            
            dgvNhanVien.DataSource = GetEmployee(sql);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
        }
    }
}
