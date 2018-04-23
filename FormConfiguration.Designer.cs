namespace TicketPrint
{
    partial class FormConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtCodePB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodeUser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.TxtCodePB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtCodeUser);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 173);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Código PB";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(70, 123);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(145, 36);
            this.BtnCreate.TabIndex = 12;
            this.BtnCreate.Text = "CREAR";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtCodePB
            // 
            this.TxtCodePB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodePB.Location = new System.Drawing.Point(147, 88);
            this.TxtCodePB.MaxLength = 5;
            this.TxtCodePB.Name = "TxtCodePB";
            this.TxtCodePB.Size = new System.Drawing.Size(103, 20);
            this.TxtCodePB.TabIndex = 10;
            this.TxtCodePB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodePB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodePB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código de validación";
            // 
            // TxtCodeUser
            // 
            this.TxtCodeUser.Location = new System.Drawing.Point(147, 48);
            this.TxtCodeUser.MaxLength = 30;
            this.TxtCodeUser.Name = "TxtCodeUser";
            this.TxtCodeUser.PasswordChar = '*';
            this.TxtCodeUser.Size = new System.Drawing.Size(103, 20);
            this.TxtCodeUser.TabIndex = 8;
            this.TxtCodeUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 198);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TxtCodePB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodeUser;
    }
}