using System;
using System.Windows.Forms;

namespace VetClinic
{
	class VetClinicService
	{
		private MenuControl menu;
		private VetClinicWindow vetClinicWindow;
		private VetClinicEditWindow vetClinicEditWindow;
		
		public VetClinicService(
			MenuControl menu,
			VetClinicWindow vetClinicWindow,
			VetClinicEditWindow vetClinicEditWindow
		)
		{
			this.menu = menu;
			this.vetClinicWindow = vetClinicWindow;
			this.vetClinicEditWindow = vetClinicEditWindow;

			menu.newPatient.Click += OnNewPatientClick;
			menu.editPatient.Click += OnEditPatientClick;
			menu.deletePatient.Click += OnDeletePatientClick;

			vetClinicEditWindow.save.Click += OnSaveButtonClick;
			vetClinicEditWindow.cancel.Click += (s, e) => vetClinicEditWindow.Close();
		}

		private void OnNewPatientClick(object s, EventArgs e)
		{
			vetClinicEditWindow.Text = "Add new pet";
			vetClinicEditWindow.ShowDialog();
		}

		private void OnEditPatientClick(object s, EventArgs e)
		{
			if (vetClinicWindow.selectedIndex != -1)
			{
				vetClinicEditWindow.Text = "Edit pet";
				Pet p = vetClinicWindow.GetDataByIndex(vetClinicWindow.selectedIndex);
				vetClinicEditWindow.SetData(p, vetClinicWindow.selectedIndex);
				vetClinicEditWindow.ShowDialog();
			}
		}

		private void OnDeletePatientClick(object s, EventArgs e)
		{	
			if (vetClinicWindow.selectedIndex != -1)
			{
				vetClinicWindow.RemoveData(vetClinicWindow.selectedIndex);
			}
		}

		private void OnSaveButtonClick(object s, EventArgs e)
		{
			if (vetClinicEditWindow.IsValid())
			{
				if (vetClinicEditWindow.editIndex != -1)
				{
					vetClinicWindow.RemoveData(vetClinicEditWindow.editIndex);
					vetClinicWindow.InsertData(vetClinicEditWindow.editIndex, vetClinicEditWindow.GetData());
				}
				else 
				{
					vetClinicWindow.AddData(vetClinicEditWindow.GetData());
				}
				vetClinicEditWindow.SetData(new Pet(), -1);
				vetClinicEditWindow.Close();
			}
		}
	}
}