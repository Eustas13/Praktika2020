namespace Sesia1
{
    partial class Ткани
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
            this.рулонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикултканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ширинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тканьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складтканиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складтканиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.рулонDataGridViewTextBoxColumn,
            this.артикултканиDataGridViewTextBoxColumn,
            this.длинаDataGridViewTextBoxColumn,
            this.ширинаDataGridViewTextBoxColumn,
            this.тканьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.складтканиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // рулонDataGridViewTextBoxColumn
            // 
            this.рулонDataGridViewTextBoxColumn.DataPropertyName = "Рулон";
            this.рулонDataGridViewTextBoxColumn.HeaderText = "Рулон";
            this.рулонDataGridViewTextBoxColumn.Name = "рулонDataGridViewTextBoxColumn";
            this.рулонDataGridViewTextBoxColumn.Width = 130;
            // 
            // артикултканиDataGridViewTextBoxColumn
            // 
            this.артикултканиDataGridViewTextBoxColumn.DataPropertyName = "Артикул_ткани";
            this.артикултканиDataGridViewTextBoxColumn.HeaderText = "Артикул ткани";
            this.артикултканиDataGridViewTextBoxColumn.Name = "артикултканиDataGridViewTextBoxColumn";
            this.артикултканиDataGridViewTextBoxColumn.Width = 150;
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            this.длинаDataGridViewTextBoxColumn.Width = 130;
            // 
            // ширинаDataGridViewTextBoxColumn
            // 
            this.ширинаDataGridViewTextBoxColumn.DataPropertyName = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.HeaderText = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.Name = "ширинаDataGridViewTextBoxColumn";
            this.ширинаDataGridViewTextBoxColumn.Width = 130;
            // 
            // тканьDataGridViewTextBoxColumn
            // 
            this.тканьDataGridViewTextBoxColumn.DataPropertyName = "Ткань";
            this.тканьDataGridViewTextBoxColumn.HeaderText = "Ткань";
            this.тканьDataGridViewTextBoxColumn.Name = "тканьDataGridViewTextBoxColumn";
            this.тканьDataGridViewTextBoxColumn.Width = 130;
            // 
            // складтканиBindingSource
            // 
            this.складтканиBindingSource.DataSource = typeof(Sesia1.Склад_ткани);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(4, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(280, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Список тканей";
            // 
            // Ткани
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ткани";
            this.Text = "Ткани";
            this.Load += new System.EventHandler(this.Ткани_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складтканиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource складтканиBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn рулонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикултканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ширинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тканьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}