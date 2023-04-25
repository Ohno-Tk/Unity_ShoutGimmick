/**
<summary>
ウィンドウキャプチャ

・参考サイト
https://github.com/ruccho/UnityGraphicsCapture
</summary>
*/
using System.Collections.Generic;
using System.Linq;
using Ruccho.GraphicsCapture;
using UnityEngine;
using UnityEngine.UI;
using System.Windows;

public class CaptureSample : MonoBehaviour
{
    [SerializeField]
    private RawImage previewImage = default;

    [SerializeField]
    private Dropdown dropdown;

    private Capture capture = default;

    private void Start()
    {
        IEnumerable<ICaptureTarget> targets = Utils.GetTargets();

        foreach (var item in targets)
        {
            Debug.Log(item.Description);
            dropdown.options.Add(new Dropdown.OptionData { text = item.Description });
        }
        dropdown.RefreshShownValue();

        var target = targets.First();
        //var target = targets[2];
        Debug.Log(target.Description);
        capture = new Capture(target);
        capture.Start();
    }

    private void Update()
    {
        if(capture != null)
        {
            //Call GetTexture() every frame to update Unity's texture from native texture.
            previewImage.texture = capture.GetTexture();
        }
    }

    public void ChangeWindows()
    {
        IEnumerable<ICaptureTarget> targets = Utils.GetTargets();
        var target = targets.ElementAt(dropdown.value);
        capture = new Capture(target);
        capture.Start();
    }

    private void OnDestroy()
    {
        //Don't forget to stop capturing manually.
        capture?.Dispose();
    }
}