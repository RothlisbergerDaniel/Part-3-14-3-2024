using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravBox : box
{
    public Vector2 gravDir = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void applyGravity()
    {
        rb.AddForce(new Vector2(controller.gravity[0] * gravityForce * Time.deltaTime, controller.gravity[1] * gravityForce * Time.deltaTime));
        rb.AddForce(new Vector2(gravDir[0] * gravityForce * Time.deltaTime, gravDir[1] * gravityForce * Time.deltaTime));
        if (controller.gravity[0] == 0 && gravDir[0] == 0)
        {
            rb.velocity = new Vector2(0, gravDir[1]);
        }
        if (controller.gravity[1] == 0 && gravDir[1] == 0)
        {
            rb.velocity = new Vector2(gravDir[0], 0);
        }
    }
}
