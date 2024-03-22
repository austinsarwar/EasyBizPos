using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using EasyBizPos.Models;
using EasyBizPos.DAOS;
using System.Windows;
using EasyBizPos.Forms;


namespace EasyBizPos.DAOS
{
    public class TimeTrackingDAO
    {
        string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");

        public void Clockin(int employeeId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO employeetimetracking (employee_ID, clockin) VALUES (@employee_ID, NOW())", connection);
                command.Parameters.AddWithValue("@employee_ID", employeeId);
                command.ExecuteNonQuery();
            }
        }

        public void Clockout(int employeeId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("UPDATE employeetimetracking SET clockout = NOW() WHERE employee_ID = @employee_ID AND clockout IS NULL ORDER BY clockin DESC LIMIT 1", connection);
                command.Parameters.AddWithValue("@employee_ID", employeeId);
                command.ExecuteNonQuery();
            }
        }
    }
}