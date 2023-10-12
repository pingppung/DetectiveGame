using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int a =0;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        // A버튼을 눌렀을 때
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            if (a == 0)
            {
                panel.SetActive(true);
            }

            else
            {
                panel.SetActive(true);
            }
        }

    }
}
