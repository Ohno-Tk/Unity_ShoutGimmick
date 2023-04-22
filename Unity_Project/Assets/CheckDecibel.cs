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

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("現在のデシベル："+(micAS.GetNow_dB + 80 ));

        // 大声時
        if(Input.GetKey (KeyCode.DownArrow))
        //if(50 <= micAS.GetNow_dB + 80)
        {
            Effect.GetComponent<Image>().enabled = true;
            WindowsCapture.GetComponent<SizeUpDown>().SizeUp();
            WindowsCapture.GetComponent<RawImage>().color = new Color(1.0f,1.0f,1.0f,0.8f);
        }
        else
        {
            Effect.GetComponent<Image>().enabled = false;
            WindowsCapture.GetComponent<SizeUpDown>().Sizedown();
            WindowsCapture.GetComponent<RawImage>().color = new Color(1.0f,1.0f,1.0f,1.0f);
        }
    }
}
