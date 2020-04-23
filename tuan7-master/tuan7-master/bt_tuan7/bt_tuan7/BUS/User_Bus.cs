using bt_tuan7.DAL;
using bt_tuan7.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_tuan7.BUS
{
    class User_Bus
    {
        User_Dto U = new User_Dto();
        Data da = new Data();
        public DataTable getUser(String condition)
        {
            DataTable dt = null;
            String sql = "Select * from User where " + condition;
            dt = da.getTable(sql);
            return dt;
        }

        public DataTable getPermission(String user_id)
        {
            DataTable dt = null;
            String sql = "Select Permission.name " +
                "From ((Permission INNER JOIN User_Permission ON Permission.id_permission = User_Permission.id_permission) " +
                "INNER JOIN User ON User_Permission.id_user = User.id_user) " +
                "Where User.id_user = '" + user_id + "' " +
                "UNION " +
                "Select Permission.name " +
                "From ((Permission INNER JOIN Type_Permission ON Permission.id_permission = Type_Permission.id_permission) " +
                "INNER JOIN User ON Type_Permission.id_type = User.id_type) " +
                "Where User.id_user = '" + user_id + "' ;";
            dt = da.getTable(sql);
            return dt;
        }
    }
}
