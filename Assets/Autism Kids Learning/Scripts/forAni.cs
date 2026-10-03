using UnityEngine;
using UnityEngine.UI;
public class forAni : MonoBehaviour
{
    public ScrollRect scrol;
    public void offScroll()
    {
        scrol.enabled = true;
        GetComponent<Animator>().enabled = false;
    }
}
