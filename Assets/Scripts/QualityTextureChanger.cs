using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QualityTextureChanger : MonoBehaviour
{
    public TMP_Text text;
    public GameObject[] characters;
    int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
        characters[0].SetActive(true);
        QualitySettings.globalTextureMipmapLimit = 0;
        text.text = "Current\n1024";
    }

    public void ChangeSize(int divider)
    {
        QualitySettings.globalTextureMipmapLimit = divider;
        if (divider == 0)
            text.text = "Current\n1024";
        else if (divider == 1)
            text.text = "Current\n512";
        else if (divider == 2)
            text.text = "Current\n256";
        else if (divider == 3)
            text.text = "Current\n128";
        else if (divider == 4)
            text.text = "Current\n64";
    }

    public void Toogle()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
        index++;
        if (index >= characters.Length)
            index = 0;

        characters[index].SetActive(true);
    }
}
