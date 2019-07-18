using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagementSystem.Model
{
    class Room
    {
        string roomId, roomNumber, numberOfBeds, description, status, Block, fee;

        public string getRoomId()
        {
            return this.roomId;
        }

        public void setRoomId(string value)
        {
            this.roomId = value;
        }
        public string getRoomNumber()
        {
            return this.roomNumber;
        }

        public void setRoomNumber(string value)
        {
            this.roomNumber = value;
        }
        public string getNumberOfBeds()
        {
            return this.numberOfBeds;
        }

        public void setNumberOfBeds(string value)
        {
            this.numberOfBeds = value;
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
        public string getBlock()
        {
            return this.Block;
        }

        public void setBlock(string value)
        {
            this.Block = value;
        }
        public string getFee()
        {
            return this.fee;
        }

        public void setFee(string value)
        {
            this.fee = value;
        }
    }
}
