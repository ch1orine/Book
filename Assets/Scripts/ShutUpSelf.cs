using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutUpSelf : MonoBehaviour
{
    public GameObject ob;

    public float time = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CloseThisSelf", time);
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
