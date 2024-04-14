using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Gimnasio_1._0
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection Conectar = new SqlConnection("SERVER=LAPTOP-MOLTPACP\\SSQLSERVER;DATABASE=GimnasioV1;integrated security=true;");
            Conectar.Open();
            return Conectar;
        }
       
        
    }
}
