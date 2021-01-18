using System;
using System.Windows.Forms;
using System.Drawing;

namespace VetClinic
{
	class VetClinicWindow : TabControl
	{
		public TabPage petPage;
		public TabPage medCardPage;
		public TabPage petOwnerContacts;

		public Label petNameLabel;
		public ListBox petNameListBox;
		
		public Label petBreedLabel;
		public ListBox petBreedListBox;
		
		public Label petAgeLabel;
		public ListBox petAgeListBox;
		
		public Label petGenderLabel;
		public ListBox petGenderListBox;

		public Label diseasesLabel;
		public ListBox diseasesListBox;
		
		public Label proceduresLabel;
		public ListBox proceduresListBox;
		
		public Label medicinesLabel;
		public ListBox medicinesListBox;
		
		public Label recomendationsLabel;
		public ListBox recomendationsListBox;

		public Label ownerNameLabel;
		public ListBox ownerNameListBox;
		
		public Label ownerPhoneLabel;
		public ListBox ownerPhoneListBox;
		
		public Label ownerAddresLabel;
		public ListBox ownerAddresListBox;
		
		public Label ownerMailLabel;
		public ListBox ownerMailListBox;

		public int selectedIndex = -1;

		public VetClinicWindow()
		{
			petPage = new TabPage();
			petPage.Text = "Pet infomation";
			petPage.TabIndex = 1;

			medCardPage = new TabPage();
			medCardPage.Text = "Medical card";
			medCardPage.TabIndex = 2;

			petOwnerContacts = new TabPage();
			petOwnerContacts.Text = "Pet owner contacts";
			petOwnerContacts.TabIndex = 3;

			InitPetInfoControls();
			InitMedCardControls();
			InitOwnerContactsControls();

			Controls.Add(petPage);
			Controls.Add(medCardPage);
			Controls.Add(petOwnerContacts);

			petNameListBox.Click += (s, e) => {
				SelectItem(petNameListBox.SelectedIndex);
			};
			petAgeListBox.Click += (s, e) => {
				SelectItem(petAgeListBox.SelectedIndex);
			};
			petBreedListBox.Click += (s, e) => {
				SelectItem(petBreedListBox.SelectedIndex);
			};
			petGenderListBox.Click += (s, e) => {
				SelectItem(petGenderListBox.SelectedIndex);
			};
			diseasesListBox.Click += (s, e) => {
				SelectItem(diseasesListBox.SelectedIndex);
			};
			proceduresListBox.Click += (s, e) => {
				SelectItem(proceduresListBox.SelectedIndex);
			};
			medicinesListBox.Click += (s, e) => {
				SelectItem(medicinesListBox.SelectedIndex);
			};
			recomendationsListBox.Click += (s, e) => {
				SelectItem(recomendationsListBox.SelectedIndex);
			};
			ownerNameListBox.Click += (s, e) => {
				SelectItem(ownerNameListBox.SelectedIndex);
			};
			ownerPhoneListBox.Click += (s, e) => {
				SelectItem(ownerPhoneListBox.SelectedIndex);
			};
			ownerAddresListBox.Click += (s, e) => {
				SelectItem(ownerAddresListBox.SelectedIndex);
			};
			ownerMailListBox.Click += (s, e) => {
				SelectItem(ownerMailListBox.SelectedIndex);
			};
		}

		private void SelectItem(int index)
		{
			if (index < 0)
				return;
			petNameListBox.SelectedIndex = index;
			petAgeListBox.SelectedIndex = index;
			petBreedListBox.SelectedIndex = index;
			petGenderListBox.SelectedIndex = index;
			diseasesListBox.SelectedIndex = index;
			proceduresListBox.SelectedIndex = index;
			medicinesListBox.SelectedIndex = index;
			recomendationsListBox.SelectedIndex = index;
			ownerNameListBox.SelectedIndex = index;
			ownerPhoneListBox.SelectedIndex = index;
			ownerAddresListBox.SelectedIndex = index;
			ownerMailListBox.SelectedIndex = index;
			selectedIndex = index;
		}
		public Pet GetDataByIndex(int index)
		{
			Gender gender;
			if (!Enum.TryParse((string)petGenderListBox.Items[index], out gender))
				gender = Gender.Male;
			return new Pet(
				(string)petNameListBox.Items[index],
				(uint)petAgeListBox.Items[index],
				(string)petBreedListBox.Items[index],
				gender,
				(string)diseasesListBox.Items[index],
				(string)proceduresListBox.Items[index],
				(string)medicinesListBox.Items[index],
				(string)recomendationsListBox.Items[index],
				(string)ownerNameListBox.Items[index],
				(string)ownerPhoneListBox.Items[index],
				(string)ownerAddresListBox.Items[index],
				(string)ownerMailListBox.Items[index]
			);
		}

