using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contacts
{
	public partial class ContactDetails : UserControl
	{
		public event EventHandler<EventArgs> ButtonActionClicked;
		public event EventHandler<EventArgs> ButtonEditClicked;

		private bool _readOnly;

		public bool Readonly
		{
			get{ return _readOnly; }
			set
			{
				_readOnly = value;
				tbName.Enabled = value;
				tbLastName.Enabled = value;
				tbPhoneNumber.Enabled = value;
				dtDateOfBirth.Enabled = value;
				tbCompany.Enabled = value;
				tbEmail.Enabled = value;
				btnFavorite.Enabled = value;
			}
		}

		public bool Favorite
		{
			get;
			set;
		}

		public string Id { get; set; }

		public string WindowName
		{
			get { return lblWindowName.Text; }
			set { lblWindowName.Text = value; }
		}

		public bool EditButtonIsVisible
		{
			get { return btnEdit.Visible; }
			set { btnEdit.Visible = value; }
		}

		public string ActionButtonText
		{
			get { return btnAction.Text; }
			set { btnAction.Text = value; }
		}

		public string FirstName
		{
			get { return tbName.Text; }
			set { tbName.Text = value; }
		}

		public string LastName
		{
			get { return tbLastName.Text; }
			set { tbLastName.Text = value; }
		}

		public string PhoneNumber
		{
			get { return tbPhoneNumber.Text; }
			set { tbPhoneNumber.Text = value; }
		}

		public DateTime DateOfBirth
		{
			get { return dtDateOfBirth.Value; }
			set { dtDateOfBirth.Value = value; }
		}

		public string Company
		{
			get { return tbCompany.Text; }
			set { tbCompany.Text = value; }
		}

		public string Email
		{
			get { return tbEmail.Text; }
			set { tbEmail.Text = value; }
		}

		public Color FavoriteButtonBackColor
		{
			get { return btnFavorite.BackColor; }
			set { btnFavorite.BackColor = value; }
		}

		public ContactDetails()
		{
			InitializeComponent();
		}

		private void btnAction_Click(object sender, EventArgs e)
		{
			ButtonActionClicked?.Invoke(sender, e);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{

			ButtonEditClicked?.Invoke(sender, e);
		}

		public void SetContact(Contact contact)
		{
			Id = contact.id;
			FirstName = contact.name;
			LastName = contact.lastName;
			PhoneNumber = contact.phoneNumber;
			DateOfBirth = contact.dateOfBirth;
			Company = contact.company;
			Email = contact.email;
			Favorite = contact.favorite;

			if(Favorite)
			{
				btnFavorite.BackColor = Color.Yellow;
			}
			else
			{
				btnFavorite.BackColor = SystemColors.Control;
			}
		}

		private void tbName_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void btnFavorite_Click(object sender, EventArgs e)
		{
			Favorite = !Favorite;
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
