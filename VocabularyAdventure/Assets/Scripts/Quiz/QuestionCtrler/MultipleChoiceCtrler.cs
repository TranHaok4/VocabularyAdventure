using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleChoiceCtrler : QuizCtrler
{
    [SerializeField] GameObject questionPanel;
    [SerializeField] GameObject answer1;
    [SerializeField] GameObject answer2;
    [SerializeField] GameObject answer3;
    [SerializeField] GameObject answer4;

    protected string correct_Answer;

    public void Set_Question(MultipleChoiceSO multiplechoice_SO)
    {
        questionPanel.GetComponentInChildren<Text>().text = multiplechoice_SO.QuestionText;
        answer1.GetComponentInChildren<Text>().text = multiplechoice_SO.Answers[0];
        answer2.GetComponentInChildren<Text>().text = multiplechoice_SO.Answers[1];
        answer3.GetComponentInChildren<Text>().text = multiplechoice_SO.Answers[2];
        answer4.GetComponentInChildren<Text>().text = multiplechoice_SO.Answers[3];
        correct_Answer = multiplechoice_SO.Answers[multiplechoice_SO.CorrectAnswer];
    }
}
