using System;
using System.Collections.Generic;
using System.Text;

namespace Mvlsz.Persistance.Entities
{
    public class UserRole
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int RoleId { get; set; }
    }
}
