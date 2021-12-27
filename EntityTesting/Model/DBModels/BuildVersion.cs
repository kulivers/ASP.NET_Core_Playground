using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTesting.Models
{
    public partial class BuildVersion
    {
        public byte SystemInformationID { get; set; }
        public string Database_Version { get; set; }
        public DateTime VersionDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
