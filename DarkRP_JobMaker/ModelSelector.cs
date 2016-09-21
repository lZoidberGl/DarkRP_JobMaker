using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkRP_JobMaker
{
    public partial class ModelSelector : Form
    {
        const string quotes = "\"";

        #region ModelList
        string[] modellist = {
quotes + "models/player/alyx.mdl" + quotes + ",",
quotes + "models/player/barney.mdl" + quotes + ",",
quotes + "models/player/breen.mdl" + quotes + ",",
quotes + "models/player/charple.mdl" + quotes + ",",
quotes + "models/player/p2_chell.mdl" + quotes + ",",
quotes + "models/player/combine_soldier.mdl" + quotes + ",",
quotes + "models/player/combine_super_soldier.mdl" + quotes + ",",
quotes + "models/player/combine_soldier_prisonguard.mdl" + quotes + ",",
quotes + "models/player/corpse1.mdl" + quotes + ",",
quotes + "models/player/arctic.mdl" + quotes + ",",
quotes + "models/player/gasmask.mdl" + quotes + ",",
quotes + "models/player/guerilla.mdl" + quotes + ",",
quotes + "models/player/leet.mdl" + quotes + ",",
quotes + "models/player/phoenix.mdl" + quotes + ",",
quotes + "models/player/riot.mdl" + quotes + ",",
quotes + "models/player/swat.mdl" + quotes + ",",
quotes + "models/player/urban.mdl" + quotes + ",",
quotes + "models/player/dod_american.mdl" + quotes + ",",
quotes + "models/player/dod_german.mdl" + quotes + ",",
quotes + "models/player/eli.mdl" + quotes + ",",
quotes + "models/player/Group01/female_01.mdl" + quotes + ",",
quotes + "models/player/Group01/female_02.mdl" + quotes + ",",
quotes + "models/player/Group01/female_03.mdl" + quotes + ",",
quotes + "models/player/Group01/female_04.mdl" + quotes + ",",
quotes + "models/player/Group01/female_05.mdl" + quotes + ",",
quotes + "models/player/Group01/female_06.mdl" + quotes + ",",
quotes + "models/player/Group03/female_01.mdl" + quotes + ",",
quotes + "models/player/Group03/female_02.mdl" + quotes + ",",
quotes + "models/player/Group03/female_03.mdl" + quotes + ",",
quotes + "models/player/Group03/female_04.mdl" + quotes + ",",
quotes + "models/player/Group03/female_05.mdl" + quotes + ",",
quotes + "models/player/Group03/female_06.mdl" + quotes + ",",
quotes + "models/player/gman_high.mdl" + quotes + ",",
quotes + "models/player/hostage/hostage_01.mdl" + quotes + ",",
quotes + "models/player/hostage/hostage_02.mdl" + quotes + ",",
quotes + "models/player/hostage/hostage_03.mdl" + quotes + ",",
quotes + "models/player/hostage/hostage_04.mdl" + quotes + ",",
quotes + "models/player/kleiner.mdl" + quotes + ",",
quotes + "models/player/magnusson.mdl" + quotes + ",",
quotes + "models/player/Group01/male_01.mdl" + quotes + ",",
quotes + "models/player/Group01/male_02.mdl" + quotes + ",",
quotes + "models/player/Group01/male_03.mdl" + quotes + ",",
quotes + "models/player/Group01/male_04.mdl" + quotes + ",",
quotes + "models/player/Group01/male_05.mdl" + quotes + ",",
quotes + "models/player/Group01/male_06.mdl" + quotes + ",",
quotes + "models/player/Group01/male_07.mdl" + quotes + ",",
quotes + "models/player/Group01/male_08.mdl" + quotes + ",",
quotes + "models/player/Group01/male_09.mdl" + quotes + ",",
quotes + "models/player/Group03/male_01.mdl" + quotes + ",",
quotes + "models/player/Group03/male_02.mdl" + quotes + ",",
quotes + "models/player/Group03/male_03.mdl" + quotes + ",",
quotes + "models/player/Group03/male_04.mdl" + quotes + ",",
quotes + "models/player/Group03/male_05.mdl" + quotes + ",",
quotes + "models/player/Group03/male_06.mdl" + quotes + ",",
quotes + "models/player/Group03/male_07.mdl" + quotes + ",",
quotes + "models/player/Group03/male_08.mdl" + quotes + ",",
quotes + "models/player/Group03/male_09.mdl" + quotes + ",",
quotes + "models/player/Group03m/male_01.mdl" + quotes + ",",
quotes + "models/player/Group03m/male_02.mdl" + quotes + ",",
quotes + "models/player/Group03m/male_03.mdl" + quotes + ",",
quotes + "models/player/Group03m/male_04.mdl" + quotes + ",",
quotes + "models/player/Group03m/male_05.mdl" + quotes + ",",
quotes + "models/player/Group03m/male_06.mdl" + quotes + ",",
quotes + "models/player/Group03m/male_07.mdl" + quotes + ",",
quotes + "models/player/Group03m/male_08.mdl" + quotes + ",",
quotes + "models/player/Group03m/male_09.mdl" + quotes + ",",
quotes + "models/player/Group03m/female_01.mdl" + quotes + ",",
quotes + "models/player/Group03m/female_02.mdl" + quotes + ",",
quotes + "models/player/Group03m/female_03.mdl" + quotes + ",",
quotes + "models/player/Group03m/female_04.mdl" + quotes + ",",
quotes + "models/player/Group03m/female_05.mdl" + quotes + ",",
quotes + "models/player/Group03m/female_06.mdl" + quotes + ",",
quotes + "models/player/monk.mdl" + quotes + ",",
quotes + "models/player/mossman.mdl" + quotes + ",",
quotes + "models/player/mossman_arctic.mdl" + quotes + ",",
quotes + "models/player/odessa.mdl" + quotes + ",",
quotes + "models/player/police.mdl" + quotes + ",",
quotes + "models/player/police_fem.mdl" + quotes + ",",
quotes + "models/player/Group02/male_02.mdl" + quotes + ",",
quotes + "models/player/Group02/male_04.mdl" + quotes + ",",
quotes + "models/player/Group02/male_06.mdl" + quotes + ",",
quotes + "models/player/Group02/male_08.mdl" + quotes + ",",
quotes + "models/player/skeleton.mdl" + quotes + ",",
quotes + "models/player/soldier_stripped.mdl" + quotes + ",",
quotes + "models/player/zombie_classic.mdl" + quotes + ",",
quotes + "models/player/zombie_fast.mdl" + quotes + ",",
quotes + "models/player/zombie_soldier.mdl" + quotes + ","
};
        #endregion

        public ModelSelector()
        {
            InitializeComponent();
          MLRuntime.MLRuntime.LanguageChanged += new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
          this.Disposed += new System.EventHandler ( this.ModelSelector_Disposed );
        }

        private void ModelSelector_Load(object sender, EventArgs e)
        {
            SetPictures();
        }

        private void SetPictures()
        {
            int chknum = 1;

            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is Panel)
                {
                    var panele = (Panel)c;
                    Control[] contrl = panele.Controls.Find("CheckBox" + chknum.ToString() , true);

                    Object O = Models.ResourceManager.GetObject("model" + chknum.ToString());
                    Image pic = (Image)O;

                    contrl[0].BackgroundImage = pic;

                    CheckBox chk = (CheckBox)contrl[0];

                    chk.CheckStateChanged += Chk_CheckStateChanged;

                }
                chknum++;
            }
        }

        string Result = "";

        private void Chk_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            Control[] contrl = flowLayoutPanel1.Controls.Find("panel" + chk.Name.Remove(0,8), false);

            if (chk.Checked)
            {
                contrl[0].BackColor = Color.Lime;
                MakeResult(chk);
            }
            else
            {
                contrl[0].BackColor = Color.Red;
                MakeResult(chk);
            }
        }

        private void MakeResult(CheckBox chk)
         {
            Result = "";

            int chknum = 1;
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is Panel)
                {

                    var panele = (Panel)c;
                    Control[] contrl = panele.Controls.Find("CheckBox" + chknum.ToString(), true);

                    if (chk.Checked)
                    {
                        int index = Convert.ToInt32(chk.Name.Remove(0, 8)) - 1;

                        chk.Tag = modellist.GetValue(index);
                    }
                    else
                        chk.Tag = "";

                    Result = Result + contrl[0].Tag;

                    chknum++;
                }

            }
          

            if (Result.Length != 0)
                CrossFormVariables.Models = Result.Substring(0, Result.Length - 1);
            else
                CrossFormVariables.Models = Result;            
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point MouseLoc;
        private void ModelSelector_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseLoc = e.Location;
            }

        }

        private void ModelSelector_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - MouseLoc.X;
                this.Top += e.Y - MouseLoc.Y;
            }
        }
      protected virtual void ml_UpdateControls()
      {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( ModelSelector ) );
        this.Text = resources.GetString("$this.Text") ;
        Exitbutton.Text = resources.GetString("Exitbutton.Text") ;
        HideButton.Text = resources.GetString("HideButton.Text") ;
      }

      public void ModelSelector_Disposed ( object sender, System.EventArgs e )
      {
        MLRuntime.MLRuntime.LanguageChanged -= new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
      }

        private void Button1_Click(object sender, EventArgs e)
        {
            CustimSettingsPanel.Show();
        }
    }
}
