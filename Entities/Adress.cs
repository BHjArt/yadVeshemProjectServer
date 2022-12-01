using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Adress
    {
        public string? City { get; set; }
        public string? Street { get; set; }

        public int? ZipCode { get; set; }
        public string? MailingAddress { get; set; }
        public Country? Country { get; set; }
    }
}
