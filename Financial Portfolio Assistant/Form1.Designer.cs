namespace Financial_Portfolio_Assistant
{
    partial class Form1
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
            System.Windows.Forms.ToolStripLabel toolStripLabel4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayChangeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.indicatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirtyMinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sixHourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneDayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneMonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threeMonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new System.Drawing.Size(92, 22);
            toolStripLabel4.Text = "Total: $21,268.51";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1046, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "Account";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountColumn,
            this.usernameColumn,
            this.equityColumn,
            this.quantityColumn,
            this.priceColumn,
            this.dayChangeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(8, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(966, 256);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AccountColumn
            // 
            this.AccountColumn.HeaderText = "Account";
            this.AccountColumn.MinimumWidth = 8;
            this.AccountColumn.Name = "AccountColumn";
            this.AccountColumn.Width = 150;
            // 
            // usernameColumn
            // 
            this.usernameColumn.HeaderText = "Asset";
            this.usernameColumn.MinimumWidth = 8;
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.Width = 150;
            // 
            // equityColumn
            // 
            this.equityColumn.HeaderText = "Equity";
            this.equityColumn.MinimumWidth = 8;
            this.equityColumn.Name = "equityColumn";
            this.equityColumn.Width = 150;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.MinimumWidth = 8;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 150;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.MinimumWidth = 8;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.Width = 150;
            // 
            // dayChangeColumn
            // 
            this.dayChangeColumn.HeaderText = "% (D)";
            this.dayChangeColumn.MinimumWidth = 8;
            this.dayChangeColumn.Name = "dayChangeColumn";
            this.dayChangeColumn.Width = 150;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            toolStripLabel4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 449);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1046, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(120, 22);
            this.toolStripLabel1.Text = "Robinhood: $5,420.23";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(117, 22);
            this.toolStripLabel2.Text = "Vanguard: $12,423.30";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(110, 22);
            this.toolStripLabel3.Text = "Coinbase: $3,423.98";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indicatorColumn,
            this.thirtyMinColumn,
            this.sixHourColumn,
            this.oneDayColumn,
            this.oneMonthColumn,
            this.threeMonthColumn});
            this.dataGridView2.Location = new System.Drawing.Point(9, 294);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(965, 125);
            this.dataGridView2.TabIndex = 4;
            // 
            // indicatorColumn
            // 
            this.indicatorColumn.HeaderText = "Indicator";
            this.indicatorColumn.MinimumWidth = 8;
            this.indicatorColumn.Name = "indicatorColumn";
            this.indicatorColumn.Width = 150;
            // 
            // thirtyMinColumn
            // 
            this.thirtyMinColumn.HeaderText = "30min";
            this.thirtyMinColumn.MinimumWidth = 8;
            this.thirtyMinColumn.Name = "thirtyMinColumn";
            this.thirtyMinColumn.Width = 150;
            // 
            // sixHourColumn
            // 
            this.sixHourColumn.HeaderText = "6h";
            this.sixHourColumn.MinimumWidth = 8;
            this.sixHourColumn.Name = "sixHourColumn";
            this.sixHourColumn.Width = 150;
            // 
            // oneDayColumn
            // 
            this.oneDayColumn.HeaderText = "1d";
            this.oneDayColumn.MinimumWidth = 8;
            this.oneDayColumn.Name = "oneDayColumn";
            this.oneDayColumn.Width = 150;
            // 
            // oneMonthColumn
            // 
            this.oneMonthColumn.HeaderText = "1m";
            this.oneMonthColumn.MinimumWidth = 8;
            this.oneMonthColumn.Name = "oneMonthColumn";
            this.oneMonthColumn.Width = 150;
            // 
            // threeMonthColumn
            // 
            this.threeMonthColumn.HeaderText = "3m";
            this.threeMonthColumn.MinimumWidth = 8;
            this.threeMonthColumn.Name = "threeMonthColumn";
            this.threeMonthColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 474);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Portfolio Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayChangeColumn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirtyMinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sixHourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneDayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneMonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn threeMonthColumn;
    }
}