		public void RemoveData(int index)
		{
			petNameListBox.Items.RemoveAt(index);
			petAgeListBox.Items.RemoveAt(index);
			petBreedListBox.Items.RemoveAt(index);
			petGenderListBox.Items.RemoveAt(index);
			diseasesListBox.Items.RemoveAt(index);
			proceduresListBox.Items.RemoveAt(index);
			medicinesListBox.Items.RemoveAt(index);
			recomendationsListBox.Items.RemoveAt(index);
			ownerNameListBox.Items.RemoveAt(index);
			ownerPhoneListBox.Items.RemoveAt(index);
			ownerAddresListBox.Items.RemoveAt(index);
			ownerMailListBox.Items.RemoveAt(index);
		}

		public void AddData(Pet pet)
		{
			petNameListBox.Items.Add(pet.Name);
			petAgeListBox.Items.Add(pet.Age);
			petBreedListBox.Items.Add(pet.Breed);
			petGenderListBox.Items.Add(pet.Gender.ToString("g"));
			diseasesListBox.Items.Add(pet.Diseases);
			proceduresListBox.Items.Add(pet.Procedures);
			medicinesListBox.Items.Add(pet.Medicines);
			recomendationsListBox.Items.Add(pet.Recomendations);
			ownerNameListBox.Items.Add(pet.OwnerName);
			ownerPhoneListBox.Items.Add(pet.OwnerPhone);
			ownerAddresListBox.Items.Add(pet.OwnerAddres);
			ownerMailListBox.Items.Add(pet.OwnerEmail);
		}

		public void InsertData(int index, Pet pet)
		{
			petNameListBox.Items.Insert(index, pet.Name);
			petAgeListBox.Items.Insert(index, pet.Age);
			petBreedListBox.Items.Insert(index, pet.Breed);
			petGenderListBox.Items.Insert(index, pet.Gender.ToString("g"));
			diseasesListBox.Items.Insert(index, pet.Diseases);
			proceduresListBox.Items.Insert(index, pet.Procedures);
			medicinesListBox.Items.Insert(index, pet.Medicines);
			recomendationsListBox.Items.Insert(index, pet.Recomendations);
			ownerNameListBox.Items.Insert(index, pet.OwnerName);
			ownerPhoneListBox.Items.Insert(index, pet.OwnerPhone);
			ownerAddresListBox.Items.Insert(index, pet.OwnerAddres);
			ownerMailListBox.Items.Insert(index, pet.OwnerEmail);
		}

		private void InitPetInfoControls()
		{
			petNameLabel = new Label();
			petNameLabel.Size = new Size(100, 15);
			petNameLabel.Location = new Point(20, 20);
			petNameLabel.Text = "Pet name";
			petNameListBox = new ListBox();
			petNameListBox.Size = new Size(130, 150);
			petNameListBox.Location = new Point(20, 35);

			petBreedLabel = new Label();
			petBreedLabel.Size = new Size(100, 15);
			petBreedLabel.Location = new Point(20, 200);
			petBreedLabel.Text = "Pet breed";
			petBreedListBox = new ListBox();
			petBreedListBox.Size = new Size(130, 150);
			petBreedListBox.Location = new Point(20, 215);

			petAgeLabel = new Label();
			petAgeLabel.Size = new Size(100, 15);
			petAgeLabel.Location = new Point(300, 20);
			petAgeLabel.Text = "Pet age";
			petAgeListBox = new ListBox();
			petAgeListBox.Size = new Size(130, 150);
			petAgeListBox.Location = new Point(300, 35);

			petGenderLabel = new Label();
			petGenderLabel.Size = new Size(100, 15);
			petGenderLabel.Location = new Point(300, 200);
			petGenderLabel.Text = "Pet gender";
			petGenderListBox = new ListBox();
			petGenderListBox.Size = new Size(130, 150);
			petGenderListBox.Location = new Point(300, 215);

			petPage.Controls.Add(petNameLabel);
			petPage.Controls.Add(petNameListBox);
			petPage.Controls.Add(petBreedLabel);
			petPage.Controls.Add(petBreedListBox);
			petPage.Controls.Add(petAgeLabel);
			petPage.Controls.Add(petAgeListBox);
			petPage.Controls.Add(petGenderLabel);
			petPage.Controls.Add(petGenderListBox);
		}

