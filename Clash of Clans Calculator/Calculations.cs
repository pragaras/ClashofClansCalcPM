using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clash_of_Clans_Calculator
{
    class Calculations
    {
        private int gold_cost;
        private int elixier_cost;
        private int time_days, time_hours, time_minutes, time_seconds;
        private static SqlConnection cnn = new SqlConnection(@"Data Source = MUENZ; User ID=sa;Password=somacos;Initial Catalog='Clash of Clans';Persist Security Info =True;");
        private static void Con_open()
        { 
            try
            {
                cnn.Open();
            }
            catch(Exception d)
            {
                MessageBox.Show(d.ToString());
            }
        }

        private static void Con_close()
        {
            try
            {
                cnn.Close();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.ToString());
            }
        }

        public void Start()
        {
            Con_open();
            Con_close();
        }
    }
}
