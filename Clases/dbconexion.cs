﻿using System;
using System.Data;
using System.Data.SqlClient;
using Port_manager.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SqlConnectiondb
{
    class DatabaseHelper
    {
        

        //Aqui creamos la conexion a la db en sql server
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(Credentials.connectionString);
            connection.Open();
            return connection;
        }

        //Metodo para verificar el log in , usando getConection
        public static bool VerificarLogin(string nombre, string email, string contraseña)
        {
            using (SqlConnection connection = GetConnection()) 
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("verificar_login", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);

                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                        return resultado == 1;
                    }
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine("❌ Error de SQL: " + sqlEx.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                    return false;
                }
            }
        }

        // Método para agregar el usuario usando GetConnection()
        public static bool agregar_usuario_(string nombre, string email, string password, string rol)
        {
            try
            {
                using (SqlConnection connection = GetConnection()) // 👈 Reutilizando GetConnection()
                {
                    using (SqlCommand cmd = new SqlCommand("agregar_usuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@contraseña", password);
                        cmd.Parameters.AddWithValue("@rol", rol);

                        // Parámetro de salida
                        SqlParameter outputParam = new SqlParameter("@resultado", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParam);

                    
                        cmd.ExecuteNonQuery(); // Ejecuta el procedimiento

                        int resultado = Convert.ToInt32(outputParam.Value); // Obtiene el valor del parámetro de salida

                        return resultado == 1;

                    }
                }

            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("❌ Error de SQL: " + sqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
                return false;
            }

        }
        public static bool verificar_nombre_usuario(string nombre)
        {
            try
            {
                using (SqlConnection connection = GetConnection()) 
                {
                    using (SqlCommand cmd = new SqlCommand("verificar_nombre_usuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        SqlParameter outputParam = new SqlParameter("@existe", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParam);


                        cmd.ExecuteNonQuery(); 

                        int resultado = Convert.ToInt32(outputParam.Value);

                        return resultado == 1;

                    }
                }

            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("❌ Error de SQL: " + sqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
                return false;
            }


        }

        public static string obtener_nombre_usuario(string email)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("devolver_nombre_usuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@email", email);

                        // Esto nos sirve para ejecutar la consulta y obtener el resultado
                        object result = cmd.ExecuteScalar();

                        return result != null ? result.ToString() : null;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("❌ Error de SQL: " + sqlEx.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
                return null;
            }

        }
    }
}
