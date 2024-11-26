using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSelf : MonoBehaviour
{
    public GameObject mouse;

    public Vector2 pos;

    public Vector2 pos1;

    private bool reach;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!reach && mouse.transform.position.x > pos.x && mouse.transform.position.y < pos.y && mouse.transform.position.x < pos1.x)
        {
            Debug.Log("P");
            gameObject.GetComponent<SpriteMask>().enabled = true;
            GameObject.Find("Progress").SendMessage("ChangeImage");
            mouse.transform.GetChild(0).localPosition = new Vector3(-2.5f, 0.0f, 0.0f);
            mouse.transform.GetChild(0).localScale = new Vector3(6.0f, 1.0f, 1.0f);
            mouse.transform.GetChild(0).gameObject.SetActive(false);
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
