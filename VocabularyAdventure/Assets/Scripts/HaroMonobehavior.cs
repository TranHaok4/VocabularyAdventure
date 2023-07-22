using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HaroMonobehavior : MonoBehaviour
{
    protected virtual void OnEnable()
    {
        this.LoadComponents();
        this.ResetValue();
    }

    protected virtual void Start()
    {
        this.LoadComponents();
    }
    protected virtual void Reset()
    {
        this.LoadComponents();
        this.ResetValue();
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
        this.ResetValue();
    }
    protected virtual void ResetValue()
    {
        //todo
    }

    protected virtual void LoadComponents()
    {
        //todo
    }
}
