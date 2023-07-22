using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "MultipleChoiceSO", menuName = "ScriptableObject/MultipleChoiceSO")]
public class MultipleChoiceSO : QuestionSO
{
    [SerializeField] QuestionType questiontype;

    private void Awake()
    {
        questiontype = QuestionType.multiplechoice;
    }

    [SerializeField] string questionText;

    [SerializeField] string[] answers;

    [SerializeField] int correctAnswer;

}
