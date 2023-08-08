using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBase : MonoBehaviour
{
    /**
     * The difference between initial and current position is that initial is taken once
     * at the start of the game and current is tracked throughout 
     */
    protected float initialXPosition;
    protected float initialYPosition;
    protected float currentXPosition;
    protected float currentYPosition;

    protected Rigidbody2D rb;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        initialXPosition = transform.position.x;
        initialYPosition = transform.position.y;
        rb = GetComponent<Rigidbody2D>();
}

    protected virtual void FixedUpdate()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
    }
}
