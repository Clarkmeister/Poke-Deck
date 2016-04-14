#include <iostream>
#include <fstream>
#include <string>

using std::string;
using std::ofstream;
using std::cout;
using std::endl;
using std::cin;
using std::getline;

struct Attack
{
	string attackName;
	string attackDescription;
	string attackDamage;
	string needsFunction;
	string attackType1;
	string attackCost1;
	string attackType2;
	string attackCost2;
};

struct Pokemon
{
	string name;
	string HP;
	string evolution;
	string evolutionStage;
	string poketype;
	string pokemonPower;
	string pokemonPowerDesc;
	Attack attack1;
	Attack attack2;
	Attack attack3;
	string weakness;
	string resistance;
	string retreatCost;
};

void Attack1(Pokemon & pokemon);
void Attack2(Pokemon & pokemon);
void Attack3(Pokemon & pokemon);


int main()
{
	int cardCount;
	ofstream PokeData("PokemonData.txt", std::ios::app);
	if (PokeData.is_open())
	{
		cout << "What is the starting card count?: ";
		cin.ignore(cin.rdbuf()->in_avail());
		cin >> cardCount;
		cin.clear();
		cin.ignore(cin.rdbuf()->in_avail());
	
		string response = "NULL";
		while (response != "done" && response != "Yes" && response != "Y" && response != "y" && response != "yes")
		{
			cardCount++;
			Pokemon pokemon;
			cout << cardCount << ")\n";
			cout << "Name: "; getline(cin, pokemon.name);
			cout << "HP: "; getline(cin, pokemon.HP);
			cout << "Evolution Stage (0-2): "; getline(cin, pokemon.evolutionStage);
			cout << "Next Evolution (None): "; getline(cin, pokemon.evolution);
			if (pokemon.evolution == "None" || pokemon.evolution == "N" || pokemon.evolution == "n" || pokemon.evolution == "none")
			{
				pokemon.evolution = "None";
			}
			cout << "Type (Boxing, Fire, Grass, Lightning, Psychic, Water, Darkness, Metal, Fairy, Colorless): "; getline(cin, pokemon.poketype);
			string hasPokemonPower = "No";
			cout << "Does your pokemon have a poke power(Yes, No): ";
			getline(cin, hasPokemonPower);
			if (hasPokemonPower != "No" && hasPokemonPower != "N" && hasPokemonPower != "n" && hasPokemonPower != "no")
			{
				hasPokemonPower = "Yes";
				cout << "\nPokemon Power: "; getline(cin, pokemon.pokemonPower);
				cout << "Pokemon Power Description: "; getline(cin, pokemon.pokemonPowerDesc);

			}
			else
			{
				pokemon.pokemonPower = "None";
			}
			string anotherAttack = "yes";
			int attackCount = 1;
			if (attackCount == 1)
			{
				Attack1(pokemon);
			}
			cout << "\nAnother Attack? (Yes, No): ";
			getline(cin, anotherAttack);
			if (anotherAttack != "No" && anotherAttack != "N" && anotherAttack != "n" && anotherAttack != "no")
			{
				Attack2(pokemon);
				cout << "\nAnother attack? (Yes, No): ";
				getline(cin, anotherAttack);
				if (anotherAttack != "No" && anotherAttack != "N" && anotherAttack != "n" && anotherAttack != "no")
				{
					attackCount++;
					Attack3(pokemon);
				}
				else
				{
					pokemon.attack3.attackName = "None";
				}
				
			}
			else
			{
				pokemon.attack2.attackName = "None";
				pokemon.attack3.attackName = "None";
			}
			
			
			cout << "\nWeakness (None): "; getline(cin, pokemon.weakness);
			if (pokemon.weakness == "None" || pokemon.weakness == "N" || pokemon.weakness == "n")
			{
				pokemon.weakness = "None";
			}
			cout << "\nResistance (None): "; getline(cin, pokemon.resistance);
			if (pokemon.resistance == "None" || pokemon.resistance == "N" || pokemon.resistance == "n")
			{
				pokemon.resistance = "None";
			}
			cout << "\nRetreat Cost: "; getline(cin, pokemon.retreatCost);
			if (pokemon.retreatCost == "None" || pokemon.retreatCost == "N" || pokemon.retreatCost == "n")
			{
				pokemon.retreatCost = "None";
			}

			cout << "Do you wana save this pokemon(Yes, No): ";
			string savePokemon;
			getline(cin, savePokemon);
			if (savePokemon != "No" && savePokemon != "NO" && savePokemon != "no" && savePokemon != "n" && savePokemon != "N")
			{
				cout << "\nSaving Pokemon...";
				PokeData << cardCount << ")" << endl;
				PokeData << "Name: " << pokemon.name << endl;
				PokeData << "\tHP: " << pokemon.HP << endl;
				PokeData << "\tEvolution Stage: " << pokemon.evolutionStage << endl;
				PokeData << "\tNext Evolution: " << pokemon.evolution << endl;
				if (pokemon.pokemonPower != "None")
				{
					PokeData << "\tPokemon Power: " << pokemon.pokemonPower << endl;
					PokeData << "\tPokePower Description: " << pokemon.pokemonPowerDesc << endl;
				}
				PokeData << "\tType: " << pokemon.poketype << endl;
				for (int i = 0; i < 3; i++)
				{
					Attack temp;
					if (i == 0)
					{
						temp = pokemon.attack1;
					}
					if (i == 1)
					{
						temp = pokemon.attack2;
					}
					if (i == 2)
					{
						temp = pokemon.attack3;
					}

					if (temp.attackName != "None")
					{
						PokeData << "\tAttack name: " << temp.attackName << endl;
						PokeData << "\t\tAttack Description: " << temp.attackDescription << endl;
						PokeData << "\t\tAttack Damage: " << temp.attackDamage << endl;
						PokeData << "\t\tNeeds Custom Function: " << temp.needsFunction << endl;
						PokeData << "\t\tAttack Type 1: " << temp.attackType1 << endl;
						PokeData << "\t\tAttack Cost of Type 1: " << temp.attackCost1 << endl;
						if (temp.attackType2 != "None")

						{
							PokeData << "\t\tAttack Type 2: " << temp.attackType2 << endl;
							PokeData << "\t\tAttack Cost of Type 2: " << temp.attackCost2 << endl;
						}
					}
				}

				PokeData << "\tWeakness: " << pokemon.weakness << endl;
				PokeData << "\tResistance: " << pokemon.resistance << endl;
				PokeData << "\tRetreat Cost: " << pokemon.retreatCost << endl;

				cout << endl;
				
			}
			else
			{
				cout << "Pokemon NOT saved\n";
				pokemon.attack1.attackName = "None";
				pokemon.attack2.attackName = "None";
				pokemon.attack3.attackName = "None";
				pokemon.pokemonPower = "None";
				pokemon.name = "None";
			}

			cout << "\n Are you done entering pokemon: ";
			getline(cin, response);
			cout << endl;
		}

		PokeData.close();
	}
	else
	{
		cout << "Not Open" << endl;
		throw("ERROR: FILE NOT OPEN!");
	}
	return 0;
}

