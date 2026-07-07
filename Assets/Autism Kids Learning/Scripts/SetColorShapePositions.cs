using UnityEngine;

public class SetColorShapePositions : MonoBehaviour
{
    public bool IsSize = false;
    public Vector3 NewPos,NewScale;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("RemoveAds") == 0)
        {
            GetComponent<Transform>().position = NewPos;
            if (IsSize)
            {
                transform.GetComponent<Transform>().localScale = NewScale;
            }
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
