using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSO : ScriptableObject
{
    [SerializeField] protected QuestionType questiontype;

    public QuestionType Question_Type { get => questiontype; }


    [SerializeField] protected float question_time;
    [SerializeField] protected int question_score;

}
public enum QuestionType
{
    multiplechoice,
    picture,
    truefalse,
    matching,
}
