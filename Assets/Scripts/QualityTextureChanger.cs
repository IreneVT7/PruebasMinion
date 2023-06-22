using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QualityTextureChanger : MonoBehaviour
{
    public TMP_Text text;


    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.globalTextureMipmapLimit = 0;
        text.text = "Current\n2048";
    }

    public void ChangeSize(int divider)
    {
        QualitySettings.globalTextureMipmapLimit = divider;
        if (divider == 0)
            text.text = "Current\n2048";
        else if (divider == 1)
            text.text = "Current\n1024";
        else if (divider == 2)
            text.text = "Current\n512";
    }
}
