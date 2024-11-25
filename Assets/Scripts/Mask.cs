using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public GameObject btn;

    public float x = 4.5f;

    private bool reach;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector2(transform.position.x, -3.0f);
        if (!reach && transform.position.x > x)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Progress").SendMessage("ChangeImage");
            reach = true;
            transform.SetParent(GameObject.Find("Progress").transform);
            gameObject.SetActive(false);
            if (btn)
            {
                btn.SetActive(true);
            }
            GameObject.Find("Player").transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            transform.SetParent(collision.gameObject.transform);
            transform.localPosition = new Vector2(-17.0f, -2.0f);
        }
    }
}
