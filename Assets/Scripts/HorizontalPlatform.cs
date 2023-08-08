using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlatform : PlatformBase
{
    private float horizontalSpeed = .01f;

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        horizontalSlide();
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
}
