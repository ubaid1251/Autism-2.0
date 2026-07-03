using UnityEngine;

public class CheckColorScreen : MonoBehaviour
{
    public GameObject UI_Obj, Bar,Board;

    private void Awake()
    {

        if (PlayerPrefs.GetInt("RemoveAds") == 1)
        {
            UI_Obj.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
            Bar.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(12.35f, -150.39f, 0);
            Board.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(12, -132, 0);

            Bar.transform.GetComponent<RectTransform>().localScale = new Vector3(0.85f, 0.8f, 0.85f);
            Board.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(1090.2f, 748.42f);
        }
    }

}
