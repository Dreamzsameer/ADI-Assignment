using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagementSystem.Model
{
    class Staff:Student
    {
        string designtion;
        
        public string getDesignation()
        {
            return this.designtion;
        }

        public void setDesignation(string value)
        {
            this.designtion = value;
        }
    }
}
