using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutUpSelf : MonoBehaviour
{
    public GameObject ob;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CloseThisSelf", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloseThisSelf()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        ob.SetActive(true);
    }
}
