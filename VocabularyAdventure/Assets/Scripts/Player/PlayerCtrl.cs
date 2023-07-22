using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : HaroMonobehavior
{
    [SerializeField] protected SpriteRenderer model;

    public SpriteRenderer Model { get => model; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpriteRenderer();
    }

    protected void LoadSpriteRenderer()
    {
        if (model != null) return;
        model = this.GetComponentInChildren<SpriteRenderer>();
    }
}
