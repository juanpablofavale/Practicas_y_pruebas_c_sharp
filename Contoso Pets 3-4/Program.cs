// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
	switch (i)
	{
		case 0:
		        animalSpecies = "dog";
		        animalID = "d1";
		        animalAge = "2";
		        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
		        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
		        animalNickname = "lola";
			break;
		case 1:
		        animalSpecies = "dog";
		        animalID = "d2";
		        animalAge = "9";
		        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
		        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
		        animalNickname = "loki";
			break;
		case 2:
		        animalSpecies = "cat";
		        animalID = "c3";
		        animalAge = "1";
		        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
		        animalPersonalityDescription = "friendly";
		        animalNickname = "Puss";
			break;
		case 3:
		        animalSpecies = "cat";
		        animalID = "c4";
		        animalAge = "?";
		        animalPhysicalDescription = "";
		        animalPersonalityDescription = "";
		        animalNickname = "";
			break;
		default:
		        animalSpecies = "";
		        animalID = "";
		        animalAge = "";
		        animalPhysicalDescription = "";
		        animalPersonalityDescription = "";
		        animalNickname = "";
			break;
	}

	ourAnimals[i, 0] = "ID #: " + animalID;
	ourAnimals[i, 1] = "Species: " + animalSpecies;
	ourAnimals[i, 2] = "Age: " + animalAge;
	ourAnimals[i, 3] = "Nickname: " + animalNickname;
	ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
	ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// TODO Voy por la unidad 4 de 8

