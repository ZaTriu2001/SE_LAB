using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Student
    {
        private string SID, SName, Hometown, DOB;
        private double GPA;

        public string _SID
        {
            get
            {
                return SID;
            }
            set
            {
                SID = value;
            }
        }

        public string _SNAME
        {
            get
            {
                return SName;
            }
            set
            {
                SName = value;
            }
        }

        public string _HOMETOWN
        {
            get
            {
                return Hometown;
            }
            set
            {
                Hometown = value;
            }
        }

        public string _DOB
        {
            get
            {
                return DOB;
            }
            set
            {
                DOB = value;
            }
        }

        public double _GPA
        {
            get
            {
                return GPA;
            }
            set
            {
                GPA = value;
            }
        }



        public DTO_Student(string sid, string name, string ht, string dob, double gpa)
        {
            this.SID = sid;
            this.SName = name;
            this.Hometown = ht;
            this.DOB = dob;
            this.GPA = gpa;
        }
    }
}
