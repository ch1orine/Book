using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSelf : MonoBehaviour
{
    public GameObject mouse;

    public Vector2 pos;

    private bool reach;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!reach && mouse.transform.position.x > pos.x && mouse.transform.position.y < pos.y)
        {
            Debug.Log("P");
            gameObject.GetComponent<SpriteMask>().enabled = true;
            GameObject.Find("Progress").SendMessage("ChangeImage");
            reach = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("P");
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<SpriteMask>().enabled = true;
            GameObject.Find("Progress").SendMessage("ChangeImage");
        }
    }
}
