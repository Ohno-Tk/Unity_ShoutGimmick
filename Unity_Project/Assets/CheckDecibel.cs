/**
<summary>
デシベルチェック
</summary>
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckDecibel : MonoBehaviour
{
    //dBを取得する対象のmicAudioSource
    [SerializeField]
    private MicAudioSource micAS = null;

    [SerializeField]
    private GameObject Effect = null;

    [SerializeField]
    private GameObject WindowsCapture = null;

    // デシベル規定値
    [SerializeField]
    private float MinDecibel = 40.0f;

    // Update is called once per frame
    void Update()
    {

        Debug.Log("現在のデシベル："+(micAS.GetNow_dB_Normalize ));

        // 大声時
        if(Input.GetKey (KeyCode.DownArrow))
        //if(MinDecibel <= micAS.GetNow_dB_Normalize)
        {
            Effect.GetComponent<Image>().enabled = true;
            WindowsCapture.GetComponent<SizeUpDown>().SizeChange(new Vector2(1920, 1080));
            WindowsCapture.GetComponent<RawImage>().color = new Color(1.0f,1.0f,1.0f,0.8f);
        }
        else
        {
            Effect.GetComponent<Image>().enabled = false;
            WindowsCapture.GetComponent<SizeUpDown>().SizeChange(new Vector2(1024, 576));
            WindowsCapture.GetComponent<RawImage>().color = new Color(1.0f,1.0f,1.0f,1.0f);
        }
    }
}
