using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    //private float gravity = 2f; gravity is already set to 2 thru Unity UI
    private float jumpPower;
    private float speed;

    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        jumpPower = 13f;
        speed = 5f;
}

    // Update is called once per frame
    void Update()
    {
        //setHorizontalMovement();
    }

    private void FixedUpdate()
    {
        setHorizontalMovement();
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Debug.Log("Jump");
            jump();
        }
    }

    private void setHorizontalMovement()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    private void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
    }
}
