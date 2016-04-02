#include <iostream>
#include <fstream>
#include <queue>
#include <string>


using std::cout;
using std::cin;
using std::endl;
using std::ifstream;
using std::ofstream;
using std::queue;
using std::string;
using std::getline;
int main()
{
	ofstream PokeData("PokemonData.txt", std::ios::app);

	if (PokeData.is_open())
	{
		bool quit = false;
		char keep = 'n';
		char done = 'n';
		int cardCount;
		//Name, HP, EvolutionStage, Next Evolution, Type/Energy, Attacks(x3), Weakness, Resistance, RetreatCost
		queue<string> pokemonQ;
		string data;
		string buffer;

		cout << "What is the starting card count?: ";
		cin.ignore(cin.rdbuf()->in_avail());
		cin >> cardCount;
		cin.clear();
		cin.ignore(cin.rdbuf()->in_avail());

		
		while (!quit)
		{
			cardCount++;
			keep = 'n';
			done = 'n';

			data = std::to_string(cardCount);
			data += ",";
			cout << data << endl;
			cout << "Pokemon Name: ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "HP: ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "EvolutionStage: ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Evolves To(N): ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Type/Energy: ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Weakness (N): ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Resistance (N): ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Retreat Cost (N): ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Pokemon Power Name(Damage Swap)/(N): ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			if (!(buffer == "N" || buffer == "n"))
			{
				cout << "Pokemon Power Description: ";
				cin.ignore(cin.rdbuf()->in_avail());
				getline(cin, buffer);
				cin.clear();
				cin.ignore(cin.rdbuf()->in_avail());
				data += buffer;
				data += ",";
				system("cls");
				cout << data << endl;
			}

			cout << "Attack 1 Name: ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Attack 1 Description: ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Attack 1 Damage (none): ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Attack 1 Key (R)/(N)/(Y): ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			cout << "Attack 2(N): ";
			cin.ignore(cin.rdbuf()->in_avail());
			getline(cin, buffer);
			cin.clear();
			cin.ignore(cin.rdbuf()->in_avail());
			data += buffer;
			data += ",";
			system("cls");
			cout << data << endl;

			if (!(buffer == "N" || buffer == "n"))
			{

				cout << "Attack 2 Description (none): ";
				cin.ignore(cin.rdbuf()->in_avail());
				getline(cin, buffer);
				cin.clear();
				cin.ignore(cin.rdbuf()->in_avail());
				data += buffer;
				data += ",";
				system("cls");
				cout << data << endl;

				cout << "Attack 2 Damage (N): ";
				cin.ignore(cin.rdbuf()->in_avail());
				getline(cin, buffer);
				cin.clear();
				cin.ignore(cin.rdbuf()->in_avail());
				data += buffer;
				data += ",";
				system("cls");
				cout << data << endl;

				cout << "Attack 2 Key (R)/(N)/(Y): ";
				cin.ignore(cin.rdbuf()->in_avail());
				getline(cin, buffer);
				cin.clear();
				cin.ignore(cin.rdbuf()->in_avail());
				data += buffer;
				data += ",";
				system("cls");
				cout << data << endl;

				cout << "Attack 3 Name(N): ";
				cin.ignore(cin.rdbuf()->in_avail());
				getline(cin, buffer);
				cin.clear();
				cin.ignore(cin.rdbuf()->in_avail());
				data += buffer;
				data += ",";
				system("cls");
				cout << data << endl;

				if (!(buffer == "N" || buffer == "n"))
				{
					cout << "Attack 3 Damage (N): ";
					cin.ignore(cin.rdbuf()->in_avail());
					getline(cin, buffer);
					cin.clear();
					cin.ignore(cin.rdbuf()->in_avail());
					data += buffer;
					data += ",";
					system("cls");
					cout << data << endl;

					cout << "Attack 3 Key (R)/(N)/(Y): ";
					cin.ignore(cin.rdbuf()->in_avail());
					getline(cin, buffer);
					cin.clear();
					cin.ignore(cin.rdbuf()->in_avail());
					data += buffer;
					system("cls");
					cout << data << endl;
					
				}
				
			}

			data += "\n";
	
			while (keep != 'Y' && keep != 'N')
			{
				cout << data << endl << endl;
				cout << "Keep?(Y/N): ";
				cin.ignore(cin.rdbuf()->in_avail());
				cin >> keep;
				cin.clear();
				cin.ignore(cin.rdbuf()->in_avail());
				keep = toupper(keep);
			}
			if (keep == 'Y')
			{
				pokemonQ.push(data);
			}
			while (done != 'Y' && done != 'N')
			{
				cout << data << endl << endl;
				cout << "Done?(Y/N): ";
				cin.ignore(cin.rdbuf()->in_avail());
				cin >> done;
				cin.clear();
				cin.ignore(cin.rdbuf()->in_avail());
				done = toupper(done);
			}
			if (done == 'Y')
			{
				quit = true;
			}
			system("cls");
		}
		while (!pokemonQ.empty())
		{
			buffer = pokemonQ.front();
			pokemonQ.pop();
			PokeData << buffer;
		}
		PokeData.close();
	}
	else
	{
		cout << "Not Open" << endl;
		throw("ERROR: FILE NOT OPEN!");
	}

}