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
            string Name = TBNombre.Text  char.IsDigit;
            string Surname = TBApellido.Text;
            string Dni = TBDni.Text;
            bool Sex =  RBMale.Checked ? true : false ;
            string Tel = TBTel.Text;
            string Birthdate = date.Text;
            string Email = TBEmail.Text;
            string Password = TBPass.Text;
            int Rol = CBUser.SelectedIndex;

            Class.User user1 = new Class.User(Name, Surname, Dni, Sex, Tel, Birthdate, Email, Password, Rol + 1);
            user1.PutUser();
            user1.GetUsers(DGUser);

        }
    }
}
