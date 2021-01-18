using System;
using System.Windows.Forms;
using System.Drawing;

namespace VetClinic
{
	class VetClinicEditWindow : Form
	{
		public Label petNameLabel;
		public TextBox petNameTextBox;
		
		public Label petBreedLabel;
		public TextBox petBreedTextBox;
		
		public Label petAgeLabel;
		public NumericUpDown petAgeNumericInput;
		
		public Label petGenderLabel;
		public ComboBox petGenderTextBox;

		public Label diseasesLabel;
		public TextBox diseasesTextBox;
		
		public Label proceduresLabel;
		public TextBox proceduresTextBox;
		
		public Label medicinesLabel;
		public TextBox medicinesTextBox;
		
		public Label recomendationsLabel;
		public TextBox recomendationsTextBox;

		public Label ownerNameLabel;
		public TextBox ownerNameTextBox;
		
		public Label ownerPhoneLabel;
		public TextBox ownerPhoneTextBox;
		
		public Label ownerAddresLabel;
		public TextBox ownerAddresTextBox;
		
		public Label ownerMailLabel;
		public TextBox ownerMailTextBox;
		public Button cancel;
		public Button save;

		public int editIndex = -1;

		public VetClinicEditWindow()
		{
			Size = new Size(420, 300);
			Text = "Add new pet";
			InitPetInfoControls();
			InitMedCardControls();
			InitOwnerContactsControls();

			cancel = new Button();
			cancel.Text = "Cancel";
			cancel.Size = new Size(100, 25);
			cancel.Location = new Point(150, 225);

			save = new Button();
			save.Text = "Save";
			save.Size = new Size(100, 25);
			save.Location = new Point(280, 225);

			Controls.Add(cancel);
			Controls.Add(save);
			Closing += (s, e) => {
				editIndex = -1;
			};
		}

		public Pet GetData()
		{
			Gender gender;
			if (!Enum.TryParse(petGenderTextBox.Text, out gender))
				gender = Gender.Male;
			return new Pet(
				petNameTextBox.Text,
				(uint)petAgeNumericInput.Value,
				petBreedTextBox.Text,
				gender,
				diseasesTextBox.Text,
				proceduresTextBox.Text,
				medicinesTextBox.Text,
				recomendationsTextBox.Text,
				ownerNameTextBox.Text,
				ownerPhoneTextBox.Text,
				ownerAddresTextBox.Text,
				ownerMailTextBox.Text
			);
		}

		public void SetData(Pet pet, int editIndex)
		{
			petNameTextBox.Text = pet.Name;
			petAgeNumericInput.Value = pet.Age;
			petBreedTextBox.Text = pet.Breed;
			petGenderTextBox.Text = pet.Gender.ToString("g");
			diseasesTextBox.Text = pet.Diseases;
			proceduresTextBox.Text = pet.Procedures;
			medicinesTextBox.Text = pet.Medicines;
			recomendationsTextBox.Text = pet.Recomendations;
			ownerNameTextBox.Text = pet.OwnerName;
			ownerPhoneTextBox.Text = pet.OwnerPhone;
			ownerAddresTextBox.Text = pet.OwnerAddres;
			ownerMailTextBox.Text = pet.OwnerEmail;
			this.editIndex = editIndex;
		}

		public Boolean IsValid()
		{
			return 
			!string.IsNullOrEmpty(petNameTextBox.Text) &&
			petAgeNumericInput.Value > 0 &&
			!string.IsNullOrEmpty(petBreedTextBox.Text) &&
			!string.IsNullOrEmpty(petGenderTextBox.Text) &&
			!string.IsNullOrEmpty(diseasesTextBox.Text) &&
			!string.IsNullOrEmpty(proceduresTextBox.Text) &&
			!string.IsNullOrEmpty(medicinesTextBox.Text) &&
			!string.IsNullOrEmpty(recomendationsTextBox.Text) &&
			!string.IsNullOrEmpty(ownerNameTextBox.Text) &&
			!string.IsNullOrEmpty(ownerPhoneTextBox.Text) &&
			!string.IsNullOrEmpty(ownerAddresTextBox.Text) &&
			!string.IsNullOrEmpty(ownerMailTextBox.Text);
		}

