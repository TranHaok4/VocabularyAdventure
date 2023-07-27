using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "TrueFalseSO", menuName = "ScriptableObject/TrueFalseSO")]
public class TrueFalseSO :  QuestionSO
{

    private void Awake()
    {
        questiontype = QuestionType.truefalse;

    }
    [SerializeField] string questionText;
    public string QuestionText { get => questionText; }
    [SerializeField] trueOrfalse correctAnswer;

    public trueOrfalse CorrectAnswer {get=> correctAnswer; }


}

public enum trueOrfalse
{
    True,
    False
}