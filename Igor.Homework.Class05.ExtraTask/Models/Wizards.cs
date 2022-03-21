using System;
using System.Collections.Generic;
using System.Text;

namespace Igor.Homework.Class05.ExtraTask
{
    public class Wizards
    {
        public string Name { get; set; }
        public int PowerLevel { get; set; }
        public int Age { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public bool IsGraduate { get; set; }

        public Wizards (string name , int powerLevel , int age, DateTime dateOfAdmission, bool isGraduate )
        {
            Name = name;
            PowerLevel = powerLevel;
            Age = age;
            DateOfAdmission = dateOfAdmission;
            IsGraduate = isGraduate;
        }
    }
}
