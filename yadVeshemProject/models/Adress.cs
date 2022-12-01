using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yadVeshemProject.models
{
    public class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }

        public int ZipCode { get; set; }
        public string MailingAddress { get; set; }
        public Country country { get; set; }
    }
}
