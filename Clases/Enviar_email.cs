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
        internal SqlConnectiondb.DatabaseHelper DatabaseHelper
        {
            get => default;
            set
            {
            }
        }

        public static string EnviarCorreo(string email)
        {
            try
            {

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {

                    Credentials = new NetworkCredential("johanstevenfrancoalvarez54@gmail.com", "kptz tpcl ldwl yyba"),
                    EnableSsl = true
                };


                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("johanstevenfrancoalvarez54@gmail.com"),
                    Subject = "Servicio de soporte Port manager",
                    Body = "¡Hola! , Esta es su contraseña temporal : qwfwecwer@_q113",
                    IsBodyHtml = false // Cambia a true si el contenido es HTML
                };


                mail.To.Add(email);

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

    }
}
