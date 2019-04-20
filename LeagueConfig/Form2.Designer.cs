namespace LeagueConfig
{
    partial class Form2
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
            this.Loadbtn = new System.Windows.Forms.Button();
            this.restorebtn = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(189, 40);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(121, 33);
            this.Loadbtn.TabIndex = 0;
            this.Loadbtn.Text = "Load Settings";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // restorebtn
            // 
            this.restorebtn.Location = new System.Drawing.Point(34, 116);
            this.restorebtn.Name = "restorebtn";
            this.restorebtn.Size = new System.Drawing.Size(121, 33);
            this.restorebtn.TabIndex = 1;
            this.restorebtn.Text = "Restore Settings";
            this.restorebtn.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(189, 116);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(70, 35);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(34, 40);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(121, 33);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Save Settings";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(266, 116);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 35);
            this.help.TabIndex = 4;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 202);
            this.Controls.Add(this.help);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.restorebtn);
            this.Controls.Add(this.Loadbtn);
            this.Name = "Form2";
            this.Text = "LeagueConfig";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button restorebtn;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button help;
    }
}