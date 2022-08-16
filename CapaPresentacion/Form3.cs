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
using CapaDatos;

namespace CapaPresentacion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server=DESKTOP-2V27RAM;DataBase=SellPointFinal;Integrated security=true");

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            String userUsername = userTextBox.Text;
            String userPassword = pwdTextBox.Text;

            try
            {
                String query = "SELECT UserNameEntidad, PassworEntidad FROM Entidades WHERE UserNameEntidad = '" + userUsername + "' AND PassworEntidad = '" + userPassword + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    userUsername = userTextBox.Text;
                    userPassword = pwdTextBox.Text;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userTextBox.Clear();
                    pwdTextBox.Clear();

                    userTextBox.Focus();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("Error"+ err);
            }
            finally
            {
                conn.Close();
            }



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userTextBox.Clear();
            pwdTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
          Application.Exit();  
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
