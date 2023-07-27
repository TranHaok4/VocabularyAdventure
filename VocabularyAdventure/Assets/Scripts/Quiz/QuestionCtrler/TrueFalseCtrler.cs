using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TrueFalseCtrler : QuizCtrler
{
    [SerializeField] GameObject questionPanel;
    [SerializeField] GameObject trueButton;
    [SerializeField] GameObject falseButton;

    protected string correct_Answer;

    public void Set_Question(TrueFalseSO truefalse_SO)
    {
        questionPanel.GetComponentInChildren<Text>().text = truefalse_SO.QuestionText;
        correct_Answer = truefalse_SO.CorrectAnswer.ToString();
    }
    public void OnButtonClicked()
    {
        GameObject selectedObject = EventSystem.current.currentSelectedGameObject;
        string selectedAnswer = selectedObject.GetComponentInChildren<Text>().text;
        CheckAnswer(selectedAnswer);

    }
    private void CheckAnswer(string userAnswer)
    {
        if (userAnswer == correct_Answer)
        {
            Debug.Log("Ok chuan");
        }
        else
        {
            Debug.Log("chua chuan");
        }
        HadAnswer();
    }
}
