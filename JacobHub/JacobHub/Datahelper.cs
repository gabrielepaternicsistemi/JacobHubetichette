using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobHub
{
    class Datahelper
    {
        public string getConnessionStringFromCodditta(string codditta)
        {
            switch (codditta)
            {
                case "JACOB":
                    return ConfigurationManager.ConnectionStrings["DB_DATI_JACOB"].ToString();
                case "ATTILIA":
                    return ConfigurationManager.ConnectionStrings["DB_DATI_ATTILIA"].ToString();
                default:
                    return ConfigurationManager.ConnectionStrings["DB_DATI_JACOB"].ToString();
            }
        }

        public DataSet getOperatori()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query.Operatori, connection);
                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);
                return sourceDataSet;
            }
        }

        public DataSet getEtichette()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query.et, connection);
                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);
                return sourceDataSet;
            }
        }

        public DataSet getEtichetteAttilia()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query.et, connection);
                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);
                return sourceDataSet;
            }
        }

        public DataSet getArticoli()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query.getArticoli, connection);
                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);
                return sourceDataSet;
            }
        }

        public DataSet getArticoliAttilia()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query.getArticoli, connection);
                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);
                return sourceDataSet;
            }
        }

        public DataSet getArticoliGriglia()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query.articoligriglia, connection);
                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);
                return sourceDataSet;
            }
        }

        public DataSet getArticoliGrigliaAttilia()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query.articoligriglia, connection);
                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);
                return sourceDataSet;
            }
        }

        public DataSet getddt(string sez)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SERVER"].ToString()))
            {
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(Query.Getddt, connection))
                {
                    command.Parameters.AddWithValue("@serie", sez);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public DataSet getFatture(string sez)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SERVER"].ToString()))
            {
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(Query.GetFatture, connection))
                {
                    command.Parameters.AddWithValue("@serie", sez);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public DataSet getddtAttilia(string sez)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(Query.Getddt, connection))
                {
                    command.Parameters.AddWithValue("@serie", sez);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public DataSet getArticolifrommovmag(string ddt)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SERVER"].ToString()))
            {
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(Query.ArticoliFromMovmag, connection))
                {
                    command.Parameters.AddWithValue("@ddt", ddt);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public DataSet getArticolifrommovmagfatt(string ddt)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SERVER"].ToString()))
            {
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(Query.Articolifrommovmagfatt, connection))
                {
                    command.Parameters.AddWithValue("@ddt", ddt);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public DataSet getArticolifrommovmagAttilia(string ddt)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(Query.ArticoliFromMovmag, connection))
                {
                    command.Parameters.AddWithValue("@ddt", ddt);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public DataSet getTmpArtico()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query.getTmpArtico, connection);
                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);
                return sourceDataSet;
            }
        }

        public DataSet getTmpArticoAttilia()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query.getTmpArtico, connection);
                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);
                return sourceDataSet;
            }
        }

        public void inserisciArtico(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserisciArticoInTemporanea", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception e)
                {
                }

            }
        }

        public void inserisciArticoAttilia(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserisciArticoInTemporanea", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception e)
                {
                }

            }
        }

        public void Inserttmpet1(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserttmpet1", connection))
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void Inserttmpet2(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserttmpet2", connection))
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void Inserttmpet3(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserttmpet3", connection))
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void Inserttmpet4(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserttmpet4", connection))
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void Inserttmpet1Attilia(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserttmpet1", connection))
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void Inserttmpet2Attilia(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserttmpet2", connection))
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void Inserttmpet3Attilia(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserttmpet3", connection))
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void Inserttmpet4Attilia(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_inserttmpet4", connection))
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@xx_codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);

                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }
            }
        }
        public void removeArtico(string cod)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_removeArticoInTemporanea", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@codart", cod);
                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }

            }
        }

        public void removeArticoAttilia(string cod)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_removeArticoInTemporanea", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@codart", cod);
                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                }

            }
        }

        public void UpdateTmpArtico(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2, int et1, int et2, int et3, int et4)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_updateArticoInTemporanea", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);
                        _cmd.Parameters.AddWithValue("@et1", et1);
                        _cmd.Parameters.AddWithValue("@et2", et2);
                        _cmd.Parameters.AddWithValue("@et3", et3);
                        _cmd.Parameters.AddWithValue("@et4", et4);
                        _cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void UpdateTmpArticoAttilia(string cod, string descr, string barcode, decimal prezzo, decimal sconto1, decimal sconto2, int et1, int et2, int et3, int et4)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_updateArticoInTemporanea", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;

                        _cmd.Parameters.AddWithValue("@codart", cod);
                        _cmd.Parameters.AddWithValue("@xx_descr", descr);
                        _cmd.Parameters.AddWithValue("@xx_barcode", barcode);
                        _cmd.Parameters.AddWithValue("@xx_prezzo", prezzo);
                        _cmd.Parameters.AddWithValue("@xx_sconto1", sconto1);
                        _cmd.Parameters.AddWithValue("@xx_sconto2", sconto2);
                        _cmd.Parameters.AddWithValue("@et1", et1);
                        _cmd.Parameters.AddWithValue("@et2", et2);
                        _cmd.Parameters.AddWithValue("@et3", et3);
                        _cmd.Parameters.AddWithValue("@et4", et4);
                        _cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void removeallfromtmp()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_removeallfromtmp", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;
                        _cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void removeallfromtmpAttilia()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("cs_removeallfromtmp", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;
                        _cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception e)
                {
                }

            }

        }

        public void svuotaTemp()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("svuotaTmpcsv", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;
                        _cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public void svuotaTempAttilia()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand _cmd = new SqlCommand("svuotaTmpcsv", connection))
                    {

                        _cmd.CommandType = CommandType.StoredProcedure;
                        _cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception e)
                {
                }
            }
        }

        public string importDataFromCSV(string excelfilepath)
        {
            //declare variables - edit these based on your particular situation
            string ssqltable = "hhTmpCsv";
            // make sure your sheet name is correct, here sheet name is sheet1, so you can change your sheet name if have different

            // string myexceldataquery = ConfigurationManager.AppSettings["QUERYEXCEL"].ToString();
            // string myexceldataquery = "select Name,EmployeeID from [sheet1$]";
            try
            {
                var lines = System.IO.File.ReadAllLines(excelfilepath);
                if (lines.Count() == 0) return String.Empty;
                //var columns = lines[0].Split('\t');
                var columns = lines[0].Split(';');
                var table = new DataTable();
                int numColonna = 0;
                foreach (var c in columns)
                {
                    if (numColonna == 0 || numColonna == 1)
                    {

                        table.Columns.Add(c);
                    }
                    numColonna++;
                }

                for (int i = 0; i < lines.Count(); i++)
                {
                    //table.Rows.Add(lines[i].Split('\t')[0], lines[i].Split('\t')[1]);
                    table.Rows.Add(lines[i].Split(';')[0], lines[i].Split(';')[1]);
                }

                var connection = ConfigurationManager.ConnectionStrings["DB_DATI"].ToString(); ;
                var sqlBulk = new SqlBulkCopy(connection);
                sqlBulk.DestinationTableName = ssqltable;
                sqlBulk.WriteToServer(table);
                return String.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public string importDataFromCSVAttilia(string excelfilepath)
        {
            //declare variables - edit these based on your particular situation
            string ssqltable = "hhTmpCsv";
            // make sure your sheet name is correct, here sheet name is sheet1, so you can change your sheet name if have different

            // string myexceldataquery = ConfigurationManager.AppSettings["QUERYEXCEL"].ToString();
            // string myexceldataquery = "select Name,EmployeeID from [sheet1$]";
            try
            {
                var lines = System.IO.File.ReadAllLines(excelfilepath);
                if (lines.Count() == 0) return String.Empty;
                var columns = lines[0].Split(';');
                var table = new DataTable();
                int numColonna = 0;
                foreach (var c in columns)
                {
                    if (numColonna == 0 || numColonna == 7)
                    {

                        table.Columns.Add(c);
                    }
                    numColonna++;
                }

                for (int i = 0; i < lines.Count(); i++)
                {
                    table.Rows.Add(lines[i].Split('\t')[0], lines[i].Split('\t')[1]);
                }

                var connection = ConfigurationManager.ConnectionStrings["ATTILIA"].ToString(); ;
                var sqlBulk = new SqlBulkCopy(connection);
                sqlBulk.DestinationTableName = ssqltable;
                sqlBulk.WriteToServer(table);
                return String.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public DataSet getArticoliFile()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DATI"].ToString()))
            {
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(Query.ArticolidaFile, connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public DataSet getArticoliFileAttilia()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ATTILIA"].ToString()))
            {
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(Query.ArticolidaFile, connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }

    }
}