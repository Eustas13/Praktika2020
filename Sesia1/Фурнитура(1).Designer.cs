namespace Sesia1
{
    partial class Фурнитура_1_
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
            this.партияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулфурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фурнитураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складфурнитурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фурнитураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складфурнитурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.партияDataGridViewTextBoxColumn,
            this.артикулфурнитурыDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.фурнитураDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.складфурнитурыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // партияDataGridViewTextBoxColumn
            // 
            this.партияDataGridViewTextBoxColumn.DataPropertyName = "Партия";
            this.партияDataGridViewTextBoxColumn.HeaderText = "Партия";
            this.партияDataGridViewTextBoxColumn.Name = "партияDataGridViewTextBoxColumn";
            this.партияDataGridViewTextBoxColumn.Width = 130;
            // 
            // артикулфурнитурыDataGridViewTextBoxColumn
            // 
            this.артикулфурнитурыDataGridViewTextBoxColumn.DataPropertyName = "Артикул_фурнитуры";
            this.артикулфурнитурыDataGridViewTextBoxColumn.HeaderText = "Артикул фурнитуры";
            this.артикулфурнитурыDataGridViewTextBoxColumn.Name = "артикулфурнитурыDataGridViewTextBoxColumn";
            this.артикулфурнитурыDataGridViewTextBoxColumn.Width = 200;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.Width = 150;
            // 
            // фурнитураDataGridViewTextBoxColumn
            // 
            this.фурнитураDataGridViewTextBoxColumn.DataPropertyName = "Фурнитура";
            this.фурнитураDataGridViewTextBoxColumn.HeaderText = "Фурнитура";
            this.фурнитураDataGridViewTextBoxColumn.Name = "фурнитураDataGridViewTextBoxColumn";
            this.фурнитураDataGridViewTextBoxColumn.Width = 150;
            // 
            // складфурнитурыBindingSource
            // 
            this.складфурнитурыBindingSource.DataSource = typeof(Sesia1.Склад_фурнитуры);
            // 
            // фурнитураBindingSource
            // 
            this.фурнитураBindingSource.DataSource = typeof(Sesia1.Фурнитура);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Фурнитура_1_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Фурнитура_1_";
            this.Text = "Фурнитура_1_";
            this.Load += new System.EventHandler(this.Фурнитура_1__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складфурнитурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn партияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулфурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фурнитураDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource складфурнитурыBindingSource;
        private System.Windows.Forms.BindingSource фурнитураBindingSource;
        private System.Windows.Forms.Button button1;
    }
}