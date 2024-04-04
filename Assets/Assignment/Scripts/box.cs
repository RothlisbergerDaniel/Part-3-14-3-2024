using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{

    Rigidbody2D rb;
    public float gravityForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
        rb.AddForce(new Vector2(controller.gravity[0] * gravityForce * Time.deltaTime, controller.gravity[1] * gravityForce * Time.deltaTime));
        if(controller.gravity == Vector2.zero)
        {
            rb.velocity = Vector2.zero;
        }
    }

    protected void applyGravity()
    {
        
    }
}
