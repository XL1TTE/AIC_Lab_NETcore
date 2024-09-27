using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_NetCore.Application.Dtos
{
    public class StudentDto
    {
        public StudentDto() { }
        public StudentDto(string Name, string Speciality, string Group) =>
            (this.Name, this.Speciality, this.Group) = (Name, Speciality, Group);
        public string Name { get; set; }
        public string Group { get; set; }
        public string Speciality { get; set; }
    }
}
