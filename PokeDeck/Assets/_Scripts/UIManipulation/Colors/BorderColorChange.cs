using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BorderColorChange : MonoBehaviour
{
    PokemonColors _PokeColors;
    public Outline _Outline;
  
	void Start ()
    {
        _PokeColors = PokemonColors.CreateInstance<PokemonColors>();
    }

    public void ToFireRed(Outline _ToBeChanged)
    {
        _ToBeChanged.effectColor = _PokeColors.FireRed;
    }

    public void ToLightningYellow(Outline _ToBeChanged)
    {
        _ToBeChanged.effectColor = _PokeColors.LightningYellow;
    }

    public void ToGrassGreen(Outline _ToBeChanged)
    {
        _ToBeChanged.effectColor = _PokeColors.GrassGreen;
    }

    public void ToPsychicPurple(Outline _ToBeChanged)
    {
        _ToBeChanged.effectColor = _PokeColors.PsychicPurple;
    }

    public void ToFighterOrange(Outline _ToBeChanged)
    {
        _ToBeChanged.effectColor = _PokeColors.FighterOrange;
    }

    public void ToWaterBlue(Outline _ToBeChanged)
    {
        _ToBeChanged.effectColor = _PokeColors.WaterBlue;
    }

    public void ToPokemonBlue(Outline _ToBeChanged)
    {
        _ToBeChanged.effectColor = _PokeColors.PokemonBlue;
    }

    public void ToWhite(Outline _ToBeChanged)
    {
        _ToBeChanged.effectColor = Color.white;
    }

    public void ToBlack(Outline _ToBeChanged)
    {
        _ToBeChanged.effectColor = Color.black;
    }


}
