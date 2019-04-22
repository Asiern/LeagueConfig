namespace LeagueConfig
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Savebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.settingspath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(152, 114);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(143, 38);
            this.Savebtn.TabIndex = 4;
            this.Savebtn.Text = "Save Settings";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settingspath
            // 
            this.settingspath.Location = new System.Drawing.Point(46, 45);
            this.settingspath.Name = "settingspath";
            this.settingspath.Size = new System.Drawing.Size(269, 20);
            this.settingspath.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 181);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.settingspath);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox settingspath;
    }
}

