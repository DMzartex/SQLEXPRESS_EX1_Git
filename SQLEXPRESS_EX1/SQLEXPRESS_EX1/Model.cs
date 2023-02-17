using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLEXPRESS_EX1
{
    class Model
    {
        public string CheminDB()
        {
            return "Data Source=PCI42107\\SQLEXPRESS;Initial Catalog=bibliotheque_bb;Integrated Security=True";
        }


        public bool SelectUser(out SqlDataReader resultUsers)
        {

        }


    }
}
