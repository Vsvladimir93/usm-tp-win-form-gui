using System;
using System.Windows.Forms;
using System.Drawing;


namespace VetClinic
{
	class MainWindow : Form
	{
		private MenuControl menu;
		private VetClinicWindow vetClinicWindow;
		private VetClinicEditWindow vetClinicEditWindow;


		public MainWindow()
		{
			Size = new Size(480, 500);
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Vet Clinic application";

			menu = new MenuControl();
			vetClinicEditWindow = new VetClinicEditWindow();
			vetClinicEditWindow.StartPosition = FormStartPosition.CenterScreen;

			vetClinicWindow = new VetClinicWindow();
			vetClinicWindow.Location = new Point(0, menu.Size.Height);
			vetClinicWindow.Size = new Size(Size.Width, Size.Height - menu.Size.Height);

			Controls.Add(menu);
			Controls.Add(vetClinicWindow);

			new VetClinicService(menu, vetClinicWindow, vetClinicEditWindow);
		}

	}
}