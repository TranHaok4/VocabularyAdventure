using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "MultipleChoiceSO", menuName = "ScriptableObject/MultipleChoiceSO")]
public class MultipleChoiceSO : QuestionSO
{

    private void Awake()
    {
        questiontype = QuestionType.multiplechoice;
    }

    [SerializeField] string questionText;
    public string QuestionText { get => questionText; }

    [SerializeField] string[] answers;
    public string[] Answers { get => answers; }

    [SerializeField] int correctAnswer;
    public int CorrectAnswer { get => correctAnswer; }

}
