
namespace Contacts
{
	partial class ContactsList
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
			this.lblContactsList = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.listViewContacts = new System.Windows.Forms.ListView();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnFavorite = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblContactsList
			// 
			this.lblContactsList.AutoSize = true;
			this.lblContactsList.Location = new System.Drawing.Point(15, 17);
			this.lblContactsList.Name = "lblContactsList";
			this.lblContactsList.Size = new System.Drawing.Size(56, 13);
			this.lblContactsList.TabIndex = 0;
			this.lblContactsList.Text = "Контакты";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(141, 11);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(84, 25);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// listViewContacts
			// 
			this.listViewContacts.HideSelection = false;
			this.listViewContacts.Location = new System.Drawing.Point(16, 70);
			this.listViewContacts.Name = "listViewContacts";
			this.listViewContacts.Size = new System.Drawing.Size(209, 150);
			this.listViewContacts.TabIndex = 2;
			this.listViewContacts.UseCompatibleStateImageBehavior = false;
			this.listViewContacts.View = System.Windows.Forms.View.List;
			this.listViewContacts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewContacts_ItemSelectionChanged);
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(16, 42);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(119, 20);
			this.tbSearch.TabIndex = 3;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(141, 39);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(84, 25);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Поиск";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnFavorite
			// 
			this.btnFavorite.Image = global::Contacts.Properties.Resources.iconFavorite;
			this.btnFavorite.Location = new System.Drawing.Point(77, 11);
			this.btnFavorite.Name = "btnFavorite";
			this.btnFavorite.Size = new System.Drawing.Size(25, 25);
			this.btnFavorite.TabIndex = 5;
			this.btnFavorite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnFavorite.UseVisualStyleBackColor = true;
			this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
			// 
			// ContactsList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnFavorite);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.listViewContacts);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblContactsList);
			this.Name = "ContactsList";
			this.Size = new System.Drawing.Size(244, 239);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblContactsList;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ListView listViewContacts;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnFavorite;
	}
}
