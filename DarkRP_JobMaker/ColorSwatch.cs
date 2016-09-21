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
    public partial class ColorSwatch : Form
    {
        public ColorSwatch()
        {
            InitializeComponent();
          MLRuntime.MLRuntime.LanguageChanged += new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
          this.Disposed += new System.EventHandler ( this.ColorSwatch_Disposed );
        }

        private void acceptcolor_Click(object sender, EventArgs e)
        {
            CrossFormVariables.SetColor = ResultValue.Text;
            this.Hide();
        }

        private void NoAccept_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Scrolling_Scrolls(object sender, ScrollEventArgs e)
        {
            ResultValue.Text = RedBar.Value.ToString() + "," + GreenBar.Value.ToString() + "," + BlueBar.Value.ToString();
            ResultColorPanel.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
        }

        private void ColorSwatch_Load(object sender, EventArgs e)
        {

        }

        private void ColorSwatch_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - MouseLoc.X;
                this.Top += e.Y - MouseLoc.Y;
            }
        }
        Point MouseLoc;
        private void ColorSwatch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseLoc = e.Location;
            }
        }
      protected virtual void ml_UpdateControls()
      {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( ColorSwatch ) );
        this.Text = resources.GetString("$this.Text") ;
        BlueLabel.Text = resources.GetString("BlueLabel.Text") ;
        GreenLabel.Text = resources.GetString("GreenLabel.Text") ;
        RedLabel.Text = resources.GetString("RedLabel.Text") ;
        ResultValue.Text = resources.GetString("ResultValue.Text") ;
      }

      public void ColorSwatch_Disposed ( object sender, System.EventArgs e )
      {
        MLRuntime.MLRuntime.LanguageChanged -= new MLRuntime.MLRuntime.LanguageChangedDelegate ( ml_UpdateControls ) ;
      }
    }
}
