using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Microsoft.AspNetCore.Cors;
using InboxAPI.Models;
//using System.Net;
//using System.Net.Mail;

namespace InboxAPI.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class InboxsController : ControllerBase
    {
        
        //private PMSContext _dbContext;

        //public InboxsController(PMSContext dbcontext)
        //{
        //    _dbContext = dbcontext;
        //}

        
        [HttpPost("sendmail")]
        public void SendMail()
        {
            //string email;
            //email = request.EmailId;
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Dhiraj kasat", "dhiraj.kasat@citiustech.com"));
            message.To.Add(new MailboxAddress("Vishal Ghadage", "vishal.ghadage@citiustech.com"));
            message.Subject = "Password Reset";
            message.Body = new TextPart("plain")
            {
                Text = @"Hey,
                Please find the below default password.
                1@Pass
                link to change the password.
                http://localhost:4200/ChangePassword"
            };

            using var client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);

            // Note: only needed if the SMTP server requires authentication
            client.Authenticate("impactbatch7@gmail.com", "Batch@712");

            client.Send(message);
            client.Disconnect(true);


        }
    }
}
