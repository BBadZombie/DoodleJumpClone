using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float jumpPower = 13f;
    public float speed = 5f;

    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetHorizontalMovement();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Debug.Log("Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }

    private void SetHorizontalMovement()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }
}
