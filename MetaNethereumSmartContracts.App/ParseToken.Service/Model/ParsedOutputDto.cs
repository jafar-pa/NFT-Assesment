using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ParseToken.Service.Model
{
    public class ParsedOutputDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ExternalUrl { get; set; }
        public string? Media { get; set; }       
        public List<ParsedOutputProperties>? Properties { get; set; }
    }


    public class ParsedOutputProperties
    {
        public string? Category { get; set; }
        public dynamic? Property { get; set; }
    }

}
