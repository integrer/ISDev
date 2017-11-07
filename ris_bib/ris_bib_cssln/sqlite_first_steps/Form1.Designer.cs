namespace sqlite_first_steps
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
			this.menu = new System.Windows.Forms.MenuStrip();
			this.connectItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.editBox = new System.Windows.Forms.GroupBox();
			this.lProduct = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.editBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectItem,
            this.refreshItem,
            this.addItem,
            this.editItem,
            this.deleteItem});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(292, 24);
			this.menu.TabIndex = 0;
			this.menu.Text = "menuStrip1";
			// 
			// connectItem
			// 
			this.connectItem.Name = "connectItem";
			this.connectItem.Size = new System.Drawing.Size(59, 20);
			this.connectItem.Text = "Connect";
			// 
			// refreshItem
			// 
			this.refreshItem.Enabled = false;
			this.refreshItem.Name = "refreshItem";
			this.refreshItem.Size = new System.Drawing.Size(57, 20);
			this.refreshItem.Text = "Refresh";
			// 
			// addItem
			// 
			this.addItem.Enabled = false;
			this.addItem.Name = "addItem";
			this.addItem.Size = new System.Drawing.Size(38, 20);
			this.addItem.Text = "Add";
			// 
			// editItem
			// 
			this.editItem.Enabled = false;
			this.editItem.Name = "editItem";
			this.editItem.Size = new System.Drawing.Size(37, 20);
			this.editItem.Text = "Edit";
			// 
			// deleteItem
			// 
			this.deleteItem.Enabled = false;
			this.deleteItem.Name = "deleteItem";
			this.deleteItem.Size = new System.Drawing.Size(50, 20);
			this.deleteItem.Text = "Delete";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 164);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(268, 150);
			this.dataGridView1.TabIndex = 1;
			// 
			// editBox
			// 
			this.editBox.Controls.Add(this.button2);
			this.editBox.Controls.Add(this.button1);
			this.editBox.Controls.Add(this.numericUpDown2);
			this.editBox.Controls.Add(this.numericUpDown1);
			this.editBox.Controls.Add(this.label2);
			this.editBox.Controls.Add(this.label1);
			this.editBox.Controls.Add(this.textBox1);
			this.editBox.Controls.Add(this.lProduct);
			this.editBox.Location = new System.Drawing.Point(12, 27);
			this.editBox.Name = "editBox";
			this.editBox.Size = new System.Drawing.Size(268, 131);
			this.editBox.TabIndex = 2;
			this.editBox.TabStop = false;
			this.editBox.Text = "E&diting...";
			// 
			// lProduct
			// 
			this.lProduct.AutoSize = true;
			this.lProduct.Location = new System.Drawing.Point(8, 22);
			this.lProduct.Name = "lProduct";
			this.lProduct.Size = new System.Drawing.Size(44, 13);
			this.lProduct.TabIndex = 0;
			this.lProduct.Text = "Product";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(97, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(165, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Price";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Count";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(97, 46);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(165, 20);
			this.numericUpDown1.TabIndex = 5;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(97, 72);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(165, 20);
			this.numericUpDown2.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(187, 99);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(106, 99);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Ok";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 324);
			this.Controls.Add(this.editBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menu);
			this.MainMenuStrip = this.menu;
			this.Name = "Form1";
			this.Text = "DataBase Editor";
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.editBox.ResumeLayout(false);
			this.editBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem connectItem;
		private System.Windows.Forms.ToolStripMenuItem refreshItem;
		private System.Windows.Forms.ToolStripMenuItem addItem;
		private System.Windows.Forms.ToolStripMenuItem editItem;
		private System.Windows.Forms.ToolStripMenuItem deleteItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox editBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lProduct;
	}
}

