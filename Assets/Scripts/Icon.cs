using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public GameObject pic;

    public GameObject text;

    private ButtonExtension btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<ButtonExtension>();
        btn.enabled = false;
        pic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        btn.enabled = true;
        pic.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        btn.enabled = false;
        pic.SetActive(false);     
    }
}
