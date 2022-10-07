using System;
using System.Collections.Generic;

namespace OrtizPC02.Models
{
    public partial class AuditCustomer
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public DateTime? ServerDate { get; set; }
    }
}
