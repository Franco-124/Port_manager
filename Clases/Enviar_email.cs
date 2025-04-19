using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Port_manager.Clases
{
    class Enviar_email
    {

        public static string EnviarCorreo(string Email, string Temp_password)
        {
            try
            {

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {

                    Credentials = new NetworkCredential("johanstevenfrancoalvarez54@gmail.com", Credentials.contraseña),
                    EnableSsl = true
                };


                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("johanstevenfrancoalvarez54@gmail.com"),
                    Subject = "Servicio de soporte Port manager",
                    Body =
                    "¡Hola  😊!\n\n" +
                    "Esta es su contraseña temporal: **" + Temp_password + "**\n\n" +
                    "Por favor, utilice esta contraseña únicamente para iniciar sesión de forma temporal. " +
                    "Una vez haya ingresado al sistema, diríjase al apartado de \"Cambiar contraseña\" para actualizarla.\n\n" +
                    "Gracias.  😁",
                    IsBodyHtml = false // Cambia a true si el contenido es HTML
                };


                mail.To.Add(Email);

                // Enviar el correo
                smtpClient.Send(mail);
                Console.WriteLine("Correo enviado con éxito.");
                return "correcto";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
                return "error";
            }
        }

    

    public static string GenerarContraseñaTemporal()
        {
            // Genera una contraseña temporal aleatoria
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] contraseña = new char[8];
            for (int i = 0; i < contraseña.Length; i++)
            {
                contraseña[i] = caracteres[random.Next(caracteres.Length)];
            }
            return new string(contraseña);
        }
    }
}
