using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviors : MonoBehaviour
{
    private float initialPosition;
    private float horizontalSpeed = .01f;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position.x;
        Debug.Log("Initial Platform Position: " + initialPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        horizontalSlide();
    }

    private void horizontalSlide()
    {
        rb.velocity = new Vector2(rb.velocity.x + horizontalSpeed, rb.velocity.y);
    }
}
