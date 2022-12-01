using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public Country? Country { get; set; }
        public string? Institution { get; set; }
        public string? EventReservation { get; set; }
        public int? EventType { get; set; }
        public Contact? Contact { get; set; }
        public string? Language { get; set; }
        public string? Comments { get; set; }
    }
}
