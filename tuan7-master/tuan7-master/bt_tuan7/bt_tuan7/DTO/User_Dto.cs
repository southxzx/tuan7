using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_tuan7.DTO
{
    public class User_Dto
    {
        string id_user;
        string username;
        string old_password;
        string current_password;
        string full_name;
        string id_type;
        string description;

        public string ID_User 
        {
            get { return id_user; }
            set { id_user = value; }
        }
        public string UserName 
        { 
          get { return username; } 
          set { username = value; } 
        }
        public string Old_Password
        {
            get {return old_password; }
            set { old_password = value; }
        }
        public string Current_Password 
        {
            get { return current_password; }
            set { current_password = value; }
        }
        public string Full_Name 
        {
            get { return full_name; } 
            set { full_name = value; }
        }
        public string ID_Type 
        { get { return id_type; }
          set { id_type = value; }
        }
        public string Description 
        { 
            get { return description; } 
            set { description = value; }
        }
    }
}
