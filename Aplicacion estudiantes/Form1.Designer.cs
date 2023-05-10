namespace Aplicacion_estudiantes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcarnet = new System.Windows.Forms.Label();
            this.txtbcarnet = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtbnombre = new System.Windows.Forms.TextBox();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblerrorcarnet = new System.Windows.Forms.Label();
            this.lblerrorname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcarnet
            // 
            this.lblcarnet.AutoSize = true;
            this.lblcarnet.BackColor = System.Drawing.Color.Fuchsia;
            this.lblcarnet.Font = new System.Drawing.Font("Britannic Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcarnet.Location = new System.Drawing.Point(110, 70);
            this.lblcarnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcarnet.Name = "lblcarnet";
            this.lblcarnet.Size = new System.Drawing.Size(143, 47);
            this.lblcarnet.TabIndex = 0;
            this.lblcarnet.Text = "Carné ";
            // 
            // txtbcarnet
            // 
            this.txtbcarnet.Location = new System.Drawing.Point(110, 125);
            this.txtbcarnet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbcarnet.Name = "txtbcarnet";
            this.txtbcarnet.Size = new System.Drawing.Size(337, 31);
            this.txtbcarnet.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Lime;
            this.lblnombre.Font = new System.Drawing.Font("Britannic Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnombre.Location = new System.Drawing.Point(110, 220);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(164, 47);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // txtbnombre
            // 
            this.txtbnombre.Location = new System.Drawing.Point(110, 283);
            this.txtbnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbnombre.Name = "txtbnombre";
            this.txtbnombre.Size = new System.Drawing.Size(337, 31);
            this.txtbnombre.TabIndex = 3;
            // 
            // buttonguardar
            // 
            this.buttonguardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonguardar.Font = new System.Drawing.Font("Sitka Banner", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonguardar.Location = new System.Drawing.Point(500, 525);
            this.buttonguardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(200, 70);
            this.buttonguardar.TabIndex = 4;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblerror.Location = new System.Drawing.Point(110, 430);
            this.lblerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(77, 24);
            this.lblerror.TabIndex = 5;
            this.lblerror.Text = "Error";
            this.lblerror.Visible = false;
            // 
            // lblerrorcarnet
            // 
            this.lblerrorcarnet.AutoSize = true;
            this.lblerrorcarnet.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblerrorcarnet.ForeColor = System.Drawing.Color.Red;
            this.lblerrorcarnet.Location = new System.Drawing.Point(110, 170);
            this.lblerrorcarnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblerrorcarnet.Name = "lblerrorcarnet";
            this.lblerrorcarnet.Size = new System.Drawing.Size(71, 21);
            this.lblerrorcarnet.TabIndex = 6;
            this.lblerrorcarnet.Text = "Error";
            this.lblerrorcarnet.Visible = false;
            // 
            // lblerrorname
            // 
            this.lblerrorname.AutoSize = true;
            this.lblerrorname.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblerrorname.ForeColor = System.Drawing.Color.Red;
            this.lblerrorname.Location = new System.Drawing.Point(110, 330);
            this.lblerrorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblerrorname.Name = "lblerrorname";
            this.lblerrorname.Size = new System.Drawing.Size(71, 21);
            this.lblerrorname.TabIndex = 7;
            this.lblerrorname.Text = "Error";
            this.lblerrorname.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(753, 692);
            this.Controls.Add(this.lblerrorname);
            this.Controls.Add(this.lblerrorcarnet);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.txtbnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtbcarnet);
            this.Controls.Add(this.lblcarnet);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblcarnet;
        private TextBox txtbcarnet;
        private Label lblnombre;
        private TextBox txtbnombre;
        private Button buttonguardar;
        private Label lblerror;
        private Label lblerrorcarnet;
        private Label lblerrorname;
    }
}