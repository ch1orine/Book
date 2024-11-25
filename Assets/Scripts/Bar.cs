using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    
    public Sprite[] pro;

    public GameObject sign;

    private SpriteRenderer sr;

    [HideInInspector]
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeImage()
    {
        index++;
        index %= pro.Length;
        sr.sprite = pro[index];

        if (index == pro.Length - 1)
        {
            sign.SetActive(true);
        }
    }
}
