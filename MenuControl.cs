using System;
using System.Windows.Forms;

namespace VetClinic
{
	class MenuControl : MenuStrip
	{
		public ToolStripMenuItem patients;
		
		public ToolStripMenuItem newPatient;
		public ToolStripMenuItem editPatient;
		public ToolStripMenuItem deletePatient;

		public MenuControl()
		{
			patients = new ToolStripMenuItem();
			patients.Text = "Patients";

			newPatient = new ToolStripMenuItem();
			newPatient.Text = "New patient";
			editPatient = new ToolStripMenuItem();
			editPatient.Text = "Edit patient";
			deletePatient = new ToolStripMenuItem();
			deletePatient.Text = "Delete patient";

			patients.DropDownItems.AddRange(
				new ToolStripMenuItem[]
				{
					newPatient,
					editPatient,
					deletePatient
				}
			);

			this.Items.Add(patients);
		}
	}
}