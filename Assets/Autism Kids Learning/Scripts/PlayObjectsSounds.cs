using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayObjectsSounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("RemoveAds") == 1)
        {
            transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
            transform.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
        }
    }

    // Update is called once per frame
    public void PLayAnimalSounds(string name)
    {
        if(name== "cat")
        {
            SoundManager.instance.PlayAnimalEffect_Complete(0);
        }
        else if (name == "dog")
        {
            SoundManager.instance.PlayAnimalEffect_Complete(2);
        }
        else if (name == "elephant")
        {
            SoundManager.instance.PlayAnimalEffect_Complete(3);
        }
        else if (name == "chick")
        {
            SoundManager.instance.PlayAnimalEffect_Complete(1);
        }
        else if (name == "panda")
        {
            SoundManager.instance.PlayAnimalEffect_Complete(9);
        }
        else if (name == "monkey")
        {
            SoundManager.instance.PlayAnimalEffect_Complete(7);
        }
    }
}
