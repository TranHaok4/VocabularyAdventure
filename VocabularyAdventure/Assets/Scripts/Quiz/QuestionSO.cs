using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSO : ScriptableObject
{
    
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
