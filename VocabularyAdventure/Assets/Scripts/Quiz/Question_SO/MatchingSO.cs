using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MatchingSO", menuName = "ScriptableObject/MatchingSO")]

public class MatchingSO : QuestionSO
{

    private void Awake()
    {
        questiontype = QuestionType.matching;
    }
    [SerializeField] int number_questions=3;
    public int Number_questions { get => number_questions; }

    [SerializeField] string[] q1 = new string[3];
    [SerializeField] string[] q2 = new string[3];
    public string[] Q1 { get => q1; }
    public string[] Q2 { get => q2; }
}
