using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DDDBrasil
{
    internal class Conexao
    {
        OleDbCommand cmd = null;
        private OleDbConnection _conn = null;
        private readonly string _conectioString = Properties.Settings.Default.CodigoDDDConnectionString;


        public void Atualizar(string p1, string p2, string p3)
        {
            try
            {
                const string comando = "UPDATE DDD SET VENDENDOR = @1 WHERE 'CÓDIGO DDD' = @2 AND MUNICÍPIO = @3";
                _conn = new OleDbConnection(_conectioString);
                cmd = new OleDbCommand(comando, _conn);

                cmd.Parameters.AddWithValue("@1", p1);
                cmd.Parameters.AddWithValue("@2", p2);
                cmd.Parameters.AddWithValue("@3", p3);

                _conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Erro ao conectar: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
