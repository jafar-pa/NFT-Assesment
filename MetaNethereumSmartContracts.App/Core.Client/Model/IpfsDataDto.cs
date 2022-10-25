using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Client.Model
{
    public class IpfsDataDto
    {
        public string? description { get; set; }
        public string? image { get; set; }
        public Attribute[]? attributes { get; set; }
        public string name { get; set; }
    }
    public class Attribute
    {
        public string? trait_type { get; set; }
        public dynamic? value { get; set; }
    }

}
