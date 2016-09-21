namespace DarkRP_JobMaker
{
    partial class WeaponSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponSelector));
            this.HideButton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HideButton
            // 
            resources.ApplyResources(this.HideButton, "HideButton");
            this.HideButton.ForeColor = System.Drawing.Color.Red;
            this.HideButton.Name = "HideButton";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // Exitbutton
            // 
            resources.ApplyResources(this.Exitbutton, "Exitbutton");
            this.Exitbutton.ForeColor = System.Drawing.Color.Red;
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // WeaponSelector
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.Exitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeaponSelector";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WeaponSelector_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WeaponSelector_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button Exitbutton;
    }
}