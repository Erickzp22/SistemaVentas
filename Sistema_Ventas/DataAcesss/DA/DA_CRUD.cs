using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcesss.DA
{
    public class DA_CRUD
    {


        #region Insertar

        public bool Inserta(string Bar_Code, string Descripcion, string Pre_V, string Pre_C, string sto, string min_st) {

            int Precio_Venta = Convert.ToInt32(Pre_V);
            int Precio_Compra = Convert.ToInt32(Pre_C);
            int Stock = Convert.ToInt32(sto);
            int Min_Stock = Convert.ToInt32(min_st);


            SqlConnection conexion = CadenaConexion();

            string sintaxis = "INSERT INTO PRODUCTOS (Bar_Code, Descripcion, Precio_Venta, Precio_Compra, Stock, Min_Stock)" +
                               "VALUES (@Bar_Code, @Descripcion, @Precio_Venta, @Precio_Compra, @Stock, @Min_Stock)";

            SqlCommand cmd = new SqlCommand(sintaxis,conexion);

            cmd.Parameters.Add(new SqlParameter("@Bar_Code",SqlDbType.VarChar));
           cmd.Parameters["@Bar_Code"].Value = Bar_Code;


           cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar));
           cmd.Parameters["@Descripcion"].Value = Descripcion;

           cmd.Parameters.Add(new SqlParameter("@Precio_Venta", SqlDbType.Int));
           cmd.Parameters["@Precio_Venta"].Value = Precio_Venta;

           cmd.Parameters.Add(new SqlParameter("@Precio_Compra", SqlDbType.Int));
           cmd.Parameters["@Precio_Compra"].Value = Precio_Compra;

           cmd.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int));
           cmd.Parameters["@Stock"].Value = Stock;

           cmd.Parameters.Add(new SqlParameter("@Min_Stock", SqlDbType.Int));
           cmd.Parameters["@Min_Stock"].Value = Min_Stock;

           try
           {

               conexion.Open();
               cmd.ExecuteNonQuery();
               return true;

           }
           catch (Exception ex)
           {
               return false;
               throw new Exception(ex.Message);
           }
           finally { conexion.Close(); }




                

        
        
        
        }

        #endregion Insertar

        #region CadenaConexion

        public SqlConnection CadenaConexion()
        {


            SqlConnection conexion = new SqlConnection("Data Source=ALVARO-ROBERTH\\SQLEXPRESS;Initial Catalog=PULPERIA_VERA_CRUZ;Integrated Security=True");


            return conexion;

        }

        #endregion

    }
}
