using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Port_manager.Clases
{
    class Enviar_email
    {
        static void Main(string[] args)
        {
            try
            {
               
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, 
                    Credentials = new NetworkCredential("johanstevenfrancoalvarez54@gmail.com", Credentials.contraseña),
                    EnableSsl = true,
                    UseDefaultCredentials = false
                };

                
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("johanstevenfrancoalvarez54@gmail.com");
                    mail.To.Add(UsuarioSesion.email);
                    mail.Subject = "Correo de prueba desde C#";
                    mail.Body = "¡Hola! Este es un correo enviado desde C# usando SMTP de Gmail.";
                    mail.IsBodyHtml = false;

                    smtpClient.Send(mail);
                }

                Console.WriteLine("Correo enviado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
                Console.WriteLine("Detalles: " + ex.StackTrace);
            }
        }

    }
}
