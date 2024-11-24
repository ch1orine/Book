using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonExtension : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    public Sprite normal;
    public Sprite press;

    public float pressDurationTime = 1;
    public bool responseOnceByPress = false;
    public float doubleClickIntervalTime = 0.5f;
    public bool changeImage = false;

    public UnityEvent onDoubleClick;
    public UnityEvent onPress;
    public UnityEvent onClick;

    private bool isDown = false;  //按下
    private bool isPress = false; //按住生效
    private float downTime = 0;

    private float clickIntervalTime = 0;
    private int clickTimes = 0;

    [HideInInspector]
    public SpriteRenderer sp;
    // Update is called once per frame
    private void Awake()
    {
        if (changeImage)
        {
            sp = GetComponent<SpriteRenderer>();
            sp.sprite = normal;
        }
        onClick.AddListener(ClickOnce);
        onDoubleClick.AddListener(DoubleClick);
        onPress.AddListener(Press);
    }

    void Update()
    {
        if (isDown)
        {
            if (responseOnceByPress && isPress)
            {
                return;
            }
            downTime += Time.deltaTime;
            if (downTime > pressDurationTime) //长按时间累计大于目标值后生效
            {
                isPress = true;
                onPress.Invoke();
            }
        }

        if (clickTimes >= 1)
        {
            clickIntervalTime += Time.deltaTime;
            if (clickIntervalTime >= doubleClickIntervalTime) //超出时间进行判断，大于等于两次执行双击，否则执行单击，并清空点击次数与双击间隔
            {
                if (clickTimes >= 2)
                {
                    onDoubleClick.Invoke();
                }
                else
                {
                    onClick.Invoke();
                }
               
                clickTimes = 0;
                clickIntervalTime = 0;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData) //按下
    {
        isDown = true;
        downTime = 0;
        if (sp)
        {
            sp.sprite = press;        
        }
        GameObject ob = eventData.pointerCurrentRaycast.gameObject;
        Debug.Log(ob.name);
    }

    public void OnPointerUp(PointerEventData eventData) //抬起
    {
        isDown = false;
        if (sp)
        { 
            sp.sprite = normal;
        }
    }

    public void OnPointerExit(PointerEventData eventData) //鼠标离开UI范围调用
    {
        isDown = false;
        isPress = false;
        if (sp)
        {
            sp.sprite = normal;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isPress)
        {
            clickTimes += 1;
        }
        else
        {
            isPress = false;
        }
    }

    void ClickOnce()
    {
        print("OneClick");
    }

    void DoubleClick()
    {
        print("DoubleClick");
    }

    void Press()
    {
        print("Pressed");
    }

    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
