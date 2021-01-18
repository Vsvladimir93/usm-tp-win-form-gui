namespace VetClinic
{
	class Pet
	{
		public Pet()
		{}
		public Pet(
			string name, 
			uint age,
			string breed,
			Gender gender,
			string diseases,
			string procedures,
			string medicines,
			string recomendations,
			string ownerName,
			string ownerPhone,
			string ownerAddres,
			string ownerEmail
		)
		{
			Name = name;
			Age = age;
			Breed = breed;
			Gender = gender;
			Diseases = diseases;
			Procedures = procedures;
			Medicines = medicines;
			Recomendations = recomendations;
			OwnerName = ownerName;
			OwnerPhone = ownerPhone;
			OwnerAddres = ownerAddres;
			OwnerEmail = ownerEmail;
		}
		public string Name { get; set; }
		public string Breed { get; set; }
		public uint Age { get; set; }
		public Gender Gender { get; set; }

		public string Diseases { get; set; }
		public string Procedures { get; set; }
		public string Medicines { get; set; }
		public string Recomendations { get; set; }

		public string OwnerName { get; set; }
		public string OwnerPhone { get; set; }
		public string OwnerAddres { get; set; }
		public string OwnerEmail { get; set; }

	}

	public enum Gender {
		Male, Female
	}
}