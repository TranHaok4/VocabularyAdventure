using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "MatchingSO", menuName = "ScriptableObject/MatchingSO")]

public class MatchingSO : QuestionSO
{

    private void Awake()
    {
        questiontype = QuestionType.matching;
    }
    [SerializeField] int number_questions;

    [SerializeField] string[] Q1;
    [SerializeField] string[] Q2;
}