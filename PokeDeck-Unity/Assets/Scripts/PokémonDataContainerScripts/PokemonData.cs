using UnityEngine;
using System.Collections;

public class PokemonData : MonoBehaviour
{
	public enum EVOLUTION_STAGE {FIRST_EVOLUTION, SECOND_EVOLUTION, FINAL_EVOLUTION}

	public enum ENERGY_TYPE {GRASS, WATER, FIRE, FIGHTING, LIGHTNING, PSYCHIC, COLORLESS}

	

	string m_name { get; set; }
	int m_HP { get; set; }
	EVOLUTION_STAGE m_evolutionStage { get; set; }
	string m_nextEvolution { get; set; }
	string m_previousEvolution { get; set; }
	ENERGY_TYPE m_energyType { get; set; }
	ENERGY_TYPE m_weakness {get; set; }
	int m_resistanceAddend { get; set; } 

	
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
