using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo
{
    class Person
    {
        // regular simple properties like these are always loaded by EF
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // this attr tells SQL Server to let US decide the ID in C#.
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Children { get; set; }
        public Address Address { get; set; }
    }
}
