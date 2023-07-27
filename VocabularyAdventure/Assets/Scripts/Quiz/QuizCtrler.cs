using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizCtrler : HaroMonobehavior
{
    protected void HadAnswer()
    {
        Destroy(this.gameObject);
        Time.timeScale = 1;
    }

}
