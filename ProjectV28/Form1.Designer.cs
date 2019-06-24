namespace ProjectV28
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButon = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.saveButton2 = new System.Windows.Forms.Button();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.addButton2 = new System.Windows.Forms.Button();
            this.saveButton3 = new System.Windows.Forms.Button();
            this.deleteButton3 = new System.Windows.Forms.Button();
            this.addButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(301, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseDoubleClick);
            // 
            // addButon
            // 
            this.addButon.Location = new System.Drawing.Point(17, 168);
            this.addButon.Name = "addButon";
            this.addButon.Size = new System.Drawing.Size(96, 23);
            this.addButon.TabIndex = 1;
            this.addButon.Text = "Добавить";
            this.addButon.UseVisualStyleBackColor = true;
            this.addButon.Click += new System.EventHandler(this.AddButon_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(119, 168);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(222, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(354, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(353, 150);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView2_RowHeaderMouseDoubleClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(714, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(404, 150);
            this.dataGridView3.TabIndex = 5;
            // 
            // saveButton2
            // 
            this.saveButton2.Location = new System.Drawing.Point(558, 168);
            this.saveButton2.Name = "saveButton2";
            this.saveButton2.Size = new System.Drawing.Size(96, 23);
            this.saveButton2.TabIndex = 8;
            this.saveButton2.Text = "Сохранить";
            this.saveButton2.UseVisualStyleBackColor = true;
            // 
            // deleteButton2
            // 
            this.deleteButton2.Location = new System.Drawing.Point(456, 168);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(97, 23);
            this.deleteButton2.TabIndex = 7;
            this.deleteButton2.Text = "Удалить";
            this.deleteButton2.UseVisualStyleBackColor = true;
            // 
            // addButton2
            // 
            this.addButton2.Location = new System.Drawing.Point(354, 168);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(96, 23);
            this.addButton2.TabIndex = 6;
            this.addButton2.Text = "Добавить";
            this.addButton2.UseVisualStyleBackColor = true;
            // 
            // saveButton3
            // 
            this.saveButton3.Location = new System.Drawing.Point(1004, 168);
            this.saveButton3.Name = "saveButton3";
            this.saveButton3.Size = new System.Drawing.Size(114, 23);
            this.saveButton3.TabIndex = 11;
            this.saveButton3.Text = "Сохранить";
            this.saveButton3.UseVisualStyleBackColor = true;
            // 
            // deleteButton3
            // 
            this.deleteButton3.Location = new System.Drawing.Point(883, 168);
            this.deleteButton3.Name = "deleteButton3";
            this.deleteButton3.Size = new System.Drawing.Size(115, 23);
            this.deleteButton3.TabIndex = 10;
            this.deleteButton3.Text = "Удалить";
            this.deleteButton3.UseVisualStyleBackColor = true;
            // 
            // addButton3
            // 
            this.addButton3.Location = new System.Drawing.Point(763, 168);
            this.addButton3.Name = "addButton3";
            this.addButton3.Size = new System.Drawing.Size(114, 23);
            this.addButton3.TabIndex = 9;
            this.addButton3.Text = "Добавить";
            this.addButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(155, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton3);
            this.Controls.Add(this.deleteButton3);
            this.Controls.Add(this.addButton3);
            this.Controls.Add(this.saveButton2);
            this.Controls.Add(this.deleteButton2);
            this.Controls.Add(this.addButton2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButon);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButon;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button saveButton2;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.Button saveButton3;
        private System.Windows.Forms.Button deleteButton3;
        private System.Windows.Forms.Button addButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

