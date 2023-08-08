using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : PlatformBase
{
    private float verticalSpeed = .01f;

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        verticalSlide();
    }

    private void verticalSlide()
    {
        if (currentYPosition >= (initialYPosition + 1))
        {
            rb.velocity = new Vector2(rb.velocity.x, (rb.velocity.y - verticalSpeed));
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, (rb.velocity.y + verticalSpeed));
        }
    }
}
