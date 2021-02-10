using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Topic { get; set; }
        public string TimePreference { get; set; }
        public bool Subscription { get; set; }
    }
}
