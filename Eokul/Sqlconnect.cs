using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eokul
{
    class Sqlconnect
    {
        public SqlConnection link()
        {
            SqlConnection link = new SqlConnection("Data Source=DESKTOP-2POAH45; Initial Catalog=Eokuldb; Integrated Security=True");
            link.Open();
            return link;
        }
    }
}
