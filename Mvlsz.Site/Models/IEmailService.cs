using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvlsz.Site.Models
{
    public interface IEmailService
    {
        Task SendEmail(string email, string subject, string message);
    }
}
