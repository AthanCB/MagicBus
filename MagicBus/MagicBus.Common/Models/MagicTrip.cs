using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MagicBus.Common.Models
{
    public class MagicTrip : BaseModel
    {
        public DateTime DateAndTime { get; set; }
    }
}
