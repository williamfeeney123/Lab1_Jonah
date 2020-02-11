using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
   
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRenderer2;
   

    public Text textLeft = null;
  

    void Start()
    {
      
     
      
    }

    // Update is called once per frame
    void Update()
    {
        //right
        if (Input.GetKeyDown("space"))
        {


            Score.score2 += 1;
            spriteRenderer.color = new Color(0f, 2f, 0f, 10f);
           
        }

        //left
        if (Input.GetKeyDown("up"))
        {
            Score.score += 1;
            spriteRenderer2.color = new Color(0f, 2f, 0f, 10f);
          
        }
        
    }
   
}
