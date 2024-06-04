using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PIM3_SEMESTRE.DAO
{
    internal class conexao_banco
    {
        internal class ConnectionBD
        {
            public NpgsqlConnection Connection { get; set; } = null;

            public ConnectionBD(string host, string port, string database, string user, string pass)
            {
                Connect(host, port, database, user, pass);
            }

            private void Connect(string host, string port, string database, string user, string pass)
            {
                if (Connection == null)
                {
                    Connection = new NpgsqlConnection(
                    $"Server={host};" +
                    $"Port={port};" +
                    $"Database={database};" +
                    $"Uid={user};" +
                    $"Pwd={pass};");

                    Connection.Open();
                }
            }
            private void Disconnect()
            {
                if (Connection != null)
                {
                    Connection.Close();
                }
            }

        }
    }

}


