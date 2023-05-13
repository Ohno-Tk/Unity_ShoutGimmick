/**
<summary>
2D素材　拡大縮小
</summary>
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUpDown_2D : MonoBehaviour
{
    /**
    <summary>
    サイズ変更
    </summary>
    <param name="size">拡大するサイズ</param>
    */
    public void SizeChange(Vector2 size)
    {
        this.GetComponent<RectTransform>().sizeDelta = size;
    }
}
