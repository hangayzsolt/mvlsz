using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Mvlsz.Persistance.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public byte[] Salt { get; set; }
        public Guid? ActivationCode { get; set; }

        [NotMapped]
        public override string NormalizedUserName { get; set; }
        [NotMapped]
        public override string NormalizedEmail { get; set; }
        [NotMapped]
        public override string PhoneNumber { get; set; }
        [NotMapped]
        public override bool PhoneNumberConfirmed { get; set; }
        [NotMapped]
        public override bool TwoFactorEnabled { get; set; }
        [NotMapped]
        public override string SecurityStamp { get; set; }
        [NotMapped]
        public override string ConcurrencyStamp { get; set; }
    }
}
