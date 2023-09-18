namespace NewDewey
{
    partial class Panel_Slide
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
            this.panel = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.button_repbooks = new System.Windows.Forms.Button();
            this.button_idarea = new System.Windows.Forms.Button();
            this.button_fndarea = new System.Windows.Forms.Button();
            this.button_ext = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel.Controls.Add(this.button_ext);
            this.panel.Controls.Add(this.button_fndarea);
            this.panel.Controls.Add(this.button_idarea);
            this.panel.Controls.Add(this.button_repbooks);
            this.panel.Controls.Add(this.panel_logo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(180, 623);
            this.panel.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(180, 100);
            this.panel_logo.TabIndex = 1;
            // 
            // button_repbooks
            // 
            this.button_repbooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_repbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_repbooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_repbooks.ForeColor = System.Drawing.Color.White;
            this.button_repbooks.Location = new System.Drawing.Point(0, 100);
            this.button_repbooks.Name = "button_repbooks";
            this.button_repbooks.Size = new System.Drawing.Size(180, 50);
            this.button_repbooks.TabIndex = 2;
            this.button_repbooks.Text = "Replace Books";
            this.button_repbooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_repbooks.UseVisualStyleBackColor = true;
            // 
            // button_idarea
            // 
            this.button_idarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_idarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_idarea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_idarea.ForeColor = System.Drawing.Color.White;
            this.button_idarea.Location = new System.Drawing.Point(0, 150);
            this.button_idarea.Name = "button_idarea";
            this.button_idarea.Size = new System.Drawing.Size(180, 50);
            this.button_idarea.TabIndex = 3;
            this.button_idarea.Text = "Identify Area";
            this.button_idarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_idarea.UseVisualStyleBackColor = true;
            // 
            // button_fndarea
            // 
            this.button_fndarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_fndarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fndarea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fndarea.ForeColor = System.Drawing.Color.White;
            this.button_fndarea.Location = new System.Drawing.Point(0, 200);
            this.button_fndarea.Name = "button_fndarea";
            this.button_fndarea.Size = new System.Drawing.Size(180, 50);
            this.button_fndarea.TabIndex = 4;
            this.button_fndarea.Text = "Find Call Area";
            this.button_fndarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_fndarea.UseVisualStyleBackColor = true;
            // 
            // button_ext
            // 
            this.button_ext.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ext.ForeColor = System.Drawing.Color.White;
            this.button_ext.Location = new System.Drawing.Point(0, 250);
            this.button_ext.Name = "button_ext";
            this.button_ext.Size = new System.Drawing.Size(180, 50);
            this.button_ext.TabIndex = 5;
            this.button_ext.Text = "Exit";
            this.button_ext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ext.UseVisualStyleBackColor = true;
            // 
            // Panel_Slide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 623);
            this.Controls.Add(this.panel);
            this.Name = "Panel_Slide";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_repbooks;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button button_ext;
        private System.Windows.Forms.Button button_fndarea;
        private System.Windows.Forms.Button button_idarea;
    }
}

