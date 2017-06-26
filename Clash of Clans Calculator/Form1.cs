using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coc_database;
namespace Clash_of_Clans_Calculator
{
    public partial class Form1 : Form
    {
        private static Calculations calc = new Calculations();
        public Form1()
        {
            InitializeComponent();
        }
        private static string con_string = @"Data Source = MUENZ; User ID=sa;Password=somacos;Initial Catalog='Clash of Clans';Persist Security Info =True;";
        private void b_berechnen_Click(object sender, EventArgs e)
        {
            calc.Start();
            Update_Usertable();
        }

        private void Update_Usertable()
        {
            ClashDatabase db = new ClashDatabase();
            db.db_insert(con_string, "INSERT INTO users(u_id) VALUES(" + label_uid.Text + ")");
                                db.db_update(con_string,
                                    "UPDATE users SET kanone1_lv =" + kanon1_lvl.Value +
                                    ",kanone2_lv=" + kanon2_lvl.Value +
                                    ",kanone3_lv=" + kanon3_lvl.Value +
                                    ",kanone4_lv=" + kanon4_lvl.Value +
                                    ",kanone5_lv=" + kanon5_lvl.Value +
                                    ",kanone6_lv=" + kanon6_lvl.Value +
                                    ",kanone7_lv=" + kanon7_lvl.Value, "WHERE u_id = " + label_uid.Text);
        }


    }
}
