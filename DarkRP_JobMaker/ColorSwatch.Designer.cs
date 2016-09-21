namespace DarkRP_JobMaker
{
    partial class ColorSwatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorSwatch));
            this.NoAccept = new System.Windows.Forms.Button();
            this.acceptcolor = new System.Windows.Forms.Button();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.ResultValue = new System.Windows.Forms.Label();
            this.BlueBar = new System.Windows.Forms.HScrollBar();
            this.GreenBar = new System.Windows.Forms.HScrollBar();
            this.RedBar = new System.Windows.Forms.HScrollBar();
            this.ResultColorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NoAccept
            // 
            resources.ApplyResources(this.NoAccept, "NoAccept");
            this.NoAccept.FlatAppearance.BorderSize = 0;
            this.NoAccept.Name = "NoAccept";
            this.NoAccept.UseVisualStyleBackColor = true;
            this.NoAccept.Click += new System.EventHandler(this.NoAccept_Click);
            // 
            // acceptcolor
            // 
            resources.ApplyResources(this.acceptcolor, "acceptcolor");
            this.acceptcolor.FlatAppearance.BorderSize = 0;
            this.acceptcolor.Name = "acceptcolor";
            this.acceptcolor.UseVisualStyleBackColor = true;
            this.acceptcolor.Click += new System.EventHandler(this.acceptcolor_Click);
            // 
            // BlueLabel
            // 
            this.BlueLabel.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.BlueLabel, "BlueLabel");
            this.BlueLabel.Name = "BlueLabel";
            // 
            // GreenLabel
            // 
            this.GreenLabel.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.GreenLabel, "GreenLabel");
            this.GreenLabel.Name = "GreenLabel";
            // 
            // RedLabel
            // 
            this.RedLabel.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.RedLabel, "RedLabel");
            this.RedLabel.Name = "RedLabel";
            // 
            // ResultValue
            // 
            resources.ApplyResources(this.ResultValue, "ResultValue");
            this.ResultValue.Name = "ResultValue";
            // 
            // BlueBar
            // 
            resources.ApplyResources(this.BlueBar, "BlueBar");
            this.BlueBar.LargeChange = 5;
            this.BlueBar.Maximum = 259;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scrolling_Scrolls);
            // 
            // GreenBar
            // 
            resources.ApplyResources(this.GreenBar, "GreenBar");
            this.GreenBar.LargeChange = 5;
            this.GreenBar.Maximum = 259;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scrolling_Scrolls);
            // 
            // RedBar
            // 
            resources.ApplyResources(this.RedBar, "RedBar");
            this.RedBar.LargeChange = 5;
            this.RedBar.Maximum = 259;
            this.RedBar.Name = "RedBar";
            this.RedBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scrolling_Scrolls);
            // 
            // ResultColorPanel
            // 
            this.ResultColorPanel.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ResultColorPanel, "ResultColorPanel");
            this.ResultColorPanel.Name = "ResultColorPanel";
            // 
            // ColorSwatch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoAccept);
            this.Controls.Add(this.acceptcolor);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.ResultValue);
            this.Controls.Add(this.BlueBar);
            this.Controls.Add(this.GreenBar);
            this.Controls.Add(this.RedBar);
            this.Controls.Add(this.ResultColorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorSwatch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ColorSwatch_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorSwatch_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorSwatch_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button NoAccept;
        internal System.Windows.Forms.Button acceptcolor;
        internal System.Windows.Forms.Label BlueLabel;
        internal System.Windows.Forms.Label GreenLabel;
        internal System.Windows.Forms.Label RedLabel;
        internal System.Windows.Forms.Label ResultValue;
        internal System.Windows.Forms.HScrollBar BlueBar;
        internal System.Windows.Forms.HScrollBar GreenBar;
        internal System.Windows.Forms.HScrollBar RedBar;
        internal System.Windows.Forms.Panel ResultColorPanel;
    }
}