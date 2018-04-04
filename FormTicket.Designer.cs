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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_in));
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewTicket = new System.Windows.Forms.DataGridView();
            this.IMPRIMIR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnTool = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTool)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(80, 141);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(125, 50);
            this.BtnSend.TabIndex = 0;
            this.BtnSend.Text = "IMPRIMIR";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCode.HideSelection = false;
            this.TxtCode.Location = new System.Drawing.Point(40, 97);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.ReadOnly = true;
            this.TxtCode.Size = new System.Drawing.Size(216, 29);
            this.TxtCode.TabIndex = 1;
            this.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // DataGridViewTicket
            // 
            this.DataGridViewTicket.AllowUserToAddRows = false;
            this.DataGridViewTicket.AllowUserToDeleteRows = false;
            this.DataGridViewTicket.AllowUserToOrderColumns = true;
            this.DataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMPRIMIR});
            this.DataGridViewTicket.Location = new System.Drawing.Point(287, 77);
            this.DataGridViewTicket.Name = "DataGridViewTicket";
            this.DataGridViewTicket.ReadOnly = true;
            this.DataGridViewTicket.Size = new System.Drawing.Size(349, 185);
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
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Seleccionar",
            "Código",
            "Fecha"});
            this.comboBoxSearch.Location = new System.Drawing.Point(287, 42);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(414, 43);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(134, 20);
            this.TxtSearch.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dato";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(549, 31);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 10;
            this.BtnSearch.Text = "BUSCAR";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnTool
            // 
            this.BtnTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTool.ErrorImage = null;
            this.BtnTool.Image = ((System.Drawing.Image)(resources.GetObject("BtnTool.Image")));
            this.BtnTool.InitialImage = null;
            this.BtnTool.Location = new System.Drawing.Point(12, 9);
            this.BtnTool.Name = "BtnTool";
            this.BtnTool.Size = new System.Drawing.Size(32, 32);
            this.BtnTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnTool.TabIndex = 11;
            this.BtnTool.TabStop = false;
            this.BtnTool.Click += new System.EventHandler(this.BtnTool_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.BtnTool);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 271);
            this.panel1.TabIndex = 12;
            // 
            // Check_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(669, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.DataGridViewTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Check_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTool)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewTicket;
        private System.Windows.Forms.DataGridViewButtonColumn IMPRIMIR;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.PictureBox BtnTool;
        private System.Windows.Forms.Panel panel1;
    }
}