		private void InitMedCardControls()
		{
			diseasesLabel = new Label();
			diseasesLabel.Size = new Size(100, 15);
			diseasesLabel.Location = new Point(20, 20);
			diseasesLabel.Text = "Pet diseases";
			diseasesListBox = new ListBox();
			diseasesListBox.Size = new Size(130, 150);
			diseasesListBox.Location = new Point(20, 35);

			proceduresLabel = new Label();
			proceduresLabel.Size = new Size(100, 15);
			proceduresLabel.Location = new Point(20, 200);
			proceduresLabel.Text = "Procedures";
			proceduresListBox = new ListBox();
			proceduresListBox.Size = new Size(130, 150);
			proceduresListBox.Location = new Point(20, 215);

			medicinesLabel = new Label();
			medicinesLabel.Size = new Size(100, 15);
			medicinesLabel.Location = new Point(300, 20);
			medicinesLabel.Text = "Medicines";
			medicinesListBox = new ListBox();
			medicinesListBox.Size = new Size(130, 150);
			medicinesListBox.Location = new Point(300, 35);


			recomendationsLabel = new Label();
			recomendationsLabel.Size = new Size(100, 15);
			recomendationsLabel.Location = new Point(300, 200);
			recomendationsLabel.Text = "Recomendations";
			recomendationsListBox = new ListBox();
			recomendationsListBox.Size = new Size(130, 150);
			recomendationsListBox.Location = new Point(300, 215);

			medCardPage.Controls.Add(diseasesLabel);
			medCardPage.Controls.Add(diseasesListBox);
			medCardPage.Controls.Add(proceduresLabel);
			medCardPage.Controls.Add(proceduresListBox);
			medCardPage.Controls.Add(medicinesLabel);
			medCardPage.Controls.Add(medicinesListBox);
			medCardPage.Controls.Add(recomendationsLabel);
			medCardPage.Controls.Add(recomendationsListBox);
		}

		private void InitOwnerContactsControls()
		{
			ownerNameLabel = new Label();
			ownerNameLabel.Size = new Size(100, 15);
			ownerNameLabel.Location = new Point(20, 20);
			ownerNameLabel.Text = "Owner name";
			ownerNameListBox = new ListBox();
			ownerNameListBox.Size = new Size(130, 150);
			ownerNameListBox.Location = new Point(20, 35);

			ownerPhoneLabel = new Label();
			ownerPhoneLabel.Size = new Size(100, 15);
			ownerPhoneLabel.Location = new Point(20, 200);
			ownerPhoneLabel.Text = "Owner phone";
			ownerPhoneListBox = new ListBox();
			ownerPhoneListBox.Size = new Size(130, 150);
			ownerPhoneListBox.Location = new Point(20, 215);

			ownerAddresLabel = new Label();
			ownerAddresLabel.Size = new Size(100, 15);
			ownerAddresLabel.Location = new Point(300, 20);
			ownerAddresLabel.Text = "Owner address";
			ownerAddresListBox = new ListBox();
			ownerAddresListBox.Size = new Size(130, 150);
			ownerAddresListBox.Location = new Point(300, 35);

			ownerMailLabel = new Label();
			ownerMailLabel.Size = new Size(100, 15);
			ownerMailLabel.Location = new Point(300, 200);
			ownerMailLabel.Text = "Owner mail";
			ownerMailListBox = new ListBox();
			ownerMailListBox.Size = new Size(130, 150);
			ownerMailListBox.Location = new Point(300, 215);

			petOwnerContacts.Controls.Add(ownerNameLabel);
			petOwnerContacts.Controls.Add(ownerNameListBox);
			petOwnerContacts.Controls.Add(ownerPhoneLabel);
			petOwnerContacts.Controls.Add(ownerPhoneListBox);
			petOwnerContacts.Controls.Add(ownerAddresLabel);
			petOwnerContacts.Controls.Add(ownerAddresListBox);
			petOwnerContacts.Controls.Add(ownerMailLabel);
			petOwnerContacts.Controls.Add(ownerMailListBox);
		}

	}
}