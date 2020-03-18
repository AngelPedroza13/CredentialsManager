namespace CredentialsManager.WinForms.Forms
{
    partial class Main
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
            this.PanMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GvwCredentials = new System.Windows.Forms.DataGridView();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.PanMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvwCredentials)).BeginInit();
            this.SuspendLayout();
            // 
            // PanMenu
            // 
            this.PanMenu.Controls.Add(this.button1);
            this.PanMenu.Location = new System.Drawing.Point(0, 3);
            this.PanMenu.Name = "PanMenu";
            this.PanMenu.Size = new System.Drawing.Size(764, 42);
            this.PanMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nueva Credencial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GvwCredentials
            // 
            this.GvwCredentials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvwCredentials.Location = new System.Drawing.Point(13, 84);
            this.GvwCredentials.Name = "GvwCredentials";
            this.GvwCredentials.Size = new System.Drawing.Size(743, 232);
            this.GvwCredentials.TabIndex = 1;
            // 
            // lblCredentials
            // 
            this.lblCredentials.AutoSize = true;
            this.lblCredentials.Location = new System.Drawing.Point(15, 56);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(59, 13);
            this.lblCredentials.TabIndex = 2;
            this.lblCredentials.Text = "Credentials";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 337);
            this.Controls.Add(this.lblCredentials);
            this.Controls.Add(this.GvwCredentials);
            this.Controls.Add(this.PanMenu);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvwCredentials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GvwCredentials;
        private System.Windows.Forms.Label lblCredentials;
    }
}