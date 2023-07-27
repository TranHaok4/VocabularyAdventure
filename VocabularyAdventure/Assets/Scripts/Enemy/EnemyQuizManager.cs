using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class EnemyQuizManager : HaroMonobehavior
{
    [SerializeField] protected QuestionSO question_inEnemy;
    [SerializeField] BoxCollider2D quizBoxcollider;

    private bool hadTriggerPlayer = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            hadTriggerPlayer = true;
            Time.timeScale = 0;
            QuizManager.Instance.Set_quetion(question_inEnemy);
        }
    }

}
