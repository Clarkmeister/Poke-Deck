using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextColorChange : MonoBehaviour
{
    PokemonColors _PokemonColor;

    void Start()
    {
        _PokemonColor = new PokemonColors();
    }

    public void ToFireRed(Text _ToBeChanged)
    {
        _ToBeChanged.color = _PokemonColor.FireRed;
    }

    public void ToLightningYellow(Text _ToBeChanged)
    {
        _ToBeChanged.color = _PokemonColor.LightningYellow;
    }

    public void ToGrassGreen(Text _ToBeChanged)
    {
        _ToBeChanged.color = _PokemonColor.GrassGreen;
    }

    public void ToPsychicPurple(Text _ToBeChanged)
    {
        _ToBeChanged.color = _PokemonColor.PsychicPurple;
    }

    public void ToFighterOrange(Text _ToBeChanged)
    {
        _ToBeChanged.color = _PokemonColor.FighterOrange;
    }

    public void ToWaterBlue(Text _ToBeChanged)
    {
        _ToBeChanged.color = _PokemonColor.WaterBlue;
    }

    public void ToPokemonBlue(Text _ToBeChanged)
    {
        _ToBeChanged.color = _PokemonColor.PokemonBlue;
    }

    public void ToWhite(Text _ToBeChanged)
    {
        _ToBeChanged.color = Color.white;
    }

    public void ToBlack(Text _ToBeChanged)
    {
        _ToBeChanged.color = Color.black;
    }

}
