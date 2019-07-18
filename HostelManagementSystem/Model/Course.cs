using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagementSystem.Model
{
    class Course
    {
        string courseId, courseName, numberOfYear, status;

        public string getCourseId()
        {
            return this.courseId;
        }

        public void setCourseId(string value)
        {
            this.courseId = value;
        }
        public string getCourseName()
        {
            return this.courseName;
        }

        public void setCourseName(string value)
        {
            this.courseName = value;
        }

        public string getNumberOfYear()
        {
            return this.numberOfYear;
        }

        public void setNumberOfYear(string value)
        {
            this.numberOfYear = value;
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
