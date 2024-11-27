using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSelf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CloseThisSelf", 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloseThisSelf()
    {
        gameObject.SetActive(false);
    }
}
