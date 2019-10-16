// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.Net.Mail;

namespace ns_smtp{
  class mysmtp{

    public static void Main(){
      
      MailMessage msg = new MailMessage();
      SmtpClient scl = new SmtpClient("smtp.mail.tst", 587);
      scl.Credentials = new System.Net.NetworkCredential("username", "password");
      scl.EnableSsl = true;
      msg.Subject = "Hello World!";
      msg.Body = "Hello World!";
      msg.From = new MailAddress("user@mail.tst");
      msg.To.Add(new MailAddress("user@mail.tst"));
      scl.Send(msg);
    }
  }
}
