namespace kv_ur_vis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fielda = new System.Windows.Forms.TextBox();
            this.fieldb = new System.Windows.Forms.TextBox();
            this.fieldc = new System.Windows.Forms.TextBox();
            this.lx1 = new System.Windows.Forms.Label();
            this.lx2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lNoslove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "x² + ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(129, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = " x + ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(201, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = " = 0";
            // 
            // fielda
            // 
            this.fielda.Location = new System.Drawing.Point(12, 12);
            this.fielda.Name = "fielda";
            this.fielda.Size = new System.Drawing.Size(32, 20);
            this.fielda.TabIndex = 3;
            this.fielda.Enter += new System.EventHandler(this.getFocusTB);
            // 
            // fieldb
            // 
            this.fieldb.Location = new System.Drawing.Point(91, 12);
            this.fieldb.Name = "fieldb";
            this.fieldb.Size = new System.Drawing.Size(32, 20);
            this.fieldb.TabIndex = 4;
            this.fieldb.Enter += new System.EventHandler(this.getFocusTB);
            // 
            // fieldc
            // 
            this.fieldc.Location = new System.Drawing.Point(163, 12);
            this.fieldc.Name = "fieldc";
            this.fieldc.Size = new System.Drawing.Size(32, 20);
            this.fieldc.TabIndex = 5;
            this.fieldc.Enter += new System.EventHandler(this.getFocusTB);
            // 
            // lx1
            // 
            this.lx1.AutoSize = true;
            this.lx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lx1.Location = new System.Drawing.Point(9, 39);
            this.lx1.Name = "lx1";
            this.lx1.Size = new System.Drawing.Size(0, 17);
            this.lx1.TabIndex = 6;
            this.lx1.Visible = false;
            // 
            // lx2
            // 
            this.lx2.AutoSize = true;
            this.lx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lx2.Location = new System.Drawing.Point(9, 73);
            this.lx2.Name = "lx2";
            this.lx2.Size = new System.Drawing.Size(0, 17);
            this.lx2.TabIndex = 7;
            this.lx2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lNoslove
            // 
            this.lNoslove.AutoSize = true;
            this.lNoslove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNoslove.Location = new System.Drawing.Point(9, 56);
            this.lNoslove.Name = "lNoslove";
            this.lNoslove.Size = new System.Drawing.Size(99, 17);
            this.lNoslove.TabIndex = 11;
            this.lNoslove.Text = "Решений нет.";
            this.lNoslove.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lNoslove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lx2);
            this.Controls.Add(this.lx1);
            this.Controls.Add(this.fieldc);
            this.Controls.Add(this.fieldb);
            this.Controls.Add(this.fielda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение квадратных уравнений";
            this.Enter += new System.EventHandler(this.getFocusTB);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fielda;
        private System.Windows.Forms.TextBox fieldb;
        private System.Windows.Forms.TextBox fieldc;
        private System.Windows.Forms.Label lx1;
        private System.Windows.Forms.Label lx2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lNoslove;
    }
}

