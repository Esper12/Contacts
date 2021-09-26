using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Contacts
{
	public partial class ContactsList : UserControl
	{
		public event EventHandler<EventArgs> ButtonAddClicked;
		public event EventHandler<ListViewItemSelectionChangedEventArgs> ListViewContactClicked;
		public event EventHandler<EventArgs> ButtonSearchClicked;
		public event EventHandler<EventArgs> ButtonFavoriteClicked;

		public bool Favorite
		{
			get; set;
		}

		public ContactsList()
		{
			InitializeComponent();
		}

		public string SearchString
		{
			get { return tbSearch.Text; }
			set { tbSearch.Text = value; }
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Favorite = false;
			ButtonAddClicked?.Invoke(sender, e);

			if (Favorite == true)
			{
				btnFavorite.BackColor = Color.Yellow;
			}
			else
			{
				btnFavorite.BackColor = SystemColors.Control;
			}
		}

		public void SetContactList(List<Contact> contactsList)
		{
			listViewContacts.Items.Clear();

			foreach(var contact in contactsList)
			{
				var item = new ListViewItem();
				item.Text = contact.name + " " + contact.lastName;
				item.Tag = contact;

				listViewContacts.Items.Add(item);
			}
		}

		private void listViewContacts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			ListViewContactClicked?.Invoke(sender, e);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			ButtonSearchClicked?.Invoke(sender, e);
		}

		private void btnFavorite_Click(object sender, EventArgs e)
		{
			Favorite = !Favorite;
			ButtonFavoriteClicked?.Invoke(sender, e);

			if (Favorite == true)
			{
				btnFavorite.BackColor = Color.Yellow;
			}
			else
			{
				btnFavorite.BackColor = SystemColors.Control;
			}
		}
	}
}
