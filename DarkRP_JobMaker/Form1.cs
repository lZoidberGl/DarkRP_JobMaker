using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkRP_JobMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          MLRuntime.MLRuntime.LanguageChanged += new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
          this.Disposed += new System.EventHandler ( this.MainForm_Disposed );
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ColorSwatch CS = new ColorSwatch();
        private void button1_Click_1(object sender, EventArgs e)
        {
            CS.Show();
            Waiter.Start();
        }

        private void Waiter_Tick(object sender, EventArgs e)
        {
            if (CS.Visible == true)
            {
                ColorBox.Text = CrossFormVariables.SetColor;
                Waiter.Stop();
            }
            if (MS.Visible == true)
            {
                ModelBox.Text = CrossFormVariables.Models;
            }
            if (WS.Visible == true)
            {
                WeaponBox.Text = CrossFormVariables.Weapons;
            }
        }

        ModelSelector MS = new ModelSelector();
        private void button3_Click(object sender, EventArgs e)
        {
            MS.Show();
            Waiter.Start();
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            string panelName = textbox.Name.Substring(0, textbox.Name.Length - 3) + "Panel";

            Control[] panel = this.Controls.Find(panelName, true);

            if (textbox.Text == "")
                panel[0].BackColor = Color.Red;
            else
                panel[0].BackColor = Color.Lime;

            if (textbox.Name == "TeamBox")
            {
                if (textbox.Text == "TEAM_")
                {
                    panel[0].BackColor = Color.Red;
                }
                else if (!textbox.Text.Contains("TEAM_"))
                {
                    panel[0].BackColor = Color.Red;
                }
                else if (textbox.Text.Contains(" "))
                {
                    panel[0].BackColor = Color.Red;
                }
            }
            GenerateResult();
        }

        Form WS = new WeaponSelector();
        private void WeaponButton_Click(object sender, EventArgs e)
        {
            WS.Show();
            Waiter.Start();
        }

        Form RW = new ResultWindow();
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateResult();
            RW.Show();
        }

        private void GenerateResult()
        {
            const string quotes = "\"";
            CrossFormVariables.Result = TeamBox.Text + " = DarkRP.createJob(" + quotes + NameBox.Text + quotes + ",{";
            CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	model = {" + ModelBox.Text + "},";
            CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	color = Color(" + ColorBox.Text + ",255),";
            CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	weapons = {" + WeaponBox.Text + "},";
            CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	command = " + quotes + CommandBox.Text + quotes + ",";
            CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	description = [[" + DescBox.Text + "]],";
            CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	max = " + MaxBox.Value.ToString() + ",";
            CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	salary = " + SalaryBox.Text + ",";
            if (VoteNo.Checked)
                CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	vote = false,";
            else
                CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	vote = true,";

            if (LicenseNo.Checked)
                CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	hasLicense = false,";
            else
                CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	hasLicense = true,";

            if (AdminUser.Checked)
                CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	admin = 0,";
            else if (AdminAdmin.Checked)
                CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	admin = 1,";
            else
                CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	admin = 2,";

            CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + "	category = " + quotes + CategoryBox.Text + quotes;
            CrossFormVariables.Result = CrossFormVariables.Result + Environment.NewLine + ")}";

        }

        private void LicenseYes_CheckedChanged(object sender, EventArgs e)
        {
            GenerateResult();
        }

        private void LanguageSelector_Click(object sender, EventArgs e)
        {

            LangStrip.Show(Cursor.Position);
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
            ml_UpdateControls();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            ml_UpdateControls();
        }
      protected virtual void ml_UpdateControls()
      {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( MainForm ) );
        this.Text = resources.GetString("$this.Text") ;
        AdminAdmin.Text = resources.GetString("AdminAdmin.Text") ;
        AdminSuperadmin.Text = resources.GetString("AdminSuperadmin.Text") ;
        AdminUser.Text = resources.GetString("AdminUser.Text") ;
        AdvSetButton.Text = resources.GetString("AdvSetButton.Text") ;
        AuthLabel.Text = resources.GetString("AuthLabel.Text") ;
        ColorBox.Text = resources.GetString("ColorBox.Text") ;
        ColorButton.Text = resources.GetString("ColorButton.Text") ;
        GenerateButton.Text = resources.GetString("GenerateButton.Text") ;
        label1.Text = resources.GetString("label1.Text") ;
        label10.Text = resources.GetString("label10.Text") ;
        label11.Text = resources.GetString("label11.Text") ;
        label12.Text = resources.GetString("label12.Text") ;
        label13.Text = resources.GetString("label13.Text") ;
        label14.Text = resources.GetString("label14.Text") ;
        label15.Text = resources.GetString("label15.Text") ;
        label16.Text = resources.GetString("label16.Text") ;
        label17.Text = resources.GetString("label17.Text") ;
        label18.Text = resources.GetString("label18.Text") ;
        label19.Text = resources.GetString("label19.Text") ;
        label20.Text = resources.GetString("label20.Text") ;
        label21.Text = resources.GetString("label21.Text") ;
        label22.Text = resources.GetString("label22.Text") ;
        label23.Text = resources.GetString("label23.Text") ;
        label24.Text = resources.GetString("label24.Text") ;
        label25.Text = resources.GetString("label25.Text") ;
        label26.Text = resources.GetString("label26.Text") ;
        label27.Text = resources.GetString("label27.Text") ;
        label28.Text = resources.GetString("label28.Text") ;
        label3.Text = resources.GetString("label3.Text") ;
        label4.Text = resources.GetString("label4.Text") ;
        label6.Text = resources.GetString("label6.Text") ;
        label7.Text = resources.GetString("label7.Text") ;
        label8.Text = resources.GetString("label8.Text") ;
        label9.Text = resources.GetString("label9.Text") ;
        LicenseNo.Text = resources.GetString("LicenseNo.Text") ;
        LicenseYes.Text = resources.GetString("LicenseYes.Text") ;
        ModelButton.Text = resources.GetString("ModelButton.Text") ;
        TeamBox.Text = resources.GetString("TeamBox.Text") ;
        VoteNo.Text = resources.GetString("VoteNo.Text") ;
        VoteYes.Text = resources.GetString("VoteYes.Text") ;
        WeaponButton.Text = resources.GetString("WeaponButton.Text") ;
        ColorBox.Lines[0] = resources.GetString("ColorBox.Lines[0]") ;
        TeamBox.Lines[0] = resources.GetString("TeamBox.Lines[0]") ;
      }

      public void MainForm_Disposed ( object sender, System.EventArgs e )
      {
        MLRuntime.MLRuntime.LanguageChanged -= new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
      }
    }    
}
