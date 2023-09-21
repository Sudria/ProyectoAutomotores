using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudriaAutomotores
{
    public partial class Form1 : Form
    {
        int IdUser;
        public Form1()
        {
            InitializeComponent();
            Class.User user = new Class.User();
            user.GetUsers(DGUser);
            CBUser.SelectedIndex = 0;

        }
        private void BAdd_Click(object sender, EventArgs e)
        {

            if (TBDni.TextLength == 8)
            {
                if (this.TBPass.Text.Equals(this.TBRepeatP.Text))
                {
                    string Name = TBNombre.Text;
                    string Surname = TBApellido.Text;
                    string Dni = TBDni.Text;
                    bool Sex = RBMale.Checked ? true : false;
                    string Tel = TBTel.Text;
                    string Birthdate = Date.Text;
                    string Email = TBEmail.Text;
                    string Password = TBPass.Text;
                    int Rol = CBUser.SelectedIndex;

                    Class.User user1 = new Class.User(Name, Surname, Dni, Sex, Tel, Birthdate, Email, Password, Rol + 1);
                    user1.PutUser();
                    user1.GetUsers(DGUser);
                    MessageBox.Show("Datos guardados exitosamente");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Cantidad de caracteres no valida en DNI");
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que funcione el backspace(delete)
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //mostrar alerta de datos incorrectos
            else
            {
                e.Handled = true;
                MessageBox.Show("Sólo se admiten letras", "Atención",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que funcione el backspace(delete)
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //mostrar alerta de datos incorrectos
            else
            {
                e.Handled = true;
                MessageBox.Show("Sólo se admiten letras", "Atención",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que funcione el backspace(delete)
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Sólo se admiten datos numéricos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BMod_Click(object sender, EventArgs e)
        {
            string Name = TBNombre.Text;
            string Surname = TBApellido.Text;
            string Dni = TBDni.Text;
            bool Sex = RBMale.Checked ? true : false;
            string Tel = TBTel.Text;
            string Birthdate = Date.Text;
            string Email = TBEmail.Text;
            string Password = TBPass.Text;
            int Rol = CBUser.SelectedIndex;

            Class.User user1 = new Class.User(IdUser,Name, Surname, Dni, Sex, Tel, Birthdate, Email, Password, Rol + 1);
            user1.ModifyUser();
            user1.GetUsers(DGUser);

        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void DGUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdUser = int.Parse(DGUser.CurrentRow.Cells[0].Value.ToString());
            TBNombre.Text = DGUser.CurrentRow.Cells[1].Value.ToString();
            TBApellido.Text = DGUser.CurrentRow.Cells[2].Value.ToString();
            if(DGUser.CurrentRow.Cells[3].Value.ToString().Equals("1"))
            {
                RBMale.Checked = true;
                RBFemale.Checked = false;
            }
            else {
                RBMale.Checked = false;
                RBFemale.Checked = true;
            }
            TBPass.Text = "";
            TBRepeatP.Text = "";
            Date.Text = DGUser.CurrentRow.Cells[4].Value.ToString();
            TBDni.Text = DGUser.CurrentRow.Cells[5].Value.ToString();
            TBEmail.Text = DGUser.CurrentRow.Cells[6].Value.ToString();
            TBTel.Text = DGUser.CurrentRow.Cells[8].Value.ToString();
            CBUser.SelectedIndex = int.Parse(DGUser.CurrentRow.Cells[10].Value.ToString()) - 1;
        }

      
    }
}