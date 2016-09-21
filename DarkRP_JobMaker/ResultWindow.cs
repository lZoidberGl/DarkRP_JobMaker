using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkRP_JobMaker
{
    public partial class ResultWindow : Form
    {
        public ResultWindow()
        {
            InitializeComponent();
          MLRuntime.MLRuntime.LanguageChanged += new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
          this.Disposed += new System.EventHandler ( this.ResultWindow_Disposed );
        }
        Point MouseLoc;
        private void ResultWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseLoc = e.Location;
            }
        }

        private void ResultWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - MouseLoc.X;
                this.Top += e.Y - MouseLoc.Y;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ResultWindow_Shown(object sender, EventArgs e)
        {
            
        }

        private void Refresh_Tick(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                ResultBox.Text = CrossFormVariables.Result;
            }
            else
                Refresher.Stop();
        }

        private void ResultWindow_Activated(object sender, EventArgs e)
        {
            Refresher.Start();
        }
      protected virtual void ml_UpdateControls()
      {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( ResultWindow ) );
        this.Text = resources.GetString("$this.Text") ;
        ExitButton.Text = resources.GetString("ExitButton.Text") ;
        HideButton.Text = resources.GetString("HideButton.Text") ;
      }

      public void ResultWindow_Disposed ( object sender, System.EventArgs e )
      {
        MLRuntime.MLRuntime.LanguageChanged -= new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
      }
    }
}
