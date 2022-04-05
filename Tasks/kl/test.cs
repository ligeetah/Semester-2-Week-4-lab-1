using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.kl
{
    internal class Student
    {
        String Name;
        int rollNumber;
        float cGPA;
        int matricMarks;
        int fscMarks;
        string homeTown;
        bool isHostelite;
        bool isTakingScholarship;
        float ecat;
        public Student() { }
        public Student(string names,int roll,float gpa,int matric_marks,int fsc_marks,string add,bool hostel,bool scholar,float ect)
        {
            Name = names;
            rollNumber = roll;
            cGPA = gpa;
            matricMarks = matric_marks;
            fscMarks = fsc_marks;
            homeTown = add;
            isHostelite = hostel;
            isTakingScholarship = scholar;
            ecat = ect;
        }
        public float calculate_merit()
        {
            float merit = (fscMarks / 1100F * 60F + ecat / 400F * 40);
            return merit;
        }
        public bool is_elegible(float merit)
        {
            if(merit > 80 && isHostelite == true && isTakingScholarship == false)
            {
                return true;
            }
            return false;
        }
    }
}
