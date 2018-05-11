namespace RegisterationOfUser
{
    partial class acceptReq
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rISHTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receivedlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colIgnore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAccpt = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rISHTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedlistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.colView,
            this.colIgnore,
            this.colAccpt});
            this.dataGridView1.DataSource = this.receivedlistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 213);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOTIFICATIONS";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(375, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back To Profile";
            // 
            // rISHTABindingSource
            // 
            this.rISHTABindingSource.DataSource = typeof(RegisterationOfUser.serveraunty.RISHTA);
            // 
            // receivedlistBindingSource
            // 
            this.receivedlistBindingSource.DataMember = "Receivedlist";
            this.receivedlistBindingSource.DataSource = this.rISHTABindingSource;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // colView
            // 
            this.colView.HeaderText = "View Profile";
            this.colView.Name = "colView";
            this.colView.Text = "View Profile";
            this.colView.UseColumnTextForLinkValue = true;
            // 
            // colIgnore
            // 
            this.colIgnore.HeaderText = "Ignore";
            this.colIgnore.Name = "colIgnore";
            // 
            // colAccpt
            // 
            this.colAccpt.HeaderText = "Accept";
            this.colAccpt.Name = "colAccpt";
            this.colAccpt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccpt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAccpt.Text = "Accept";
            this.colAccpt.UseColumnTextForButtonValue = true;
            // 
            // acceptReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 332);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "acceptReq";
            this.Text = "acceptReq";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rISHTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedlistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn colView;
        private System.Windows.Forms.DataGridViewButtonColumn colIgnore;
        private System.Windows.Forms.DataGridViewButtonColumn colAccpt;
        private System.Windows.Forms.BindingSource receivedlistBindingSource;
        private System.Windows.Forms.BindingSource rISHTABindingSource;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}