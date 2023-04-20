using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    //dBを取得する対象のmicAudioSource
    [SerializeField]
    private MicAudioSource micAS = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("現在のデシベル："+(micAS.GetNow_dB + 80 ));
    }
}
