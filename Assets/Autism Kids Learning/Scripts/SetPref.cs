using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPref : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("ShapeIsChosse", 0);
        PlayerPrefs.SetInt("PLayDrawON", 0);
        PlayerPrefs.SetInt("Purchased", 1);
        PlayerPrefs.SetInt("RateCounter",0);
        PlayerPrefs.SetInt("Completed", 0);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
