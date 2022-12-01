using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yadVeshemProject.models
{
    public class Contact
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string IdNumber { get; set; }
        public Gender Gender { get; set; }
        public CommunicationInfo ComInfo { get; set; }

        public string Language { get; set; }
        public Adress Adress { get; set; }
        public string State { get; set; }
        
        public string Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDirty { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsActive{ get; set; }
        public bool CreatedOn { get; set; }
    
}
}