void Attack1(Pokemon & pokemon)
{
	cout << "\nAttack 1 Name: ";
	getline(cin, pokemon.attack1.attackName);
	cout << "\tAttack 1 Description: ";
	getline(cin, pokemon.attack1.attackDescription);
	cout << "\tAttack 1 Damage (0): ";
	getline(cin, pokemon.attack1.attackDamage);
	cout << "Does this require a custom script (Yes, No): ";
	string customScript = "No";
	getline(cin, customScript);
	if (customScript != "No" && customScript != "no" && customScript != "n" && customScript != "N")
	{
		customScript = "Yes";
		pokemon.attack1.needsFunction = pokemon.name + " " + pokemon.attack1.attackName;
	}
	else
	{
		customScript = "No";
		pokemon.attack1.needsFunction = "Regular Function";
	}

	cout << "\tAttack 1 Type(Energy) 1: ";
	getline(cin, pokemon.attack1.attackType1);
	cout << "\tAttack 1 Cost 1: ";
	getline(cin, pokemon.attack1.attackCost1);
	
	cout << "Does this Attack require another energy type to use (Yes, No): ";
	string anotherEneregytype = "No";
	getline(cin, anotherEneregytype);
	if (anotherEneregytype != "No" && anotherEneregytype != "no" && anotherEneregytype != "N" && anotherEneregytype != "n")
	{
		cout << "\tAttack 1 Type(Energy) 2: ";
		getline(cin, pokemon.attack1.attackType2);
		cout << "\tAttack 1 cost 2: ";
		getline(cin, pokemon.attack1.attackCost2);
	}
	else
	{
		pokemon.attack1.attackType2 = "None";
	}
	
}

