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
    public partial class WeaponSelector : Form
    {
        public WeaponSelector()
        {
            InitializeComponent();
          MLRuntime.MLRuntime.LanguageChanged += new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
          this.Disposed += new System.EventHandler ( this.WeaponSelector_Disposed );
        }

        private void WeaponSelector_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseLoc = e.Location;
            }
        }
        Point MouseLoc;
        private void WeaponSelector_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - MouseLoc.X;
                this.Top += e.Y - MouseLoc.Y;
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
      protected virtual void ml_UpdateControls()
      {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( WeaponSelector ) );
        this.Text = resources.GetString("$this.Text") ;
        Exitbutton.Text = resources.GetString("Exitbutton.Text") ;
        HideButton.Text = resources.GetString("HideButton.Text") ;
      }

      public void WeaponSelector_Disposed ( object sender, System.EventArgs e )
      {
        MLRuntime.MLRuntime.LanguageChanged -= new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
      }
    }
}
