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
            //bomben1_lv
            db.db_update(con_string,
               "UPDATE user_fallen_lv SET bombe1_lv =" + bombe1_lvl.Value +
               ",bombe2_lv=" + bombe2_lvl.Value +
               ",bombe3_lv=" + bombe3_lvl.Value +
               ",bombe4_lv=" + bombe4_lvl.Value +
               ",bombe5_lv=" + bombe5_lvl.Value +
               ",bombe6_lv=" + bombe6_lvl.Value, "WHERE u_id = " + label_uid.Text);

            //bigbomb1_lv
            db.db_update(con_string,
               "UPDATE user_fallen_lv SET bigbomb1_lv =" + bigbomb1_lvl.Value +
               ",bigbomb2_lv=" + bigbomb2_lvl.Value +
               ",bigbomb3_lv=" + bigbomb3_lvl.Value +
               ",bigbomb4_lv=" + bigbomb4_lvl.Value +
               ",bigbomb5_lv=" + bigbomb5_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //sprungfeder1_lv
            db.db_update(con_string,
                "UPDATE user_fallen_lv SET sprungfeder1_lv =" + sprungfeder1_lvl.Value +
                ",sprungfeder2_lv=" + sprungfeder2_lvl.Value +
                ",sprungfeder3_lv=" + sprungfeder3_lvl.Value +
                ",sprungfeder4_lv=" + sprungfeder4_lvl.Value +
                ",sprungfeder5_lv=" + sprungfeder5_lvl.Value +
                ",sprungfeder6_lv=" + sprungfeder6_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //targetluftbombe1_lv
            db.db_update(con_string,
                "UPDATE user_fallen_lv SET targetluftbombe1_lv =" + targetluftbombe1_lvl.Value +
                ",targetluftbombe2_lv=" + targetluftbombe2_lvl.Value +
                ",targetluftbombe3_lv=" + targetluftbombe3_lvl.Value +
                ",targetluftbombe4_lv=" + targetluftbombe4_lvl.Value +
                ",targetluftbombe5_lv=" + targetluftbombe5_lvl.Value , "WHERE u_id = " + label_uid.Text);
            //luftbombe1_lv
            db.db_update(con_string,
                "UPDATE user_fallen_lv SET luftbombe1_lv =" + luftbombe1_lvl.Value +
                ",luftbombe2_lv=" + luftbombe2_lvl.Value +
                ",luftbombe3_lv=" + luftbombe3_lvl.Value +
                ",luftbombe4_lv=" + luftbombe4_lvl.Value +
                ",luftbombe5_lv=" + luftbombe5_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //skelettfalle1_lv
            db.db_update(con_string,
                "UPDATE user_fallen_lv SET skelettfalle1_lv =" + skelettfalle1_lvl.Value +
                ",skelettfalle2_lv=" + skelettfalle2_lvl.Value +
                ",skelettfalle3_lv=" + skelettfalle3_lvl.Value, "WHERE u_id = " + label_uid.Text);
            //armeelager1_lv
            db.db_update(con_string,
                "UPDATE user_armee_lv SET armeelager1_lv =" + armeelager1_lvl.Value +
                ",armeelager2_lv=" + armeelager2_lvl.Value +
                ",armeelager3_lv=" + armeelager3_lvl.Value +
                ",armeelager4_lv=" + armeelager4_lvl.Value, "WHERE user_id = " + label_uid.Text);
            //baracke1_lv
            db.db_update(con_string,
                "UPDATE user_armee_lv SET baracke1_lv =" + baracke1_lvl.Value +
                ",baracke2_lv=" + baracke2_lvl.Value +
                ",baracke3_lv=" + baracke3_lvl.Value +
                ",baracke4_lv=" + baracke4_lvl.Value, "WHERE user_id = " + label_uid.Text);
            //dunklebaracke1_lv
            db.db_update(con_string,
                "UPDATE user_armee_lv SET dunklebaracke1_lv =" + dunklebaracke1_lvl.Value +
                 ",dunklebaracke2_lv=" + dunklebaracke2_lvl.Value, "WHERE user_id = " + label_uid.Text);
            //labor1_lv
            db.db_update(con_string,
               "UPDATE user_armee_lv SET labor1_lv =" + labor1_lvl.Value + "WHERE user_id = " + label_uid.Text);
            //zauberfabrik1_lv
            db.db_update(con_string,
               "UPDATE user_armee_lv SET zauberspruchfabrik1_lv =" + zauberfabrik1_lvl.Value + "WHERE user_id = " + label_uid.Text);
            //dunklezauberfabrik1_lv
            db.db_update(con_string,
               "UPDATE user_armee_lv SET dunklezauberspruchfabrik1_lv =" + darkzauberfabrik1_lvl.Value + "WHERE user_id = " + label_uid.Text);
            //bk1_lv
            db.db_update(con_string,
              "UPDATE user_helden_lv SET barbarenkoenig1_lv =" + bk1_lvl.Value + "WHERE user_id = " + label_uid.Text);
            //aq1_lv
            db.db_update(con_string,
              "UPDATE user_helden_lv SET bogenkoenigin1_lv =" + aq1_lvl.Value + "WHERE user_id = " + label_uid.Text);
            //gw1_lv
            db.db_update(con_string,
                "UPDATE user_helden_lv SET großerWaechter1_lv =" + gw1_lvl.Value + "WHERE user_id = " + label_uid.Text);
        }

        private void fill_numupdown(GroupBox box, int anzahl, string nameUD, string fieldname, string tableuser,  string table)
        {
            //GroupBox box = (GroupBox)tabPage_Abwehr.Controls[nameBox];
            ClashDatabase db = new ClashDatabase();
            
            for (int i = 1; i <= anzahl; i++)
            {
                NumericUpDown cnt = (NumericUpDown)box.Controls[nameUD + i + "_lvl"];
                try
                {
                    
                    cnt.Value = Convert.ToInt32(db.db_select(con_string, "SELECT " + fieldname + i + "_lv from "+tableuser).ElementAt(0));
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
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_kanone"], 7, "kanon", "kanone", "user_abwehr_lv", "Kanone");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_bogenturm"], 8, "bogen", "bogenturm", "user_abwehr_lv", "Bogenschützenturm");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_moerser"], 3, "moerser", "moerser", "user_abwehr_lv", "Mörser");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_luftabwehr"], 4, "luftabwehr", "luftabwehr", "user_abwehr_lv", "Luftabwehr");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_luftsweeper"], 2, "luftsweeper", "luftsweeper", "user_abwehr_lv", "Luftsweeper");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_bombenturm"], 2, "bombenturm", "bombenturm", "user_abwehr_lv", "Bombenturm");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_magierturm"], 5, "magierturm", "magierturm", "user_abwehr_lv", "Magierturm");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_tesla"], 4, "tesla", "tesla", "user_abwehr_lv", "Tesla");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_xbogen"], 3, "xbogen", "xbogen", "user_abwehr_lv", "X-Bogen");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_infernoturm"], 2, "inferno", "infernoturm", "user_abwehr_lv", "Infernoturm");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_eagle"], 1, "eagle", "eagle", "user_abwehr_lv", "Eagle");
            fill_numupdown((GroupBox)tabPage_Abwehr.Controls["groupBox_mauern"], 12, "mauer", "mauern", "user_abwehr_lv", "Mauern");
            //Tab2 Fallen
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_Bomben"], 6, "bombe", "bombe", "user_fallen_lv", "Bombe");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_BigBombs"], 5, "bigbomb", "bigbomb", "user_fallen_lv", "BigBomb");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_Sprungfedern"], 6, "sprungfeder", "sprungfeder", "user_fallen_lv", "Sprungfeder");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_Luftbomben"], 5, "luftbombe", "luftbombe", "user_fallen_lv", "Luftbombe");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_targetLuftBomben"], 5, "targetluftbombe", "targetluftbombe", "user_fallen_lv", "TargetLuftbombe");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_Skelettfallen"], 3, "skelettfalle1", "skelettfalle", "user_fallen_lv", "Skelettfalle");
            //Tab3 Armee
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_Armeelager"], 4, "armeelager", "armeelager", "user_armee_lv", "Armeelager");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_Baracken"], 4, "baracke", "baracke", "user_armee_lv", "Baracken");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_DunkleBaracken"], 2, "dunklebaracke", "dunklebaracke", "user_armee_lv", "dunkleBaracken");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_Labor"], 1, "labor", "labor", "user_armee_lv", "Labor");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupBox_Zauberfabrik"], 1, "zauberfabrik", "zauberspruchfabrik", "user_armee_lv", "Zauberspruchfabrik");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupbox_DarkZauberfabrik"], 1, "darkzauberfabrik", "dunklezauberspruchfabrik", "user_armee_lv", "dunkleZauberspruchfabrik");
            //Tab4 Helden
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupbox_bk"], 1, "bk", "barbarenkoenig", "user_helden_lv", "Barbarenkönig");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupbox_bogk"], 1, "aq", "bogenkoenigin", "user_helden_lv", "Bogenkönigin");
            fill_numupdown((GroupBox)tabPage_Fallen.Controls["groupbox_gw"], 1, "gw", "großerWaechter", "user_helden_lv", "großerWaechter");
            string kosten = String.Format("{0:#,###0}",kosten_gesamt);
            label_kosten_gesamt.Text = kosten;
        }

    }
}
