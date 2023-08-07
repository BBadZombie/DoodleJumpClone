using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviors : MonoBehaviour
{
    /**
     * The difference between initial and current position is that initial is taken once
     * at the start of the game and current is tracked throughout 
     */
    private float initialXPosition;
    private float initialYPosition;
    private float currentXPosition;
    private float currentYPosition;
    private float horizontalSpeed = .01f;
    private float verticalSpeed = .01f;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        initialXPosition = transform.position.x;
        initialYPosition = transform.position.y;
}

    // Update is called once per frame
    void Update()
    {
        //currentPosition = transform.position.x;
    }

    private void FixedUpdate()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
        //horizontalSlide();
        verticalSlide();
    }

    private void horizontalSlide()
    {
        if (currentXPosition >= (initialXPosition + 1)) 
        {
            rb.velocity = new Vector2((rb.velocity.x - horizontalSpeed), rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2((rb.velocity.x + horizontalSpeed), rb.velocity.y);
        }
    }

    private void verticalSlide()
    {
        if(currentYPosition >= (initialYPosition + 1))
        {
            rb.velocity = new Vector2(rb.velocity.x, (rb.velocity.y - verticalSpeed));
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, (rb.velocity.y + verticalSpeed));
        }
    }
}
