using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : HaroMonobehavior
{
    [SerializeField] protected Transform target;
    [SerializeField] protected float speed = 1f;

    protected virtual void FixedUpdate()
    {
        this.Following();
    }

    private void Following()
    {
        if (this.target == null) return;
        transform.position =
            Vector3.Lerp(transform.position, this.target.position, speed * Time.fixedDeltaTime);
    }
}
