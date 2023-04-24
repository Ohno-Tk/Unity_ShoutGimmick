using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetting : MonoBehaviour
{
    [SerializeField]
    private KeyCode UIDisplay = KeyCode.F1;

    [SerializeField]
    private GameObject UI;
    private bool UIDispFlg = true;

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
    }
}
