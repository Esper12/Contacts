
namespace Contacts
{
	partial class ContactDetails
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblDateOfBirth = new System.Windows.Forms.Label();
			this.lblCompany = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbCompany = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.lblWindowName = new System.Windows.Forms.Label();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAction = new System.Windows.Forms.Button();
			this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.tbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.btnFavorite = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(18, 57);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(32, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Имя:";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(18, 81);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(59, 13);
			this.lblLastName.TabIndex = 1;
			this.lblLastName.Text = "Фамилия:";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Location = new System.Drawing.Point(18, 106);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(96, 13);
			this.lblPhoneNumber.TabIndex = 2;
			this.lblPhoneNumber.Text = "Номер телефона:";
			// 
			// lblDateOfBirth
			// 
			this.lblDateOfBirth.AutoSize = true;
			this.lblDateOfBirth.Location = new System.Drawing.Point(18, 133);
			this.lblDateOfBirth.Name = "lblDateOfBirth";
			this.lblDateOfBirth.Size = new System.Drawing.Size(89, 13);
			this.lblDateOfBirth.TabIndex = 3;
			this.lblDateOfBirth.Text = "Дата рождения:";
			// 
			// lblCompany
			// 
			this.lblCompany.AutoSize = true;
			this.lblCompany.Location = new System.Drawing.Point(18, 161);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(61, 13);
			this.lblCompany.TabIndex = 4;
			this.lblCompany.Text = "Компания:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(18, 186);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(38, 13);
			this.lblEmail.TabIndex = 5;
			this.lblEmail.Text = "E-mail:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(137, 54);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(202, 20);
			this.tbName.TabIndex = 6;
			this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
			// 
			// tbCompany
			// 
			this.tbCompany.Location = new System.Drawing.Point(137, 158);
			this.tbCompany.Name = "tbCompany";
			this.tbCompany.Size = new System.Drawing.Size(202, 20);
			this.tbCompany.TabIndex = 7;
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(137, 183);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(202, 20);
			this.tbEmail.TabIndex = 8;
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(137, 78);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(202, 20);
			this.tbLastName.TabIndex = 11;
			this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLastName_KeyPress);
			// 
			// lblWindowName
			// 
			this.lblWindowName.AutoSize = true;
			this.lblWindowName.Location = new System.Drawing.Point(6, 18);
			this.lblWindowName.Name = "lblWindowName";
			this.lblWindowName.Size = new System.Drawing.Size(84, 13);
			this.lblWindowName.TabIndex = 12;
			this.lblWindowName.Text = "Название окна";
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(152, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(99, 27);
			this.btnEdit.TabIndex = 13;
			this.btnEdit.Text = "Редактировать";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(257, 13);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(82, 27);
			this.btnAction.TabIndex = 14;
			this.btnAction.Text = "Удалить";
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// dtDateOfBirth
			// 
			this.dtDateOfBirth.Location = new System.Drawing.Point(137, 127);
			this.dtDateOfBirth.Name = "dtDateOfBirth";
			this.dtDateOfBirth.Size = new System.Drawing.Size(202, 20);
			this.dtDateOfBirth.TabIndex = 15;
			// 
			// tbPhoneNumber
			// 
			this.tbPhoneNumber.Location = new System.Drawing.Point(137, 103);
			this.tbPhoneNumber.Mask = "+7 (000) 000-00-00";
			this.tbPhoneNumber.Name = "tbPhoneNumber";
			this.tbPhoneNumber.Size = new System.Drawing.Size(202, 20);
			this.tbPhoneNumber.TabIndex = 16;
			// 
			// btnFavorite
			// 
			this.btnFavorite.Image = global::Contacts.Properties.Resources.iconFavorite;
			this.btnFavorite.Location = new System.Drawing.Point(105, 13);
			this.btnFavorite.Name = "btnFavorite";
			this.btnFavorite.Size = new System.Drawing.Size(25, 25);
			this.btnFavorite.TabIndex = 17;
			this.btnFavorite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnFavorite.UseVisualStyleBackColor = true;
			this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
			// 
			// ContactDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnFavorite);
			this.Controls.Add(this.tbPhoneNumber);
			this.Controls.Add(this.dtDateOfBirth);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.lblWindowName);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.tbCompany);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblCompany);
			this.Controls.Add(this.lblDateOfBirth);
			this.Controls.Add(this.lblPhoneNumber);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblName);
			this.Name = "ContactDetails";
			this.Size = new System.Drawing.Size(354, 218);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblPhoneNumber;
		private System.Windows.Forms.Label lblDateOfBirth;
		private System.Windows.Forms.Label lblCompany;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbCompany;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.Label lblWindowName;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.DateTimePicker dtDateOfBirth;
		private System.Windows.Forms.MaskedTextBox tbPhoneNumber;
		private System.Windows.Forms.Button btnFavorite;
	}
}
