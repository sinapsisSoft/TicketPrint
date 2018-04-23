namespace TicketPrint
{
    partial class FormTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTool));
            this.BtnValidate = new System.Windows.Forms.Button();
            this.TxtCodeUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSequence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodePB = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckNewCode = new System.Windows.Forms.CheckBox();
            this.CheckReset = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnValidate
            // 
            this.BtnValidate.Location = new System.Drawing.Point(162, 37);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(75, 20);
            this.BtnValidate.TabIndex = 0;
            this.BtnValidate.Text = "VALIDAR";
            this.BtnValidate.UseVisualStyleBackColor = true;
            this.BtnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // TxtCodeUser
            // 
            this.TxtCodeUser.Location = new System.Drawing.Point(36, 37);
            this.TxtCodeUser.Name = "TxtCodeUser";
            this.TxtCodeUser.PasswordChar = '*';
            this.TxtCodeUser.Size = new System.Drawing.Size(103, 20);
            this.TxtCodeUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de validación";
            // 
            // TxtSequence
            // 
            this.TxtSequence.Enabled = false;
            this.TxtSequence.Location = new System.Drawing.Point(134, 96);
            this.TxtSequence.MaxLength = 8;
            this.TxtSequence.Name = "TxtSequence";
            this.TxtSequence.Size = new System.Drawing.Size(103, 20);
            this.TxtSequence.TabIndex = 3;
            this.TxtSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSequence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSequence_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Secuencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código PB";
            // 
            // TxtCodePB
            // 
            this.TxtCodePB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodePB.Enabled = false;
            this.TxtCodePB.Location = new System.Drawing.Point(134, 122);
            this.TxtCodePB.MaxLength = 5;
            this.TxtCodePB.Name = "TxtCodePB";
            this.TxtCodePB.Size = new System.Drawing.Size(103, 20);
            this.TxtCodePB.TabIndex = 5;
            this.TxtCodePB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodePB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodePB_KeyPress);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(61, 199);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(134, 36);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "MODIFICAR";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.CheckNewCode);
            this.panel1.Controls.Add(this.CheckReset);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 252);
            this.panel1.TabIndex = 8;
            // 
            // CheckNewCode
            // 
            this.CheckNewCode.AutoSize = true;
            this.CheckNewCode.Enabled = false;
            this.CheckNewCode.Location = new System.Drawing.Point(23, 165);
            this.CheckNewCode.Name = "CheckNewCode";
            this.CheckNewCode.Size = new System.Drawing.Size(94, 17);
            this.CheckNewCode.TabIndex = 9;
            this.CheckNewCode.Text = "Nuevo Código";
            this.CheckNewCode.UseVisualStyleBackColor = true;
            this.CheckNewCode.CheckedChanged += new System.EventHandler(this.CheckNewReference);
            // 
            // CheckReset
            // 
            this.CheckReset.AutoSize = true;
            this.CheckReset.Enabled = false;
            this.CheckReset.Location = new System.Drawing.Point(23, 142);
            this.CheckReset.Name = "CheckReset";
            this.CheckReset.Size = new System.Drawing.Size(113, 17);
            this.CheckReset.TabIndex = 8;
            this.CheckReset.Text = "Reiniciar Contador";
            this.CheckReset.UseVisualStyleBackColor = true;
            this.CheckReset.CheckedChanged += new System.EventHandler(this.CheckValidateRestart);
            // 
            // FormTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 277);
            this.Controls.Add(this.TxtCodePB);
            this.Controls.Add(this.TxtSequence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodeUser);
            this.Controls.Add(this.BtnValidate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herramientas";
            this.Load += new System.EventHandler(this.FormTool_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnValidate;
        private System.Windows.Forms.TextBox TxtCodeUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSequence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodePB;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckReset;
        private System.Windows.Forms.CheckBox CheckNewCode;
    }
}