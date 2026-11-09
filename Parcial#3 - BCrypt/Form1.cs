using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_3___BCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            bool accesoExitoso = false;
            string storedHash = "";

            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    // 1. Buscar el hash del usuario
                    string querySelect = "SELECT PasswordHash FROM Usuarios WHERE Usuario = @usuario";
                    MySqlCommand cmdSelect = new MySqlCommand(querySelect, conn);
                    cmdSelect.Parameters.AddWithValue("@usuario", usuario);

                    object result = cmdSelect.ExecuteScalar();

                    if (result != null)
                    {
                        storedHash = result.ToString();

                        // 2. Verificar la contraseña original utilizando BCrypt.Verify()
                        if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                        {
                            accesoExitoso = true;
                        }
                    }

                    // 3. Guardar el intento (exitoso o fallido) en la base de datos
                    RegistrarIntento(conn, usuario, accesoExitoso);

                    // 4. Mostrar el resultado
                    if (accesoExitoso)
                    {
                        // Indica el nombre del usuario al tener acceso exitoso
                        MessageBox.Show($"¡Acceso Exitoso! Bienvenido {usuario}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Llene los campos de usuario y contraseña.");
                return;
            }

            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    // Genera el hash de la contraseña usando BCrypt
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

                    string query = "INSERT INTO Usuarios (Usuario, PasswordHash) VALUES (@usuario, @hash)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@hash", passwordHash);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado con su Hash de BCrypt exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        // Método auxiliar para guardar en la tabla de bitácora
        private void RegistrarIntento(MySqlConnection conn, string usuario, bool exitoso)
        {
            string queryLog = "INSERT INTO IntentosLogin (Usuario, Exitoso) VALUES (@usuario, @exitoso)";
            MySqlCommand cmdLog = new MySqlCommand(queryLog, conn);

            // Si el campo usuario está vacío, registramos "Desconocido" para no romper la BD
            cmdLog.Parameters.AddWithValue("@usuario", string.IsNullOrWhiteSpace(usuario) ? "Desconocido" : usuario);
            cmdLog.Parameters.AddWithValue("@exitoso", exitoso); // MySQL convierte true a 1 y false a 0

            cmdLog.ExecuteNonQuery();
        }
    }
}
