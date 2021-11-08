using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Playground.Data
{
    internal class Employee
    {
        // [Key]
        public int Empid { get; set; }
        public string Firstname { get; }
        public string Lastname { get; }
    }
}