// display the top-level menu options
do
{
	Console.Clear();

	Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
	Console.WriteLine(" 1. List all of our current pet information");
	Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
	Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
	Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
	Console.WriteLine(" 5. Edit an animal’s age");
	Console.WriteLine(" 6. Edit an animal’s personality description");
	Console.WriteLine(" 7. Display all cats with a specified characteristic");
	Console.WriteLine(" 8. Display all dogs with a specified characteristic");
	Console.WriteLine();
	Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

	readResult = Console.ReadLine();
	if (readResult != null)
	{
	    menuSelection = readResult.ToLower();
	}

	Console.WriteLine();
	Console.WriteLine($"You selected menu option {menuSelection}.");

	switch (readResult)
	{
		case "1":
		        // List all of our current pet information
			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i , 0] != "ID #: ")
				{
					for (int j = 0; j <= 5; j++)
					{
						Console.WriteLine(ourAnimals[i,j]);
					}
					Console.WriteLine();
				}
			}
			
		        Console.WriteLine("Press the Enter key to continue.");
		        readResult = Console.ReadLine();
			break;

		case "2":
		        // Add a new animal friend to the ourAnimals array

			string anotherPet = "y";
			int petCount = 0;

			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[ i , 0 ] != "ID #: ") petCount++;
			}

			if (petCount < maxPets) Console.WriteLine($"There is {petCount} of {maxPets} animals in the system.");

			while (anotherPet == "y" && petCount < maxPets)
			{
				petCount++;

				Console.WriteLine("Enter a specie (cat/dog)");
				do
				{
					readResult = Console.ReadLine();
					if (readResult != null) animalSpecies = readResult.ToLower();

				} while (animalSpecies != "dog" && animalSpecies != "cat");

				animalID = animalSpecies.Substring(0, 1) + petCount.ToString();

				int petAge = 0;
				Console.WriteLine("Enter the pet's age (? if unknown)");
				do
				{
					readResult = Console.ReadLine();
					if (readResult != null) animalAge = readResult;

				} while (animalAge != "?" && !int.TryParse(animalAge, out petAge));

				Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
				readResult = Console.ReadLine();
				if (readResult != "" && readResult != null)
				{
					animalPhysicalDescription = readResult.ToLower();
				}
				else
				{
					animalPhysicalDescription = "tdb";
				}

				Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
				readResult = Console.ReadLine();
				if (readResult != "" && readResult != null)
				{
					animalPersonalityDescription = readResult.ToLower();
				}
				else
				{
					animalPersonalityDescription = "tdb";
				}

				Console.WriteLine("Enter a nickname for the pet");
				readResult = Console.ReadLine();
				if (readResult != "" && readResult != null)
				{
					animalNickname = readResult.ToLower();
				}
				else
				{
					animalNickname = "tdb";
				}

				Console.WriteLine("You're entered the follow pet's information:");
				Console.WriteLine($"{animalID}\n{animalSpecies}\n{animalAge}\n{animalPhysicalDescription}\n{animalPersonalityDescription}\n{animalNickname}\n");

				ourAnimals[petCount, 0] = "ID #: " + animalID;
				ourAnimals[petCount, 1] = "Species: " + animalSpecies;
				ourAnimals[petCount, 2] = "Age: " + animalAge;
				ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
				ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
				ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

				if (petCount < maxPets)
				{
					Console.WriteLine("Do you want to enter info for another pet (y/n)");
					do
					{
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							anotherPet = readResult.ToLower();
						}

					} while (anotherPet != "y" && anotherPet != "n");
				}
			}

			if (petCount >= maxPets)
			{
				Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
			        Console.WriteLine("Press the Enter key to continue.");
			        readResult = Console.ReadLine();
			}

			break;

		case "3":
		        // Ensure animal ages and physical descriptions are complete

			for (int i = 0 ; i < maxPets ; i++)
			{
				if (ourAnimals[i, 0] != "ID #: ")
				{
					int petAge;
					animalAge = ourAnimals[i, 2].Substring(5);
					while (!int.TryParse(animalAge, out petAge))
					{
						Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							animalAge = readResult;
						}
					}
					ourAnimals[i, 2] = "Age: " + animalAge;

					animalPhysicalDescription = ourAnimals[i, 4].Substring(22);
					while (animalPhysicalDescription.Length <= 0 || animalPhysicalDescription == null)
					{
						Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, breed, gender, weight, housebroken)");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							animalPhysicalDescription = readResult.ToLower();
						}
					}
					ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
				}
			}

			Console.WriteLine("\nAge and physical description fields are complete for all of our friends.");
		        Console.WriteLine("\nPress the Enter key to continue.");
		        readResult = Console.ReadLine();
			break;

		case "4":
		        // Ensure animal nicknames and personality descriptions are complete

			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "ID #: ")
				{
					animalPersonalityDescription = ourAnimals[i, 5].Substring(13);
					while (animalPersonalityDescription.Length <= 0 || animalPersonalityDescription == null)
					{
						Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							animalPersonalityDescription = readResult.ToLower();
						}
					}
					ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

					animalNickname = ourAnimals[i, 3].Substring(10);
					while (animalNickname.Length <= 0 || animalNickname == null)
					{
						Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							animalNickname = readResult.ToLower();
						}
					}
					ourAnimals[i, 3] = "Nickname: " + animalNickname;
				}
			}

		        Console.WriteLine("\nNickname and personality description fields are complete for all of our friends.");
		        Console.WriteLine("\nPress the Enter key to continue.");
		        readResult = Console.ReadLine();			
			break;

		case "5":
		        // Edit an animal’s age
		        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
		        Console.WriteLine("Press the Enter key to continue.");
		        readResult = Console.ReadLine();			
			break;

		case "6":
		        // Edit an animal’s personality description
		        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
		        Console.WriteLine("Press the Enter key to continue.");
		        readResult = Console.ReadLine();			
			break;

		case "7":
		        // Display all cats with a specified characteristic
		        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
		        Console.WriteLine("Press the Enter key to continue.");
		        readResult = Console.ReadLine();			
			break;

		case "8":
		        // Display all dogs with a specified characteristic
		        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
		        Console.WriteLine("Press the Enter key to continue.");
		        readResult = Console.ReadLine();			
			break;
	}

} while (menuSelection != "exit" && menuSelection != "0");

