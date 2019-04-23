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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Settings = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.notif = new System.Windows.Forms.TextBox();
            this.importbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(12, 165);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(85, 25);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(172, 84);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(121, 33);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Load Config";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(103, 165);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(30, 25);
            this.help.TabIndex = 4;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // notif
            // 
            this.notif.Enabled = false;
            this.notif.Location = new System.Drawing.Point(172, 165);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(121, 20);
            this.notif.TabIndex = 5;
            // 
            // importbtn
            // 
            this.importbtn.Location = new System.Drawing.Point(12, 84);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new System.Drawing.Size(121, 33);
            this.importbtn.TabIndex = 6;
            this.importbtn.Text = "Import Config";
            this.importbtn.UseVisualStyleBackColor = true;
            this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 205);
            this.Controls.Add(this.importbtn);
            this.Controls.Add(this.notif);
            this.Controls.Add(this.help);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "LeagueConfig";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.TextBox notif;
        private System.Windows.Forms.Button importbtn;
    }
}