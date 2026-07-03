using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetPuzzleCount : MonoBehaviour
{
    public static SetPuzzleCount ins;
    public static int Count = 2; // Default value
    public GameObject Gameplay,GotoGame;
    public TMP_Text counterNumber;
    public GameObject SxPiec,home,Scroler;
    private void Awake()
    {

        ins = this;
        if (PlayerPrefs.GetInt("RemoveAds") == 1)
        {
            transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
            GotoGame.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
            SxPiec.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(34,21f, 0);
            SxPiec.transform.GetComponent<RectTransform>().localScale = new Vector3(0.8f, 0.8f, 0);
            home.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(122f, -103f, 0);
            Scroler.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(34, 8f, 0);
            Scroler.transform.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1);
            Scroler.transform.GetComponent<RectTransform>().sizeDelta = new Vector3(1271f, 909f);

        }
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("FirstAnim") == 1)
        {
            GotoGame.SetActive(true);
            gameObject.SetActive(false);
        }


        else if (PlayerPrefs.GetInt("FirstAnim") == 0)
        {
            PlayerPrefs.SetInt("FirstAnim", 1);
            UpdateCounterText();
        }
    }

    public void IncreaseCount()
    {
        SoundManager.instance.PlayEffect_Instance(4);
        if (Count < 6)
        {
            Count += 2;
            UpdateCounterText();
        }
    }

    public void DecreaseCount()
    {
        SoundManager.instance.PlayEffect_Instance(4);
        if (Count > 2)
        {
            Count -= 2;
            UpdateCounterText();
        }
    }

    private void UpdateCounterText()
    {
        counterNumber.text = Count.ToString();
    }
    public void Playbtn()
    {
        SoundManager.instance.PlayEffect_Instance(5);
        //Debug.Log("PuzzleCount set to: " + Count);
        Gameplay.SetActive(true);
        gameObject.SetActive(false);
    }
}
