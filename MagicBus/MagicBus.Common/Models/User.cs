using System;
using System.Collections.Generic;
using System.Text;

namespace MagicBus.Common.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public virtual ApplicationUser AppUser { get; set; }
    }
}
