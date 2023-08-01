using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIctrl : HaroMonobehavior
{
    [SerializeField] protected  HeartCtrl hearCtrl;
    public HeartCtrl Heart_Ctrl { get => hearCtrl; }

    private static GUIctrl instance;

    public static GUIctrl Instance { get => instance; }

    protected override void Awake()
    {
        base.Awake();
        if (GUIctrl.instance != null) return;
        GUIctrl.instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadHeartCtrl();
    }

    protected void LoadHeartCtrl()
    {
        if (hearCtrl != null) return;
        hearCtrl = GetComponentInChildren<HeartCtrl>();
    }
}