void Attack2(Pokemon & pokemon)
{
	cout << "\tAttack 2 Name: ";
	getline(cin, pokemon.attack2.attackName);
	cout << "\tAttack 2 Description: ";
	getline(cin, pokemon.attack2.attackDescription);
	cout << "\tAttack 2 Damage (0): ";
	getline(cin, pokemon.attack2.attackDamage);
	cout << "Does this require a custom script (Yes, No): ";
	string customScript = "No";
	getline(cin, customScript);
	if (customScript != "No" && customScript != "no" && customScript != "n" && customScript != "N")
	{
		customScript = "Yes";
		pokemon.attack2.needsFunction = pokemon.name + " " + pokemon.attack2.attackName;
	}
	else
	{
		customScript = "No";
		pokemon.attack2.needsFunction = "Regular Function";
	}

	cout << "\tAttack 2 Type 1(Energy): ";
	getline(cin, pokemon.attack2.attackType1);
	cout << "\tAttack 2 Cost 1: ";
	getline(cin, pokemon.attack2.attackCost1);
	cout << "Does this Attack require another energy type to use (Yes, No): ";
	string anotherEneregytype = "No";
	getline(cin, anotherEneregytype);
	if (anotherEneregytype != "No" && anotherEneregytype != "no" && anotherEneregytype != "N" && anotherEneregytype != "n")
	{
		cout << "\tAttack 2 Type 2 (Energy): ";
		getline(cin, pokemon.attack2.attackType2);
		cout << "\tAttack 2 cost 2: ";
		getline(cin, pokemon.attack2.attackCost2);
	}
	else
	{
		pokemon.attack2.attackType2 = "None";
	}
}

void Attack3(Pokemon & pokemon)
{
	cout << "\tAttack 3 Name: ";
	getline(cin, pokemon.attack3.attackName);
	cout << "\tAttack 3 Description: ";
	getline(cin, pokemon.attack3.attackDescription);
	cout << "\tAttack 1 Damage (0): ";
	getline(cin, pokemon.attack1.attackDamage);
	
	cout << "Does this require a custom script (Yes, No): ";
	string customScript = "No";
	getline(cin, customScript);
	if (customScript != "No" && customScript != "no" && customScript != "n" && customScript != "N")
	{
		customScript = "Yes";
		pokemon.attack3.needsFunction = pokemon.name + " " + pokemon.attack3.attackName;
	}
	else
	{
		customScript = "No";
		pokemon.attack3.needsFunction = "Regular Function";
	}

	cout << "\tAttack 3 Type(Energy) 1: ";
	getline(cin, pokemon.attack3.attackType1);
	cout << "\tAttack 3 Cost 1: ";
	getline(cin, pokemon.attack3.attackCost1);
	cout << "Does this Attack require another energy type to use (Yes, No): ";
	
	string anotherEneregytype = "No";
	getline(cin, anotherEneregytype);
	if (anotherEneregytype != "No" && anotherEneregytype != "no" && anotherEneregytype != "N" && anotherEneregytype != "n")
	{
		cout << "\tAttack 3 Type(Energy) 2: ";
		getline(cin, pokemon.attack3.attackType2);
		cout << "\tAttack 3 cost 2: ";
		getline(cin, pokemon.attack3.attackCost2);
	}
	else
	{
		pokemon.attack3.attackType2 = "None";
	}
}
