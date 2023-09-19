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
        public Form1()
        {

            InitializeComponent();
            Class.User user = new Class.User();
            user.GetUsers(DGUser);
            CBUser.SelectedIndex = 0;

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Class.Db db = new Class.Db();
            db.startConnection();
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
                    string Birthdate = date.Text;
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
    }
}