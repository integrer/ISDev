namespace pw3_DB
{
	partial class fLogin
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
			this.tbServPass = new System.Windows.Forms.TextBox();
			this.tbDBName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbUserName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bLogin = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Адрес сервера";
			// 
			// tbServPass
			// 
			this.tbServPass.Location = new System.Drawing.Point(121, 13);
			this.tbServPass.Name = "tbServPass";
			this.tbServPass.Size = new System.Drawing.Size(159, 20);
			this.tbServPass.TabIndex = 1;
			this.tbServPass.Text = "localhost";
			this.tbServPass.Enter += new System.EventHandler(this.tb_Enter);
			// 
			// tbDBName
			// 
			this.tbDBName.Location = new System.Drawing.Point(121, 39);
			this.tbDBName.Name = "tbDBName";
			this.tbDBName.Size = new System.Drawing.Size(159, 20);
			this.tbDBName.TabIndex = 3;
			this.tbDBName.Text = "sample";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Имя БД";
			// 
			// tbUserName
			// 
			this.tbUserName.Location = new System.Drawing.Point(121, 65);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.Size = new System.Drawing.Size(159, 20);
			this.tbUserName.TabIndex = 5;
			this.tbUserName.Text = "root";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Имя пользователя";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(121, 91);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(159, 20);
			this.tbPassword.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Пароль";
			// 
			// bLogin
			// 
			this.bLogin.Location = new System.Drawing.Point(12, 117);
			this.bLogin.Name = "bLogin";
			this.bLogin.Size = new System.Drawing.Size(268, 23);
			this.bLogin.TabIndex = 8;
			this.bLogin.Text = "Войти...";
			this.bLogin.UseVisualStyleBackColor = true;
			this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
			// 
			// bCancel
			// 
			this.bCancel.Location = new System.Drawing.Point(12, 146);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(268, 23);
			this.bCancel.TabIndex = 9;
			this.bCancel.Text = "Отмена";
			this.bCancel.UseVisualStyleBackColor = true;
			// 
			// fLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 178);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bLogin);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbUserName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbDBName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbServPass);
			this.Controls.Add(this.label1);
			this.Name = "fLogin";
			this.Text = "Подключение к БД";
			this.Load += new System.EventHandler(this.fLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbServPass;
		private System.Windows.Forms.TextBox tbDBName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bLogin;
		private System.Windows.Forms.Button bCancel;
	}
}

