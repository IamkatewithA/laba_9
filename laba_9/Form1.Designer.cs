namespace laba_9
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BuiltGraph_button = new System.Windows.Forms.Button();
            this.GritColor_button = new System.Windows.Forms.Button();
            this.Legend_button = new System.Windows.Forms.Button();
            this.Point_button = new System.Windows.Forms.Button();
            this.Lines_button = new System.Windows.Forms.Button();
            this.AddData_button = new System.Windows.Forms.Button();
            this.DeleteData_button = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 323);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(20, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(334, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(410, 38);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(522, 323);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraphControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 294);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Точечная диаграмма";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.zedGraphControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(514, 294);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "График";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BuiltGraph_button
            // 
            this.BuiltGraph_button.Location = new System.Drawing.Point(16, 383);
            this.BuiltGraph_button.Name = "BuiltGraph_button";
            this.BuiltGraph_button.Size = new System.Drawing.Size(169, 66);
            this.BuiltGraph_button.TabIndex = 2;
            this.BuiltGraph_button.Text = "Построить графики";
            this.BuiltGraph_button.UseVisualStyleBackColor = true;
            this.BuiltGraph_button.Click += new System.EventHandler(this.BuiltGraph_button_Click);
            // 
            // GritColor_button
            // 
            this.GritColor_button.Location = new System.Drawing.Point(201, 383);
            this.GritColor_button.Name = "GritColor_button";
            this.GritColor_button.Size = new System.Drawing.Size(169, 66);
            this.GritColor_button.TabIndex = 3;
            this.GritColor_button.Text = "Цвет сетки осей";
            this.GritColor_button.UseVisualStyleBackColor = true;
            this.GritColor_button.Click += new System.EventHandler(this.GritColor_button_Click);
            // 
            // Legend_button
            // 
            this.Legend_button.Location = new System.Drawing.Point(395, 383);
            this.Legend_button.Name = "Legend_button";
            this.Legend_button.Size = new System.Drawing.Size(169, 66);
            this.Legend_button.TabIndex = 4;
            this.Legend_button.Text = "Положение легенды";
            this.Legend_button.UseVisualStyleBackColor = true;
            this.Legend_button.Click += new System.EventHandler(this.Legend_button_Click);
            // 
            // Point_button
            // 
            this.Point_button.Location = new System.Drawing.Point(579, 383);
            this.Point_button.Name = "Point_button";
            this.Point_button.Size = new System.Drawing.Size(169, 66);
            this.Point_button.TabIndex = 5;
            this.Point_button.Text = "Цвет обводки";
            this.Point_button.UseVisualStyleBackColor = true;
            this.Point_button.Click += new System.EventHandler(this.Point_button_Click);
            // 
            // Lines_button
            // 
            this.Lines_button.Location = new System.Drawing.Point(763, 383);
            this.Lines_button.Name = "Lines_button";
            this.Lines_button.Size = new System.Drawing.Size(169, 66);
            this.Lines_button.TabIndex = 6;
            this.Lines_button.Text = "Цвет линий";
            this.Lines_button.UseVisualStyleBackColor = true;
            this.Lines_button.Click += new System.EventHandler(this.Lines_button_Click);
            // 
            // AddData_button
            // 
            this.AddData_button.Location = new System.Drawing.Point(278, 12);
            this.AddData_button.Name = "AddData_button";
            this.AddData_button.Size = new System.Drawing.Size(47, 45);
            this.AddData_button.TabIndex = 7;
            this.AddData_button.Text = "+";
            this.AddData_button.UseVisualStyleBackColor = true;
            this.AddData_button.Click += new System.EventHandler(this.AddData_button_Click);
            // 
            // DeleteData_button
            // 
            this.DeleteData_button.Location = new System.Drawing.Point(331, 12);
            this.DeleteData_button.Name = "DeleteData_button";
            this.DeleteData_button.Size = new System.Drawing.Size(47, 45);
            this.DeleteData_button.TabIndex = 2;
            this.DeleteData_button.Text = "-";
            this.DeleteData_button.UseVisualStyleBackColor = true;
            this.DeleteData_button.Click += new System.EventHandler(this.DeleteData_button_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(-4, 0);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(522, 290);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(518, 298);
            this.zedGraphControl2.TabIndex = 0;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 489);
            this.Controls.Add(this.DeleteData_button);
            this.Controls.Add(this.AddData_button);
            this.Controls.Add(this.Lines_button);
            this.Controls.Add(this.Point_button);
            this.Controls.Add(this.Legend_button);
            this.Controls.Add(this.GritColor_button);
            this.Controls.Add(this.BuiltGraph_button);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BuiltGraph_button;
        private System.Windows.Forms.Button GritColor_button;
        private System.Windows.Forms.Button Legend_button;
        private System.Windows.Forms.Button Point_button;
        private System.Windows.Forms.Button Lines_button;
        private System.Windows.Forms.Button AddData_button;
        private System.Windows.Forms.Button DeleteData_button;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

