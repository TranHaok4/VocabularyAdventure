using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class EnemyQuizManager : HaroMonobehavior
{
    [SerializeField] protected QuestionSO question_inEnemy;
    [SerializeField] BoxCollider2D quizBoxcollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            QuizManager.Instance.Set_quetion(question_inEnemy);
        }
    }

}
