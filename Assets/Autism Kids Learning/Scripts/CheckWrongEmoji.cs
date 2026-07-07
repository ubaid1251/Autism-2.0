using UnityEngine;

public class CheckWrongEmoji : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Awake()
    {
 
        if (PlayerPrefs.GetInt("RemoveAds") == 1)
        {
            GetComponent<RectTransform>().sizeDelta = new Vector3(0f, 0f);
            GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        }

    }
}
