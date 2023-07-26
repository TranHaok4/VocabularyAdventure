using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//[CreateAssetMenu(fileName = "TrueFalseSO", menuName = "ScriptableObject/TrueFalseSO")]
public class TrueFalseSO :  QuestionSO
{

    private void Awake()
    {
        questiontype = QuestionType.truefalse;

    }
    [SerializeField] string questionText;
    [SerializeField] trueOrfalse correctAnswer;


}

public enum trueOrfalse
{
    True,
    False
}