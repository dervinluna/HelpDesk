﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHelpDesk.Back
{
    internal class Tecnico : Usuario
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP_SERVER;Initial Catalog=helpdesk;Integrated Security=True");
        public int idTecnico { get; set; }
        public int ticketAsig { get; set; }
        public Tecnico() { }

        public Tecnico(int idTecnico, string nombre, string usuario,
            string contraseña, int tipo, int cantSolicitudes)
        {
            this.idTecnico = idTecnico;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
            this.cantSolicitudes = cantSolicitudes;
        }

      
        public String Asignar(int ticket, int idTecnico, int estado = 12)
        {
            string sqlSelect = "SELECT COUNT(*) FROM Solicitud WHERE ticket = @ticket";
            string sql = "UPDATE Solicitud SET estado = @estado, idTecnico = @idTecnico    WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ticket", ticket);
                cmd.Parameters.AddWithValue("@idTecnico", idTecnico);
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return (ex.ToString() + "Error no se pudo Grabar update");
                }
            }
            else
            {
                return "Solicitud no existe, Verificar....";
            }
            conn.Close();
            return "Solicitud Asignada, exitosamente ";
        }
        public String Terminar(int ticket, int estado = 13)
        {
            string sqlSelect = "SELECT COUNT(*) FROM Solicitud WHERE ticket = @ticket";
            string sql = "UPDATE Solicitud SET estado = @estado WHERE ticket = @ticket";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ticket", ticket);
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return (ex.ToString() + "Error no se pudo Grabar update");
                }
            }
            else
            {
                return "Solicitud no existe, Verificar....";
            }
            conn.Close();
            return "Solicitud Terminada, Espere que se la aprueven.... ";
        }
        //---------------------Clase que representa la lista doblemente enlazada-------------
        public class Nodo
        {
            public Solicitud Dato { get; set; }
            public Nodo Anterior { get; set; }
            public Nodo Siguiente { get; set; }
            public void ImprimirRecursivo()
            {
                Console.WriteLine($"Ticket: {Dato.ticket}");
                Console.WriteLine($"Descripción: {Dato.descripcion}");
                Console.WriteLine();

                if (Siguiente != null)
                {
                    Siguiente.ImprimirRecursivo();
                }
            }
        }
        //---------------------Obtenemos la lista de solicitudes disponibles------
        public class ListaDobleEnlazada
        {
            private Nodo cabeza;
            private Nodo cola;
            //-----------------------------Metodo agregar a la lista------------
            public void Agregar(Solicitud solicitud)
            {
                Nodo nuevoNodo = new Nodo { Dato = solicitud };

                if (cabeza == null) // Si la lista está vacía
                {
                    cabeza = nuevoNodo;
                    cola = nuevoNodo;
                }
                else
                {
                    cola.Siguiente = nuevoNodo;
                    nuevoNodo.Anterior = cola;
                    cola = nuevoNodo;
                }
            }
      //------------------Mandamos a guardar en la lista los resultados de la consulta---------
        public void Guardando()
        {
            using (conn)
            {
                conn.Open();
                string query = "SELECT * FROM Solicitud where estado = 11 ";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Solicitud solicitud = new Solicitud();
                            solicitud.ticket = (int)reader["ticket"];
                            solicitud.descripcion = (string)reader["descripcion"];
                            solicitud.idCliente = (int)reader["idCliente"];
                            // Asigna aquí los valores correspondientes a las demás propiedades de "solicitud"

                            Agregar(solicitud);
                        }
                    }
                }
            }

        }
        //-----------------imprimimos las solicitudes pendientes de asignacion--------------
        public void ImprimirSolicitudes()
        {
            Guardando();
            cabeza.ImprimirRecursivo();
        }
      }


        //---------------------Obtenemos la lista de solicitudes asignandas------
        public class ListaDobleEnlazada2
        {
            private Nodo cabeza;
            private Nodo cola;
            //-----------------------------Metodo agregar a la lista------------
            public void Agregar(Solicitud solicitud)
            {
                Nodo nuevoNodo = new Nodo { Dato = solicitud };

                if (cabeza == null) // Si la lista está vacía
                {
                    cabeza = nuevoNodo;
                    cola = nuevoNodo;
                }
                else
                {
                    cola.Siguiente = nuevoNodo;
                    nuevoNodo.Anterior = cola;
                    cola = nuevoNodo;
                }
            }
            //------------------Mandamos a guardar en la lista los resultados de la consulta---------
            public void Guardando(int idTecnico)
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM Solicitud where idTecnico = @idTecnico and estado = 12 ";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@idTecnico", idTecnico);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Solicitud solicitud = new Solicitud();
                                solicitud.ticket = (int)reader["ticket"];
                                solicitud.descripcion = (string)reader["descripcion"];
                                solicitud.idCliente = (int)reader["idCliente"];
                                // Asigna aquí los valores correspondientes a las demás propiedades de "solicitud"

                                Agregar(solicitud);
                            }
                        }
                    }
                }

            }
            //-----------------imprimimos las solicitudes pendientes de asignacion--------------
            public void ImprimirSolicitudes(int idTecnico)
            {
                Guardando(idTecnico);
                cabeza.ImprimirRecursivo();
            }
        }
        /*



        */


    }
}