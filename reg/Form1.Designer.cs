namespace reg
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView_reg = new System.Windows.Forms.TreeView();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строковыйПараметрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_value = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_reg
            // 
            this.treeView_reg.Location = new System.Drawing.Point(12, 12);
            this.treeView_reg.Name = "treeView_reg";
            this.treeView_reg.Size = new System.Drawing.Size(951, 355);
            this.treeView_reg.TabIndex = 0;
            this.treeView_reg.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_reg_BeforeExpand);
            this.treeView_reg.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_reg_NodeMouseClick);
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.AllowUserToAddRows = false;
            this.dataGridView_data.AllowUserToDeleteRows = false;
            this.dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Change,
            this.Column3});
            this.dataGridView_data.Location = new System.Drawing.Point(12, 373);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.Size = new System.Drawing.Size(951, 141);
            this.dataGridView_data.TabIndex = 0;
            this.dataGridView_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_data_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Имя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Значение";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Change
            // 
            this.Change.HeaderText = "Change";
            this.Change.Name = "Change";
            this.Change.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Change.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Change.Text = "Change";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Delete";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Text = "Delete";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 48);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разделToolStripMenuItem,
            this.строковыйПараметрToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // разделToolStripMenuItem
            // 
            this.разделToolStripMenuItem.Name = "разделToolStripMenuItem";
            this.разделToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.разделToolStripMenuItem.Text = "Раздел";
            this.разделToolStripMenuItem.Click += new System.EventHandler(this.разделToolStripMenuItem_Click);
            // 
            // строковыйПараметрToolStripMenuItem
            // 
            this.строковыйПараметрToolStripMenuItem.Name = "строковыйПараметрToolStripMenuItem";
            this.строковыйПараметрToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.строковыйПараметрToolStripMenuItem.Text = "Строковый параметр";
            this.строковыйПараметрToolStripMenuItem.Click += new System.EventHandler(this.строковыйПараметрToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_ok);
            this.panel1.Controls.Add(this.textBox_value);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.label_value);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Location = new System.Drawing.Point(460, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 211);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(163, 163);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(30, 166);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(59, 21);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(134, 95);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(100, 20);
            this.textBox_value.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(131, 48);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(30, 97);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(34, 13);
            this.label_value.TabIndex = 1;
            this.label_value.Text = "Value";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(27, 48);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_data);
            this.Controls.Add(this.treeView_reg);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_reg;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строковыйПараметрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Change;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_cancel;
    }
}

