using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PokemonData : MonoBehaviour
{
	public enum EVOLUTION_STAGE {FIRST_EVOLUTION, SECOND_EVOLUTION, FINAL_EVOLUTION}

	public enum ENERGY_TYPE {GRASS, WATER, FIRE, FIGHTING, LIGHTNING, PSYCHIC, COLORLESS}

	int m_pokemonNumber { get; set; }
	string m_name { get; set; }
	int m_HP { get; set; }
	EVOLUTION_STAGE m_evolutionStage { get; set; }
	string m_nextEvolution { get; set; }
	string m_previousEvolution { get; set; }
	ENERGY_TYPE m_energyType { get; set; }
	ENERGY_TYPE m_weakness {get; set; }
	ENERGY_TYPE m_resistance { get; set; }
	int m_resistanceAddend { get; set; }
	int m_retreatCost { get; set; }
	Stack<int> m_damageCount = new Stack<int>();
	List<ENERGY_TYPE> m_attached = new List<ENERGY_TYPE>();

}
