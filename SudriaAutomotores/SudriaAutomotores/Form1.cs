using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            string Name = TBNombre.Text;
            string Surname = TBApellido.Text;
            string Email = TBEmail.Text;
            string Dni = TBDni.Text;
            string Tel = TBTel.Text;
            bool Sex = RBMale.Checked ? true : false;
            string Birthdate = date.Text;
            string Password = TBPass.Text;
            int Rol = CBUser.SelectedIndex;

            if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Surname))
                {
                if (IsValidNumDni(Dni))
                {
                    if (IsValidEmail(Email))
                    {
                        if (IsValidPhoneNumber(Tel))
                        {
                            if (this.TBPass.Text.Equals(this.TBRepeatP.Text))
                            {
                                Class.User user1 = new Class.User(Name, Surname, Dni, Sex, Tel, Birthdate, Email, Password, Rol + 1);
                                user1.PutUser();
                                user1.GetUsers(DGUser);
                                MessageBox.Show("Datos guardados exitosamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El número de teléfono no es válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La dirección de correo electrónico no es válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Los datos ingresados en DNI no son válidos o no tienen 8 caracteres numéricos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos nombre y/o apellido no pueden estar vacíos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private bool IsValidEmail(string email)
        {
            // Utilizamos una expresión regular para validar el formato del correo electrónico.
            // Esta expresión regular es una simplificación y no cubre todos los casos posibles,
            // pero funciona para la mayoría de las direcciones de correo electrónico comunes.
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            
            return regex.IsMatch(email);
        }
        private bool IsValidNumDni(string Dni)
        {
            //Para el DNI
            // Verificar si la cadena es numérica y tiene exactamente 8 caracteres.
            if (Dni.Length == 8 && int.TryParse(Dni, out _))
            {
                return true;
            }
            return false;
        }
        private bool IsValidPhoneNumber(string Tel)
        {
            // Utilizamos una expresión regular para validar el formato del número de teléfono.
            string pattern = @"^\d{10}$"; // Asume un número de 10 dígitos

            Regex regex = new Regex(pattern);

            return regex.IsMatch(Tel);
        }
    }
}