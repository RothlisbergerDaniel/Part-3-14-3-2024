using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    public static Vector2 gravity = new Vector2(0f, 0f);
    public static GameObject[] boxes = new GameObject[5];

    float horizontal;
    float vertical;
    bool canInput = true;
    Vector2 tempGrav;
    // Start is called before the first frame update
    void Start()
    {
        canInput = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        tempGrav = new Vector2(horizontal, vertical);
        if (tempGrav[0] != 0 && tempGrav[1] != 0)
        {
            tempGrav = new Vector2(tempGrav[0], 0); //make sure gravity only goes one way
        }

        if (canInput && tempGrav != gravity)
        {
            canInput = false;
            StartCoroutine(doGrav());
        }
        
    }

    IEnumerator doGrav()
    {
        gravity = tempGrav;
        yield return new WaitForSeconds(2f);
        canInput = true;
        gravity = Vector2.zero;
    }

    public static void reset()
    {   
        for (int i = 0; i < boxes.Length; i++)
        {
            //run scripts for each object
        }
    }
}
