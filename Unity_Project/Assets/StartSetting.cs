using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSetting : MonoBehaviour
{
    [SerializeField]
    private KeyCode UIDisplay = KeyCode.F1;

    [SerializeField]
    private GameObject UI;
    private bool UIDispFlg = true;

    [SerializeField]
    private MicAudioSource micAS = null;

    [SerializeField]
    private GameObject DecibelUI = null;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(UIDisplay))
        {
            UIDispFlg ^= true;
            UI.SetActive(UIDispFlg);
        }

        DecibelUI.GetComponent<Text>().text = "現在のデシベル数：" + Mathf.Floor(micAS.GetNow_dB_Normalize) + "デシベル";
    }
}
