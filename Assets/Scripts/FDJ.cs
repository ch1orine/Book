using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FDJ : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        transform.position = new(-4.0f, 8.0f);


    }

    // Update is called once per frame
    void Update()
    {        
        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0.0f); 
    }

    
}
