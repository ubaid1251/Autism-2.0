using UnityEngine;

public class BannerCheck : MonoBehaviour
{

    private void OnEnable()
    {
        IntitializeAdmob.instance.HideBanner();
    }
    private void OnDisable()
    {
        IntitializeAdmob.instance.HideBanner();
    }

}
