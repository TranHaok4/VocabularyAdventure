using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartCtrl : HaroMonobehavior
{
    [SerializeField] protected int health = 3;
    [SerializeField] Image[] hearts_image;

    [SerializeField] Sprite fullheart;
    [SerializeField] Sprite emptyheart;

    protected override void Start()
    {
        base.Start();
        foreach(Image image in hearts_image)
        {
            image.sprite = fullheart;
        }
    }

    public void HadIncorrectAnswer()
    {
        health--;
        hearts_image[health].sprite = emptyheart;
    }
}
