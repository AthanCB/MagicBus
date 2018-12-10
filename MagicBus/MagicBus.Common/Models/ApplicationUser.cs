using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MagicBus.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace MagicBus.Common.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
