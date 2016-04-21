using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;



//Must Add This To An Object or New Before Using
public class BulkDownloader : ScriptableObject
{

    public struct NameAndIndex
    {
        public int m_index;
        public string m_pokemonName;

        public NameAndIndex(int index, string pokemonName)
        {
            m_index = index;
            m_pokemonName = pokemonName;
        }
    }

    //These are colors sampled from Pokemon Energy Cards.
    public int numberOfPokemonCards { get; set; }


    //private Dictionary<Dictionary<int, string>, Texture2D> collectionOfPokemonImages ;
    Dictionary<NameAndIndex, Texture2D> collectionOfPokemonImages;

    public BulkDownloader()
    {
        //collectionOfPokemonImages = new Dictionary<Dictionary<int, string>, Texture2D>();
        collectionOfPokemonImages = new Dictionary<NameAndIndex, Texture2D>();

        WWW www = new WWW("https://docs.google.com/uc?id=0B2xgtpZvfcJwOEsxVlhsTGswcXM");
        Texture2D texture = www.texture;

        collectionOfPokemonImages.Add(new NameAndIndex(5, "Ryan"), texture);

    }

    public Texture2D GetPokeomImageByIndex(int index) //Warning massive overhead
    {
        if(index < 0  || index > numberOfPokemonCards)
        {
            Debug.Log("Indexed the Dictionary of pokemon incorrectly\n");
            return null;
        }

        NameAndIndex temp = new NameAndIndex();

        foreach (NameAndIndex current in collectionOfPokemonImages.Keys)
        {
            if(current.m_index == index)
            {
                temp = current;
                
            }
        }    

        return collectionOfPokemonImages[temp];
    }
}
