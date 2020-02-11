using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{

    public GameObject rects;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRenderer2;


    public void Button_Reset()
    {
       
        spriteRenderer.color = new Color(0f, 0f, 0f, 10f);
        spriteRenderer2.color = new Color(0f, 0f, 0f, 10f);
        Debug.Log("Pressed");
    }
}