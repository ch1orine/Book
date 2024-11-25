using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
    private ButtonExtension btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<ButtonExtension>();
        btn.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            btn.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            btn.enabled = false;
        }
    }
}
