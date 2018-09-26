using System;
using System.Collections.Generic;
using System.Text;

namespace Mvlsz.Persistance.Entities
{
    public class CheckIn
    {
        public Guid MatchId { get; set; }
        public Guid UserId { get; set; }
        public Match Match { get; set; }
        public User User { get; set; }
    }
}
