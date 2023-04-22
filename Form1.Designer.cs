namespace examin_typa
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
            this.animals_datagrid = new System.Windows.Forms.DataGridView();
            this.sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animals_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // animals_datagrid
            // 
            this.animals_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animals_datagrid.Location = new System.Drawing.Point(73, 24);
            this.animals_datagrid.Name = "animals_datagrid";
            this.animals_datagrid.Size = new System.Drawing.Size(594, 315);
            this.animals_datagrid.TabIndex = 0;
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(259, 372);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(185, 23);
            this.sort.TabIndex = 1;
            this.sort.Text = "сортировать по локации";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.animals_datagrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.animals_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView animals_datagrid;
        private System.Windows.Forms.Button sort;
    }
}

