using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using pryRentaCarros.Model.EstacionCarga;
using pryRentaCarros.Broker.Procedure;

namespace pryRentaCarros.Broker.Operation
{
    public class optEstacionCarga
    {
        string strConnectionString = @"Server=tcp:lmlopezl.database.windows.net,1433;Initial Catalog=dbaConcurso;Persist Security Info=False;User ID=lmlopezl;Password=6PPaBdKBnAgMmb3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        SqlConnection objCon = null;
        SqlCommand objCom = null;
        spaEstacionCarga objSpaEstacionCarga = null;
        SqlDataAdapter objDap = null;
        DataSet objDst = null;
        List<mdlEstacionCarga> lstEstacionCarga = null;


        public optEstacionCarga()
        {
        }

        public string fncIngresarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaEstacionCarga = new spaEstacionCarga();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaEstacionCarga.spaIngresarEstacionCarga, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@strNombre", objMdlEstacionCarga.strNombre);
                objCom.Parameters.AddWithValue("@numLatitud", objMdlEstacionCarga.dblLatitud);
                objCom.Parameters.AddWithValue("@numLongitud", objMdlEstacionCarga.dblLongitud);
                intResultado = objCom.ExecuteNonQuery();

                if (intResultado > 0)
                {
                    strResultado = "Ingresar Exitoso";
                }
                else
                {
                    strResultado = "Ingresar Fallido";
                }
            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }

            return strResultado;
        }


        public string fncModificarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaEstacionCarga = new spaEstacionCarga();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaEstacionCarga.spaModificarEstacionCarga, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intIdEstacionCarga", objMdlEstacionCarga.intIdEstacionCarga);
                objCom.Parameters.AddWithValue("@strNombre", objMdlEstacionCarga.strNombre);
                objCom.Parameters.AddWithValue("@numLatitud", objMdlEstacionCarga.dblLatitud);
                objCom.Parameters.AddWithValue("@numLongitud", objMdlEstacionCarga.dblLongitud);
                intResultado = objCom.ExecuteNonQuery();

                if (intResultado > 0)
                {
                    strResultado = "Modificar Exitoso";
                }
                else
                {
                    strResultado = "Modificar Fallido";
                }
            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }

            return strResultado;
        }


        public string fncRetirarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaEstacionCarga = new spaEstacionCarga();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaEstacionCarga.spaRetirarEstacionCarga, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intIdEstacionCarga", objMdlEstacionCarga.intIdEstacionCarga);
                intResultado = objCom.ExecuteNonQuery();

                if (intResultado > 0)
                {
                    strResultado = "Retirar Exitoso";
                }
                else
                {
                    strResultado = "Retirar Fallido";
                }
            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }

            return strResultado;
        }


        public List<mdlEstacionCarga> fncConsultarEstacionCarga(mdlEstacionCarga objMdlEstacionCarga)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaEstacionCarga = new spaEstacionCarga();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaEstacionCarga.spaConsultarEstacionCarga, objCon);
                objCom.CommandType = CommandType.StoredProcedure;

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstEstacionCarga = new List<mdlEstacionCarga>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlEstacionCarga = new mdlEstacionCarga();
                    objMdlEstacionCarga.intIdEstacionCarga = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdEstacionCarga"].ToString());
                    objMdlEstacionCarga.strNombre = Convert.ToString(objDst.Tables[0].Rows[i]["strNombre"].ToString());
                    objMdlEstacionCarga.dblLatitud = Convert.ToDouble(objDst.Tables[0].Rows[i]["numLatitud"].ToString());
                    objMdlEstacionCarga.dblLongitud = Convert.ToDouble(objDst.Tables[0].Rows[i]["numLongitud"].ToString());
                    objMdlEstacionCarga.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlEstacionCarga.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstEstacionCarga.Add(objMdlEstacionCarga);
                }

            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }
            return lstEstacionCarga;
        }
    }
}
