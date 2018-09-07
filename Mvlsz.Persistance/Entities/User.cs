using System;
using System.Collections.Generic;
using System.Text;

namespace Mvlsz.Persistance.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public bool IsActive { get; set; }
        public byte[] Salt { get; set; }
        public Guid? ActivationCode { get; set; }
    }
}
