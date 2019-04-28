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
            this.notif = new System.Windows.Forms.TextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.savebtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.Settings = new MaterialSkin.Controls.MaterialFlatButton();
            this.helpbtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // notif
            // 
            this.notif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notif.Enabled = false;
            this.notif.Location = new System.Drawing.Point(198, 238);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(121, 20);
            this.notif.TabIndex = 5;
            this.notif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notif.TextChanged += new System.EventHandler(this.notif_TextChanged);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(39, 101);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(115, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Import Config";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // savebtn
            // 
            this.savebtn.AutoSize = true;
            this.savebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savebtn.Depth = 0;
            this.savebtn.Location = new System.Drawing.Point(220, 101);
            this.savebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.savebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.savebtn.Name = "savebtn";
            this.savebtn.Primary = false;
            this.savebtn.Size = new System.Drawing.Size(99, 36);
            this.savebtn.TabIndex = 8;
            this.savebtn.Text = "Load Config";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Settings.Depth = 0;
            this.Settings.Location = new System.Drawing.Point(39, 229);
            this.Settings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.Settings.Name = "Settings";
            this.Settings.Primary = false;
            this.Settings.Size = new System.Drawing.Size(76, 36);
            this.Settings.TabIndex = 9;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click_1);
            // 
            // helpbtn
            // 
            this.helpbtn.AutoSize = true;
            this.helpbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpbtn.Depth = 0;
            this.helpbtn.Location = new System.Drawing.Point(123, 229);
            this.helpbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Primary = false;
            this.helpbtn.Size = new System.Drawing.Size(19, 36);
            this.helpbtn.TabIndex = 10;
            this.helpbtn.Text = "?";
            this.helpbtn.UseVisualStyleBackColor = true;
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 281);
            this.Controls.Add(this.helpbtn);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.notif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "LeagueConfig";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox notif;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton savebtn;
        private MaterialSkin.Controls.MaterialFlatButton Settings;
        private MaterialSkin.Controls.MaterialFlatButton helpbtn;
    }
}