using UnityEngine;
using DG.Tweening;
public class CheckFruitsPos : MonoBehaviour
{
    public RectTransform home, All_Item, dumy_Obj;
    public GameObject Parent_Obj;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("RemoveAds") == 1)
        {
            home.DOAnchorPosY(-103, 0);
            Parent_Obj.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
            All_Item.anchoredPosition = dumy_Obj.anchoredPosition;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
