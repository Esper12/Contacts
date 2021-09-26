using Contacts.Controllers;
using Contacts.Models;
using System;
using System.Windows.Forms;

namespace Contacts
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var mainForm = new MainForm();
			var model = new ContactModel();
			var contactController = new ContactController(model, mainForm);

			Application.Run(mainForm);
		}
	}
}
