using UnityEngine;
using System.Collections;
using System.IO;

public class downloder : MonoBehaviour
{
    IEnumerator Start()
    {

        if (File.Exists(Application.persistentDataPath + "testTexture.png"))
        {
            print("Loading from the computer");
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "testTexture.png");
            Texture2D texture = new Texture2D(8, 8);
            texture.LoadImage(byteArray);

            this.GetComponent<Renderer>().material.mainTexture = texture;
        }
        else
        {
            print("Load from web");
            WWW www = new WWW("https://docs.google.com/uc?id=0B2xgtpZvfcJwOEsxVlhsTGswcXM");
            yield return www;

            Texture2D texture = www.texture;
            this.GetComponent<Renderer>().material.mainTexture = texture;
            byte[] bytes = texture.EncodeToPNG();
            File.WriteAllBytes(Application.persistentDataPath + "testTexture.png", bytes);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
