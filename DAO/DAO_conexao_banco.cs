using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PIM3_SEMESTRE.DAO
{
    internal class DAO_conexao_banco
    {
        internal class DAOConnection
        {
            public NpgsqlConnection Connection { get; set; } = null;

            public DAOConnection(string host, string port, string database, string user, string pass)
            {
                Connect(host, port, database, user, pass);
            }

            public void Insert(Actor actor)
            {
                string query = "INSERT INTO actor (first_name, last_name) VALUES (@first_name, @last_name)";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                c2.Parameters.AddWithValue("first_name", actor.FirstName);
                c2.Parameters.AddWithValue("last_name", actor.LastName);

                c2.ExecuteNonQuery();
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

