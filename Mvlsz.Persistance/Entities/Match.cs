using System;
using System.Collections.Generic;
using System.Text;

namespace Mvlsz.Persistance.Entities
{
    public class Match
    {
        public Guid Id { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public string Division { get; set; }
        public string HomeTeam { get; set; }
        public string VisitorTeam { get; set; }
        public bool IsClosed { get; set; }
        public ICollection<CheckIn> CheckIn { get; set; }
    }
}
