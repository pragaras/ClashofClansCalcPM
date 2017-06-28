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
        private int kosten_gesamt = 0;
        private void b_berechnen_Click(object sender, EventArgs e)
        {
            calc.Start();
            Update_Usertable();
        }
        //kanone1_lv                7
        //bogenturm1_lv             8
        //moerser1_lv           3   
        //luftabwehr1_lv        4
        //luftsweeper1_lv       2
        //bombenturm1_lv        2
        //magierturm1_lv        5
        //tesla1_lv             4
        //xbogen1_lv            3
        //infernoturm1_lv       2
        //eagle1_lv             1
        //mauern1_lv            12
        private void Update_Usertable()
        {
            ClashDatabase db = new ClashDatabase();
            db.db_insert(con_string, "INSERT INTO user_abwehr_lv(u_id) VALUES(" + label_uid.Text + ")");
            //kanone1_lv                7
            db.db_update(con_string, 
                "UPDATE user_abwehr_lv SET kanone1_lv =" + kanon1_lvl.Value +
                ",kanone2_lv=" + kanon2_lvl.Value +
                ",kanone3_lv=" + kanon3_lvl.Value +
                ",kanone4_lv=" + kanon4_lvl.Value +
                ",kanone5_lv=" + kanon5_lvl.Value +
                ",kanone6_lv=" + kanon6_lvl.Value +
                ",kanone7_lv=" + kanon7_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //bogenturm1_lv             8
            db.db_update(con_string,
                "UPDATE user_abwehr_lv SET bogenturm1_lv =" + bogen1_lvl.Value +
                ",bogenturm2_lv=" + bogen2_lvl.Value +
                ",bogenturm3_lv=" + bogen3_lvl.Value +
                ",bogenturm4_lv=" + bogen4_lvl.Value +
                ",bogenturm5_lv=" + bogen5_lvl.Value +
                ",bogenturm6_lv=" + bogen6_lvl.Value +
                ",bogenturm7_lv=" + bogen7_lvl.Value +
                ",bogenturm8_lv=" + bogen8_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //moerser1_lv           3     
            db.db_update(con_string,
                "UPDATE user_abwehr_lv SET moerser1_lv =" + moerser1_lvl.Value +
                ",moerser2_lv=" + moerser2_lvl.Value +
                ",moerser3_lv=" + moerser3_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //luftabwehr1_lv        4
            db.db_update(con_string,
                "UPDATE user_abwehr_lv SET luftabwehr1_lv =" + luftabwehr1_lvl.Value +
                ",luftabwehr2_lv=" + luftabwehr2_lvl.Value +
                ",luftabwehr3_lv=" + luftabwehr3_lvl.Value +
                ",luftabwehr4_lv=" + luftabwehr4_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //luftsweeper1_lv       2
            db.db_update(con_string,
                "UPDATE user_abwehr_lv SET luftsweeper1_lv =" + luftsweeper1_lvl.Value +
                ",luftsweeper2_lv=" + luftsweeper2_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //bombenturm1_lv        2
            db.db_update(con_string,
               "UPDATE user_abwehr_lv SET bombenturm1_lv =" + bombenturm1_lvl.Value +
               ",bombenturm2_lv=" + bombenturm2_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //magierturm1_lv        5
            db.db_update(con_string,
                "UPDATE user_abwehr_lv SET magierturm1_lv =" + magierturm1_lvl.Value +
                ",magierturm2_lv=" + magierturm2_lvl.Value +
                ",magierturm3_lv=" + magierturm3_lvl.Value +
                ",magierturm4_lv=" + magierturm4_lvl.Value +
                ",magierturm5_lv=" + magierturm5_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //tesla1_lv             4
            db.db_update(con_string,
                "UPDATE user_abwehr_lv SET tesla1_lv =" + tesla1_lvl.Value +
                ",tesla2_lv=" + tesla2_lvl.Value +
                ",tesla3_lv=" + tesla3_lvl.Value +
                ",tesla4_lv=" + tesla4_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //xbogen1_lv            3
            db.db_update(con_string,
                "UPDATE user_abwehr_lv SET xbogen1_lv =" + xbogen1_lvl.Value +
                ",xbogen2_lv=" + xbogen2_lvl.Value +
                ",xbogen3_lv=" + xbogen3_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //infernoturm1_lv       2
            db.db_update(con_string,
               "UPDATE user_abwehr_lv SET infernoturm1_lv =" + inferno1_lvl.Value +
               ",infernoturm2_lv=" + inferno2_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //eagle1_lv             1
            db.db_update(con_string,
               "UPDATE user_abwehr_lv SET eagle1_lv =" + eagle1_lvl.Value + "WHERE u_id = " + label_uid.Text);
            //mauern1_lv            1-12
            db.db_update(con_string,
                "UPDATE user_abwehr_lv SET mauern1_lv =" + mauer1_lvl.Value +
                ",mauern2_lv=" + mauer2_lvl.Value +
                ",mauern3_lv=" + mauer3_lvl.Value +
                ",mauern4_lv=" + mauer4_lvl.Value +
                ",mauern5_lv=" + mauer5_lvl.Value +
                ",mauern6_lv=" + mauer6_lvl.Value +
                ",mauern7_lv=" + mauer7_lvl.Value +
                ",mauern8_lv=" + mauer8_lvl.Value +
                ",mauern9_lv=" + mauer9_lvl.Value +
                ",mauern10_lv=" + mauer10_lvl.Value +
                ",mauern11_lv=" + mauer11_lvl.Value +
                ",mauern12_lv=" + mauer12_lvl.Value, "WHERE u_id = " + label_uid.Text);
        }

        private void fill_numupdown(int anzahl, string nameBox, string nameUD, string fieldname, string table)
        {
            GroupBox box = (GroupBox)tabPage_Abwehr.Controls[nameBox];
            ClashDatabase db = new ClashDatabase();
            
            for (int i = 1; i <= anzahl; i++)
            {
                NumericUpDown cnt = (NumericUpDown)box.Controls[nameUD + i + "_lvl"];
                try
                {
                    
                    cnt.Value = Convert.ToInt32(db.db_select(con_string, "SELECT " + fieldname + i + "_lv from user_abwehr_lv").ElementAt(0));
                    if(nameUD != "mauer")
                    kosten_gesamt += Convert.ToInt32(db.db_select(con_string, "SELECT SUM(Kosten) AS 'GES' FROM \"" + table + "\" WHERE Level > " + cnt.Value.ToString()).ElementAt(0)); 
                }
                catch(Exception d)
                {
                    cnt.Value = 0;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fill_numupdown(7,"groupBox_kanone","kanon","kanone","Kanone");
            fill_numupdown(8, "groupBox_bogenturm", "bogen", "bogenturm","Bogenschützenturm");
            fill_numupdown(3, "groupBox_moerser", "moerser", "moerser","Mörser");
            fill_numupdown(4, "groupBox_luftabwehr", "luftabwehr", "luftabwehr","Luftabwehr");
            fill_numupdown(2, "groupBox_luftsweeper", "luftsweeper", "luftsweeper","Luftsweeper");
            fill_numupdown(2, "groupBox_bombenturm", "bombenturm", "bombenturm","Bombenturm");
            fill_numupdown(5, "groupBox_magierturm", "magierturm", "magierturm","Magierturm");
            fill_numupdown(4, "groupBox_tesla", "tesla", "tesla","Tesla");
            fill_numupdown(3, "groupBox_xbogen", "xbogen", "xbogen","X-Bogen");
            fill_numupdown(2, "groupBox_infernoturm", "inferno", "infernoturm","Infernoturm");
            fill_numupdown(1, "groupBox_eagle", "eagle", "eagle","Eagle");
            fill_numupdown(12, "groupBox_mauern", "mauer", "mauern","Mauern");
            string kosten = String.Format("{0:#,###0}",kosten_gesamt);
            label_kosten_gesamt.Text = kosten;
        }


    }
}
