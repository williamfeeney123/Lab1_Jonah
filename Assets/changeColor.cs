using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
   
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRenderer2;
    public int numPointsLeft;
    public int numPointsRight;

    public Text textLeft = null;
  

    void Start()
    {
      
        numPointsLeft = 0;
        numPointsRight = 0;
      
    }

    // Update is called once per frame
    void Update()
    {
        //right
        if (Input.GetKeyDown("space"))
        {
          
            numPointsLeft = numPointsLeft + 1;
            Debug.Log(numPointsLeft);
            spriteRenderer.color = new Color(0f, 2f, 0f, 10f);
           
        }

        //left
        if (Input.GetMouseButtonDown(0))
        {
            numPointsRight = numPointsRight + 1;
            spriteRenderer2.color = new Color(0f, 2f, 0f, 10f);
            Debug.Log(numPointsLeft + " / " + numPointsRight);
        }

    }
   
}
