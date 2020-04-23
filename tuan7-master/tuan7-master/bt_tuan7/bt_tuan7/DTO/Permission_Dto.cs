using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_tuan7.DTO
{
    public class Permission_Dto
    {
        public String id_permission;
        public String name;
        public String description;
        public String ID_Permission 
        {
            get { return id_permission; } 
            set { id_permission = value; }
        }
        public String Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public String Description 
        { 
            get { return description; } 
            set { description = value; }
        }
    }
}
