using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MultipleChoiceCtrler : QuizCtrler
{
    [SerializeField] GameObject questionPanel;
    [SerializeField] GameObject answer1;
    [SerializeField] GameObject answer2;
    [SerializeField] GameObject answer3;
    [SerializeField] GameObject answer4;

    protected string correct_Answer;

    //protected string user_Answer;
    public void Set_Question(MultipleChoiceSO multiplechoice_SO)
    {
        questionPanel.GetComponentInChildren<Text>().text = multiplechoice_SO.QuestionText;
        answer1.GetComponentInChildren<Text>().text = multiplechoice_SO.Answers[0];
        answer2.GetComponentInChildren<Text>().text = multiplechoice_SO.Answers[1];
        answer3.GetComponentInChildren<Text>().text = multiplechoice_SO.Answers[2];
        answer4.GetComponentInChildren<Text>().text = multiplechoice_SO.Answers[3];
        correct_Answer = multiplechoice_SO.Answers[multiplechoice_SO.CorrectAnswer];
    }

    public void OnButtonClicked()
    {
        GameObject selectedObject= EventSystem.current.currentSelectedGameObject;
        string selectedAnswer = selectedObject.GetComponentInChildren<Text>().text;
        CheckAnswer(selectedAnswer);
    }
    private void CheckAnswer(string userAnswer)
    {
        if(userAnswer==correct_Answer)
        {
            Debug.Log("Ok chuan");
        }
        else
        {
            Debug.Log("chua chuan");
            IncorrecctAnswer();
        }
        HadAnswer();
    }


}
