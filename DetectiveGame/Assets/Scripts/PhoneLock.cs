using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "FingerPrint")
        {
            Debug.Log("잠금 해제");
        }
    }
}
