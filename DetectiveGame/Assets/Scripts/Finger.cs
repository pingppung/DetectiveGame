using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger : MonoBehaviour
{
    public GameObject kakaoWindow;
    public GameObject basicWindow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col);
        if (col.transform.tag == "Kakaotalk")
        {
            basicWindow.SetActive(false);
            kakaoWindow.SetActive(true);
        }
    }
}
