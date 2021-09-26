using System.Collections.Generic;
using System.Linq;

namespace Contacts.Models
{
	class ContactModel
	{
		private List<Contact> Contacts = new List<Contact>();

		public void Add(Contact contact)
		{
			Contacts.Add(contact);
		}

		public List<Contact> GetContacts(string searchString, bool onlyFavorites)
		{

			var result = Contacts.Where(c => onlyFavorites == false || c.favorite == onlyFavorites);
			if (!string.IsNullOrWhiteSpace(searchString))
			{
				result = result.Where(c => c.name.ToLowerInvariant().Contains(searchString)
				|| c.lastName.ToLowerInvariant().Contains(searchString)
				|| Normalize(c.phoneNumber).Contains(Normalize(searchString))
				|| c.email.ToLowerInvariant().Contains(searchString));
			}

			return result.ToList();
		}

		public void Delete(string id)
		{
			var contact = Contacts.FirstOrDefault((c) => c.id == id);
			if (contact != null)
			{
				Contacts.Remove(contact);
			}
		}

		public void Save(Contact contact)
		{
			Delete(contact.id);
			Add(contact);
		}

		public string Normalize(string oldString)
		{
			return oldString.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
		}
	}
}
