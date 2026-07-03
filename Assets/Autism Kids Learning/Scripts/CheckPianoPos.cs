using UnityEngine;
using DG.Tweening;
public class CheckPianoPos : MonoBehaviour
{
    public RectTransform home;
    public Transform AllChs, Rabit;
    void Awake()
    {
        if (PlayerPrefs.GetInt("RemoveAds") == 1)
        {
            home.DOAnchorPosY(-100, 0);
            AllChs.localScale = new Vector3(1f, 1f, 1f);
            Rabit.localScale = new Vector3(0.32f, 0.32f, 0.32f);
            Rabit.localPosition = new Vector3(3.94f, 1, 0);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
