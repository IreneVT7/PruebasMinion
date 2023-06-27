using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QualityMaterialChanger1 : MonoBehaviour
{
    public TMP_Text text;
    [Tooltip("Orden: Bichoquema grande, Bichoquema mini")]
    public SkinnedMeshRenderer[] characters;
    [Header("Materials")]
    public Material[] bichoMats;

    int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        // for (int i = 0; i < characters.Length; i++)
        // {
        //     characters[i].gameObject.SetActive(false);
        // }
        characters[0].material = bichoMats[0];
        characters[1].material = bichoMats[0];
        // characters[0].gameObject.SetActive(true);
        text.text = "Current\n1024";
    }

    public void ChangeSize(int divider)
    {
        characters[0].material = bichoMats[divider];
        characters[1].material = bichoMats[divider];

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
            characters[i].gameObject.SetActive(false);
        }
        index++;
        if (index >= characters.Length)
            index = 0;

        characters[index].gameObject.SetActive(true);
    }
}
