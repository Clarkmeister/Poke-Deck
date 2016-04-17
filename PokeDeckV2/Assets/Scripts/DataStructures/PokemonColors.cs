using UnityEngine;
using System.Collections;

//Must Add This To An Object or New Before Using
public class PokemonColors : MonoBehaviour
{
    //These are colors sampled from Pokemon Energy Cards.
    public Color32 FireRed { get; set; }
    public Color32 LightningYellow { get; set; }
    public Color32 GrassGreen { get; set; }
    public Color32 PsychicPurple { get; set; }
    public Color32 FighterOrange { get; set; }
    public Color32 WaterBlue { get; set; }
    public Color32 PokemonBlue { get; set; }

    public PokemonColors()
    {
        FireRed = new Color32(211, 60, 49, 255);
        LightningYellow = new Color32(236, 208, 45, 255);
        GrassGreen = new Color32(120, 160, 60, 255);
        PsychicPurple = new Color32(100, 86, 132, 255);
        FighterOrange = new Color32(220, 103, 34, 255);
        WaterBlue = new Color32(70, 140, 190, 255);
        PokemonBlue = new Color32(6, 52, 135, 255);
    }
}
