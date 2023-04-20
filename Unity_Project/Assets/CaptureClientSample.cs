using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Ruccho.GraphicsCapture;
using UnityEngine;
using UnityEngine.UI;

public class CaptureClientSample : MonoBehaviour
{
    [SerializeField] private RawImage previewImage = default;

    private CaptureClient client = new CaptureClient();

    private void Start()
    {
        StartCoroutine(ChangeTarget());
    }

    private IEnumerator ChangeTarget()
    {
        for(int i = 0; ; i++)
        {
            IEnumerable<ICaptureTarget> targets = Utils.GetTargets();
            int targetIndex = i % targets.Count();
            var target = targets.ElementAt(targetIndex);

            bool failed = false;
            try
            {
                client.SetTarget(target);
            }
            catch (CreateCaptureException e)
            {
                //SetTarget() throws CreateCaptureException when it failed to start capturing.
                failed = true;
            }

            if (failed)
            {
                yield return null;
                continue;
            }
            
            yield return new WaitForSeconds(3f);
        }
    }

    private void Update()
    {
        //Call GetTexture() every frame to update Unity's texture from native texture.
        previewImage.texture = client.GetTexture();
    }

    private void OnDestroy()
    {
        //Don't forget to stop capturing manually.
        client?.Dispose();
    }
}