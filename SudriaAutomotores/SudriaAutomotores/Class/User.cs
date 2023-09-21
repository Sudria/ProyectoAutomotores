using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SudriaAutomotores.Class
{
    internal class User
    {
        private int UserId { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Dni { get; set; }
        private bool Sex { get; set; }
        private string Tel { get; set; }
        private string Birthdate { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private bool Active { get; set; }
        private int Rol { get; set; }

        private static Db db = new Db();
        


        public User() { }

        public User(string name, string surname, string dni, bool sex, string tel, string birthdate, string email, string password, int rol) 
        {
            Name = name;
            Surname = surname;
            Dni = dni;
            Sex = sex;
            Tel = tel;
            Birthdate = birthdate;
            Email = email;
            Password = password;
            Active = true;
            Rol = rol;
        }
        public User(int userid, string name, string surname, string dni, bool sex, string tel, string birthdate, string email, string password, int rol)
        {
            UserId = userid; 
            Name = name;
            Surname = surname;
            Dni = dni;
            Sex = sex;
            Tel = tel;
            Birthdate = birthdate;
            Email = email;
            Password = password;
            Active = true;
            Rol = rol;
        }

        public void GetUsers(DataGridView table)
        {
            try
            { 
                    string Query = "SELECT * FROM user";
                    table.DataSource = null;
                    MySqlDataAdapter Adapter = new MySqlDataAdapter(Query, db.startConnection());
                    DataTable dataTable = new DataTable();
                    Adapter.Fill(dataTable);
                    table.DataSource = dataTable;
                    db.endConnection();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo mostrar los datos");
            }
        }

        public void PutUser()
        {
                string Query = "INSERT INTO user (nombre, apellido, dni, sexo, fechaNac, email, contra, tel, activo, rol) " +
                "VALUES (@Nombre, @Apellido, @Dni, @Sexo, @FechaNac, @Email, @Contra, @Tel, @Activo, @Rol)";
                MySqlCommand Command = new MySqlCommand(Query, db.startConnection());

                // Agregar parámetros
                Command.Parameters.AddWithValue("@Nombre", this.Name);
                Command.Parameters.AddWithValue("@Apellido", this.Surname);
                Command.Parameters.AddWithValue("@Dni", this.Dni);
                Command.Parameters.AddWithValue("@Sexo", this.Sex);
                Command.Parameters.AddWithValue("@FechaNac", this.Birthdate);
                Command.Parameters.AddWithValue("@Email", this.Email);
                Command.Parameters.AddWithValue("@Contra", this.Password);
                Command.Parameters.AddWithValue("@Tel", this.Tel);
                Command.Parameters.AddWithValue("@Activo", this.Active);
                Command.Parameters.AddWithValue("@Rol", this.Rol);

                try
                {
                    // Ejecutar la consulta de inserción
                    int rowsAffected = Command.ExecuteNonQuery();

                    // Comprobar si la inserción fue exitosa
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Inserción exitosa.");
                    }
                    else
                    {
                        Console.WriteLine("La inserción no tuvo éxito.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar en la base de datos: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión
                    db.endConnection();
                }
            }

        public void ModifyUser()
        {
            string Query = "UPDATE user SET nombre = @Nombre, apellido = @Apellido, dni = @Dni, sexo = @Sexo, fechaNac = @FechaNac, email = @Email, contra = @Contra, tel = @Tel, rol = @Rol WHERE iduser = @Iduser";
            MySqlCommand Command = new MySqlCommand(Query, db.startConnection());

            // Agregar parámetros
            Command.Parameters.AddWithValue("@Iduser", this.UserId);
            Command.Parameters.AddWithValue("@Nombre", this.Name);
            Command.Parameters.AddWithValue("@Apellido", this.Surname);
            Command.Parameters.AddWithValue("@Dni", this.Dni);
            Command.Parameters.AddWithValue("@Sexo", this.Sex);
            Command.Parameters.AddWithValue("@FechaNac", this.Birthdate);
            Command.Parameters.AddWithValue("@Email", this.Email);
            Command.Parameters.AddWithValue("@Contra", this.Password);
            Command.Parameters.AddWithValue("@Tel", this.Tel);
            Command.Parameters.AddWithValue("@Activo", this.Active);
            Command.Parameters.AddWithValue("@Rol", this.Rol);

            try
            {
                // Ejecutar la consulta de inserción
                int rowsAffected = Command.ExecuteNonQuery();

                // Comprobar si la inserción fue exitosa
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Inserción exitosa.");
                }
                else
                {
                    Console.WriteLine("La inserción no tuvo éxito." );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la base de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                db.endConnection();
            }
        }


    }
}
