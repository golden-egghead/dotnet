using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class PetShopMember
    {
        public string MemberId { get; set; }
        public string MemberPassword { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public int? MemberRole { get; set; }
    }
}
