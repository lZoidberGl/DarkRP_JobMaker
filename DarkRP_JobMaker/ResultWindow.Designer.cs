namespace DarkRP_JobMaker
{
    partial class ResultWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultWindow));
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.Refresher = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            resources.ApplyResources(this.ResultBox, "ResultBox");
            this.ResultBox.Name = "ResultBox";
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HideButton
            // 
            resources.ApplyResources(this.HideButton, "HideButton");
            this.HideButton.Name = "HideButton";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // Refresher
            // 
            this.Refresher.Interval = 25;
            this.Refresher.Tick += new System.EventHandler(this.Refresh_Tick);
            // 
            // ResultWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultWindow";
            this.Activated += new System.EventHandler(this.ResultWindow_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResultWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Timer Refresher;
    }
}