using Contacts.Entities;
using Contacts.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Contacts.Controllers
{
	class ContactController
	{
		private ContactModel model;
		private MainForm view;

		public ContactController(ContactModel contactModel, MainForm contactView)
		{
			model = contactModel;
			view = contactView;

			RegisterHandlers();
		}

		private void RegisterHandlers()
		{
			view.ContactsList.ButtonAddClicked += OnAddClicked;
			view.ContactDetails.ButtonActionClicked += OnActionClicked;
			view.ContactsList.ListViewContactClicked += OnContactClicked;
			view.ContactDetails.ButtonEditClicked += OnEditClicked;
			view.ContactsList.ButtonSearchClicked += OnSearchClicked;
			view.ContactsList.ButtonFavoriteClicked += OnFavoriteClicked;
		}

		public void OnAddClicked(object sender, EventArgs eventArgs)
		{
			view.ContactDetails.Visible = true;
			view.ContactDetails.Readonly = true;
			view.Action = Actions.Add;

			view.ContactDetails.WindowName = "Новый контакт";
			view.ContactDetails.EditButtonIsVisible = false;
			view.ContactDetails.ActionButtonText = "Сохранить";
			view.ContactDetails.FirstName = null;
			view.ContactDetails.LastName = null;
			view.ContactDetails.PhoneNumber = null;
			view.ContactDetails.DateOfBirth = DateTime.Today;
			view.ContactDetails.Company = null;
			view.ContactDetails.Email = null;

			view.ContactDetails.Favorite = false;
			view.ContactDetails.FavoriteButtonBackColor = SystemColors.Control;
			
		}

		public void OnActionClicked(object sender, EventArgs eventArgs)
		{
			if(view.Action == Actions.Add)
			{
				var validationResult = Validate();
				if(validationResult.Any())
				{
					var message = string.Join("\n", validationResult);
					MessageBox.Show(message, "Ошибка!");
					return;
				}

				Contact contact = new Contact();
				contact.id = Guid.NewGuid().ToString();
				contact.name = view.ContactDetails.FirstName;
				contact.lastName = view.ContactDetails.LastName;
				contact.phoneNumber = view.ContactDetails.PhoneNumber;
				contact.dateOfBirth = view.ContactDetails.DateOfBirth;
				contact.company = view.ContactDetails.Company;
				contact.email = view.ContactDetails.Email;
				contact.favorite = view.ContactDetails.Favorite;

				model.Add(contact);

				view.ContactDetails.Visible = false;
			}
			else if(view.Action == Actions.Delete)
			{
				model.Delete(view.ContactDetails.Id);
				view.ContactDetails.Visible = false;
			}
			else if(view.Action == Actions.Save)
			{
				Contact contact = new Contact();
				contact.id = view.ContactDetails.Id;
				contact.name = view.ContactDetails.FirstName;
				contact.lastName = view.ContactDetails.LastName;
				contact.phoneNumber = view.ContactDetails.PhoneNumber;
				contact.dateOfBirth = view.ContactDetails.DateOfBirth;
				contact.company = view.ContactDetails.Company;
				contact.email = view.ContactDetails.Email;
				contact.favorite = view.ContactDetails.Favorite;

				model.Save(contact);
				view.ContactDetails.Visible = false;
			}

			Update();
		}

		public void OnContactClicked(object sender, ListViewItemSelectionChangedEventArgs eventArgs)
		{
			view.ContactDetails.Visible = true;

			view.ContactDetails.WindowName = "Информация";
			view.ContactDetails.EditButtonIsVisible = true;
			view.ContactDetails.ActionButtonText = "Удалить";
			view.Action = Actions.Delete;
			view.ContactDetails.Readonly = false;

			view.ContactDetails.SetContact((Contact)eventArgs.Item.Tag);
		}

		public void OnEditClicked(object sender, EventArgs eventArgs)
		{
			view.ContactDetails.WindowName = "Редактирование";
			view.ContactDetails.EditButtonIsVisible = false;
			view.ContactDetails.ActionButtonText = "Сохранить";
			view.Action = Actions.Save;
			view.ContactDetails.Readonly = true;
		}

		public void OnSearchClicked(object sender, EventArgs eventArgs)
		{
			Update();
		}

		public void OnFavoriteClicked(object sender, EventArgs eventArgs)
		{
			Update();
		}

		private void Update()
		{
			var contacts = model.GetContacts(view.ContactsList.SearchString.ToLowerInvariant(), view.ContactsList.Favorite);
			view.SetContactsList(contacts);
		}

		private List<string> Validate()
		{
			var errors = new List<string>();

			if (string.IsNullOrWhiteSpace(view.ContactDetails.FirstName))
			{
				errors.Add("Заполните поле 'Имя'");
			}

			if (!string.IsNullOrWhiteSpace(view.ContactDetails.PhoneNumber))
			{
				Regex regex = new Regex(@"^(\+7) \(\d{3}\) \d{3}\-\d{2}\-\d{2}$");
				if (!regex.IsMatch(view.ContactDetails.PhoneNumber))
				{
					errors.Add("Заполните поле 'Номер телефона'");
				}
			}

			var expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
			if (!string.IsNullOrWhiteSpace(view.ContactDetails.Email))
			{
				if (!expr.IsMatch(view.ContactDetails.Email))
				{
					errors.Add("Некорректный e-mail");
				}
			}

			return errors;
		}
	}
}
