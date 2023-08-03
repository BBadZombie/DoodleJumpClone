using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviors : MonoBehaviour
{
    /**
     * The difference between initial and current position is that initial is taken once
     * at the start of the game and current is tracked throughout 
     */
    private float initialPosition;
    private float currentPosition;
    private float horizontalSpeed = .01f;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //currentPosition = transform.position.x;
    }

    private void FixedUpdate()
    {
        currentPosition = transform.position.x;
        horizontalSlide();
    }

    private void horizontalSlide()
    {
        if (transform.position.x >= (initialPosition + 1)) 
        {
            rb.velocity = new Vector2((rb.velocity.x - horizontalSpeed), rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2((rb.velocity.x + horizontalSpeed), rb.velocity.y);
        }
    }
}