		private void InitPetInfoControls()
		{
			petNameLabel = new Label();
			petNameLabel.Size = new Size(100, 15);
			petNameLabel.Location = new Point(20, 20);
			petNameLabel.Text = "Pet name";
			petNameTextBox = new TextBox();
			petNameTextBox.Size = new Size(100, 35);
			petNameTextBox.Location = new Point(20, 35);

			petBreedLabel = new Label();
			petBreedLabel.Size = new Size(100, 15);
			petBreedLabel.Location = new Point(20, 70);
			petBreedLabel.Text = "Pet breed";
			petBreedTextBox = new TextBox();
			petBreedTextBox.Size = new Size(100, 35);
			petBreedTextBox.Location = new Point(20, 85);

			petAgeLabel = new Label();
			petAgeLabel.Size = new Size(100, 15);
			petAgeLabel.Location = new Point(20, 120);
			petAgeLabel.Text = "Pet age";
			petAgeNumericInput = new NumericUpDown();
			petAgeNumericInput.Size = new Size(100, 35);
			petAgeNumericInput.Location = new Point(20, 135);


			petGenderLabel = new Label();
			petGenderLabel.Size = new Size(100, 15);
			petGenderLabel.Location = new Point(20, 170);
			petGenderLabel.Text = "Pet gender";
			petGenderTextBox = new ComboBox();
			petGenderTextBox.Size = new Size(100, 35);
			petGenderTextBox.Location = new Point(20, 185);
			petGenderTextBox.Items.Add(Gender.Male.ToString("g"));
			petGenderTextBox.Items.Add(Gender.Female.ToString("g"));

			Controls.Add(petNameLabel);
			Controls.Add(petNameTextBox);
			Controls.Add(petBreedLabel);
			Controls.Add(petBreedTextBox);
			Controls.Add(petAgeLabel);
			Controls.Add(petAgeNumericInput);
			Controls.Add(petGenderLabel);
			Controls.Add(petGenderTextBox);
		}

		private void InitMedCardControls()
		{
			diseasesLabel = new Label();
			diseasesLabel.Size = new Size(100, 15);
			diseasesLabel.Location = new Point(150, 20);
			diseasesLabel.Text = "Pet diseases";
			diseasesTextBox = new TextBox();
			diseasesTextBox.Size = new Size(100, 35);
			diseasesTextBox.Location = new Point(150, 35);

			proceduresLabel = new Label();
			proceduresLabel.Size = new Size(100, 15);
			proceduresLabel.Location = new Point(150, 70);
			proceduresLabel.Text = "Procedures";
			proceduresTextBox = new TextBox();
			proceduresTextBox.Size = new Size(100, 35);
			proceduresTextBox.Location = new Point(150, 85);

			medicinesLabel = new Label();
			medicinesLabel.Size = new Size(100, 15);
			medicinesLabel.Location = new Point(150, 120);
			medicinesLabel.Text = "Medicines";
			medicinesTextBox = new TextBox();
			medicinesTextBox.Size = new Size(100, 35);
			medicinesTextBox.Location = new Point(150, 135);


			recomendationsLabel = new Label();
			recomendationsLabel.Size = new Size(100, 15);
			recomendationsLabel.Location = new Point(150, 170);
			recomendationsLabel.Text = "Recomendations";
			recomendationsTextBox = new TextBox();
			recomendationsTextBox.Size = new Size(100, 35);
			recomendationsTextBox.Location = new Point(150, 185);

			Controls.Add(diseasesLabel);
			Controls.Add(diseasesTextBox);
			Controls.Add(proceduresLabel);
			Controls.Add(proceduresTextBox);
			Controls.Add(medicinesLabel);
			Controls.Add(medicinesTextBox);
			Controls.Add(recomendationsLabel);
			Controls.Add(recomendationsTextBox);
		}

		private void InitOwnerContactsControls()
		{
			ownerNameLabel = new Label();
			ownerNameLabel.Size = new Size(100, 15);
			ownerNameLabel.Location = new Point(280, 20);
			ownerNameLabel.Text = "Owner name";
			ownerNameTextBox = new TextBox();
			ownerNameTextBox.Size = new Size(100, 35);
			ownerNameTextBox.Location = new Point(280, 35);

			ownerPhoneLabel = new Label();
			ownerPhoneLabel.Size = new Size(100, 15);
			ownerPhoneLabel.Location = new Point(280, 70);
			ownerPhoneLabel.Text = "Owner phone";
			ownerPhoneTextBox = new TextBox();
			ownerPhoneTextBox.Size = new Size(100, 35);
			ownerPhoneTextBox.Location = new Point(280, 85);

			ownerAddresLabel = new Label();
			ownerAddresLabel.Size = new Size(100, 15);
			ownerAddresLabel.Location = new Point(280, 120);
			ownerAddresLabel.Text = "Owner address";
			ownerAddresTextBox = new TextBox();
			ownerAddresTextBox.Size = new Size(100, 35);
			ownerAddresTextBox.Location = new Point(280, 135);


			ownerMailLabel = new Label();
			ownerMailLabel.Size = new Size(100, 15);
			ownerMailLabel.Location = new Point(280, 170);
			ownerMailLabel.Text = "Owner mail";
			ownerMailTextBox = new TextBox();
			ownerMailTextBox.Size = new Size(100, 35);
			ownerMailTextBox.Location = new Point(280, 185);

			Controls.Add(ownerNameLabel);
			Controls.Add(ownerNameTextBox);
			Controls.Add(ownerPhoneLabel);
			Controls.Add(ownerPhoneTextBox);
			Controls.Add(ownerAddresLabel);
			Controls.Add(ownerAddresTextBox);
			Controls.Add(ownerMailLabel);
			Controls.Add(ownerMailTextBox);
		}

	}
}