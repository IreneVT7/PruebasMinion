using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameCounter : MonoBehaviour
{
    [SerializeField] Text text;
    float pollingTime = 1f;
    float time;
    int frameCount;

    private void Start()
    {
        Application.targetFrameRate = Screen.currentResolution.refreshRate;
        QualitySettings.vSyncCount = 0;
    }
    void Update()
    {
        time += Time.deltaTime;
        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            text.text = frameRate.ToString() + " FPS";

            time -= pollingTime;
            frameCount = 0;
        }
    }
}
