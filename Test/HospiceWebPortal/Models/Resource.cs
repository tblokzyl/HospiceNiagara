using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospiceWebPortal.Models
{
    public class Resource
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string CreatedOn { get; set; }
        public byte Data { get; set; }
    }
}