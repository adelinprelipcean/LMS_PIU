using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectPIU_Student
{
    public class Student
    {
        public string Nume { get; set; }
        public string Oras { get; set; }
        public DateTime DataInscriere { get; set; }
        public string ProgramStudiu { get; set; }
        public Student() { }
        public Student(string nume, string oras, DateTime dataInscriere, string
        programStudiu)
        {
            this.Nume = nume;
            this.Oras = oras;
            this.DataInscriere = dataInscriere;
            this.ProgramStudiu = programStudiu;
        }
        public override string ToString()
        {
            return $"{Nume} din {Oras} s-a inscris la date de: {DataInscriere}, la programul de studiu: {ProgramStudiu}";
        }
    }
}