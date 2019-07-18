using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagementSystem.Model
{
    class Student
    {
        string id, name, address, gender, contactNumber, bloodGroup, fatherName, motherName, pContactNumber, course, Block, DOB,status;

        public string getId()
        {
            return this.id;
        }

        public void setId(string value)
        {
            this.id = value;
        }
        public string getName()
        {
            return this.name;
        }

        public void setName(string value)
        {
            this.name = value;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setAddress(string value)
        {
            this.address = value;
        }
        public string getGender()
        {
            return this.gender;
        }

        public void setGender (string value)
        {
            this.gender= value;
        }

        public string getContactNumber()
        {
            return this.contactNumber;
        }

        public void setContactNumber(string value)
        {
            this.contactNumber = value;
        }
        public string getBloodGroup()
        {
            return this.bloodGroup;
        }

        public void setBloodGroup(string value)
        {
            this.bloodGroup = value;
        }
        public string getFatherName()
        {
            return this.fatherName;
        }

        public void setFatherName(string value)
        {
            this.fatherName = value;
        }
        public string getMotherName()
        {
            return this.motherName;
        }

        public void setMotherName(string value)
        {
            this.motherName = value;
        }
        public string getPContactNumber()
        {
            return this.pContactNumber;
        }

        public void setPContactNumber(string value)
        {
            this.pContactNumber = value;
        }
        public string getCourse()
        {
            return this.course;
        }

        public void setCourse(string value)
        {
            this.course = value;
        }
        public string getBlock()
        {
            return this.Block;
        }

        public void setBlock(string value)
        {
            this.Block = value;
        }
        public string getDOB()
        {
            return this.DOB;
        }

        public void setDOB(string value)
        {
            this.DOB = value;
        }
        public string getStatus()
        {
            return this.status;
        }

        public void setStatus(string value)
        {
            this.status = value;
        }
    }
}
