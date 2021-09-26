
namespace Contacts
{
	partial class MainForm
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
			this.contactDetails1 = new Contacts.ContactDetails();
			this.contactsList1 = new Contacts.ContactsList();
			this.SuspendLayout();
			// 
			// contactDetails1
			// 
			this.contactDetails1.ActionButtonText = "Удалить";
			this.contactDetails1.Company = "";
			this.contactDetails1.DateOfBirth = new System.DateTime(2021, 9, 26, 10, 11, 47, 730);
			this.contactDetails1.EditButtonIsVisible = true;
			this.contactDetails1.Email = "";
			this.contactDetails1.Favorite = false;
			this.contactDetails1.FirstName = "";
			this.contactDetails1.Id = null;
			this.contactDetails1.LastName = "";
			this.contactDetails1.Location = new System.Drawing.Point(267, 12);
			this.contactDetails1.Name = "contactDetails1";
			this.contactDetails1.PhoneNumber = "+7 (   )    -  -";
			this.contactDetails1.Readonly = false;
			this.contactDetails1.Size = new System.Drawing.Size(352, 240);
			this.contactDetails1.TabIndex = 2;
			this.contactDetails1.WindowName = "Название окна";
			// 
			// contactsList1
			// 
			this.contactsList1.Favorite = false;
			this.contactsList1.Location = new System.Drawing.Point(12, 12);
			this.contactsList1.Name = "contactsList1";
			this.contactsList1.SearchString = "";
			this.contactsList1.Size = new System.Drawing.Size(249, 240);
			this.contactsList1.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 250);
			this.Controls.Add(this.contactDetails1);
			this.Controls.Add(this.contactsList1);
			this.Name = "MainForm";
			this.Text = "Contacts";
			this.ResumeLayout(false);

		}

		#endregion

		private ContactsList contactsList1;
		private ContactDetails contactDetails1;
	}
}

