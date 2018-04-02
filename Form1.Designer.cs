namespace TicketPrint
{
    partial class Check_in
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
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewTicket = new System.Windows.Forms.DataGridView();
            this.IMPRIMIR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(106, 118);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(111, 39);
            this.BtnSend.TabIndex = 0;
            this.BtnSend.Text = "IMPRIMIR";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtCode
            // 
            this.TxtCode.HideSelection = false;
            this.TxtCode.Location = new System.Drawing.Point(78, 33);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.ReadOnly = true;
            this.TxtCode.Size = new System.Drawing.Size(182, 20);
            this.TxtCode.TabIndex = 1;
            this.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(78, 64);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(182, 20);
            this.TxtDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // DataGridViewTicket
            // 
            this.DataGridViewTicket.AllowUserToAddRows = false;
            this.DataGridViewTicket.AllowUserToDeleteRows = false;
            this.DataGridViewTicket.AllowUserToOrderColumns = true;
            this.DataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMPRIMIR});
            this.DataGridViewTicket.Location = new System.Drawing.Point(314, 12);
            this.DataGridViewTicket.Name = "DataGridViewTicket";
            this.DataGridViewTicket.ReadOnly = true;
            this.DataGridViewTicket.Size = new System.Drawing.Size(361, 185);
            this.DataGridViewTicket.TabIndex = 5;
            this.DataGridViewTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTicket_CellContentClick);
            // 
            // IMPRIMIR
            // 
            this.IMPRIMIR.HeaderText = "IMPRIMIR";
            this.IMPRIMIR.Name = "IMPRIMIR";
            this.IMPRIMIR.ReadOnly = true;
            this.IMPRIMIR.Text = "IMPRIMIR";
            this.IMPRIMIR.ToolTipText = "IMPRIMIR";
            this.IMPRIMIR.UseColumnTextForButtonValue = true;
            // 
            // Check_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 209);
            this.Controls.Add(this.DataGridViewTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.BtnSend);
            this.Name = "Check_in";
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridViewTicket;
        private System.Windows.Forms.DataGridViewButtonColumn IMPRIMIR;
    }
}

