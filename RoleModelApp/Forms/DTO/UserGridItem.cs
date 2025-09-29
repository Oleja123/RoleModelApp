using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.DTO
{
    public class UserGridItem
    {
        public string Username { get; set; }
        public bool IsBlocked { get; set; }
        public bool RequireLetter { get; set; }
        public bool RequirePunctuation { get; set; }
        public int MinPasswordLength { get; set; }
        public int PasswordExpiryMonths { get; set; }
    }
}
