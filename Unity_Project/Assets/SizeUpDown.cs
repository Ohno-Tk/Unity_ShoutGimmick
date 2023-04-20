using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUpDown : MonoBehaviour
{
    private Vector2 MaxSize;
    private Vector2 MinSize;

    // Start is called before the first frame update
    void Start()
    {
        MaxSize.x = 1920;
        MaxSize.y = 1080;

        MinSize.x = 1024;
        MinSize.y = 576;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            this.GetComponent<RectTransform>().sizeDelta = MaxSize;
        }
        else
        {
            this.GetComponent<RectTransform>().sizeDelta = MinSize;
        }
    }
}
