using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagementSystem.Model
{
    class BlockBuilding
    {
        string blockId, blockName, gender, description, status;
        public string getBlockId()
        {
            return this.blockId;
        }

        public void setBlockId(string value)
        {
            this.blockId = value;
        }

        public string getBlockName()
        {
            return this.blockName;
        }

        public void setBlockName(string value)
        {
            this.blockName = value;
        }
        public string getGender()
        {
            return this.gender;
        }

        public void setGender(string value)
        {
            this.gender = value;
        }
        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string value)
        {
            this.description = value;
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
