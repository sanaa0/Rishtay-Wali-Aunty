namespace WindowsFormsApplication1
{
    partial class paid
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
            this.payment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.rISHTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sentlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid_status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ALLOW_ACCESS = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rISHTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentlistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(161, 269);
            this.dataGridView1.TabIndex = 2;
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Location = new System.Drawing.Point(247, 25);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(81, 13);
            this.payment.TabIndex = 3;
            this.payment.Text = "payment status ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "notifications";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.paid_status,
            this.ALLOW_ACCESS});
            this.dataGridView3.DataSource = this.sentlistBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(229, 131);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(345, 269);
            this.dataGridView3.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 447);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "back to profile";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "give access";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rISHTABindingSource
            // 
            this.rISHTABindingSource.DataSource = typeof(WindowsFormsApplication1.serveraunty.RISHTA);
            // 
            // sentlistBindingSource
            // 
            this.sentlistBindingSource.DataMember = "sentlist";
            this.sentlistBindingSource.DataSource = this.rISHTABindingSource;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // paid_status
            // 
            this.paid_status.HeaderText = "paid_status";
            this.paid_status.Name = "paid_status";
            this.paid_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.paid_status.Text = "PAID";
            this.paid_status.UseColumnTextForButtonValue = true;
            // 
            // ALLOW_ACCESS
            // 
            this.ALLOW_ACCESS.HeaderText = "ALLOW_ACCESS";
            this.ALLOW_ACCESS.Name = "ALLOW_ACCESS";
            this.ALLOW_ACCESS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ALLOW_ACCESS.Text = "ALLOW ACCESS";
            this.ALLOW_ACCESS.UseColumnTextForButtonValue = true;
            // 
            // paid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.dataGridView1);
            this.Name = "paid";
            this.Text = "paid";
            this.Load += new System.EventHandler(this.paid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rISHTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentlistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rISHTABindingSource;
        private System.Windows.Forms.BindingSource sentlistBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn paid_status;
        private System.Windows.Forms.DataGridViewButtonColumn ALLOW_ACCESS;
    }
}