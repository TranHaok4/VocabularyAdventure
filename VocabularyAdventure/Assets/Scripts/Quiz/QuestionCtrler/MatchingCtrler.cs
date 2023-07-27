using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MatchingCtrler : QuizCtrler
{
    [SerializeField] GameObject[] q1 = new GameObject[4];
    [SerializeField] GameObject[] q2 = new GameObject[4];

    int[] arraysuffle = { 0, 1, 2, 3 };
    GameObject selectedObject1, selectedObject2;
    [SerializeField] string[] correct_Answer1 = new string[4];
    [SerializeField] string[] correct_Answer2 = new string[4];

    public void Set_Question(MatchingSO matching_SO)
    {
        suffleArray();
        for(int i=0;i<=3;i++)
        {
            q1[i].GetComponentInChildren<Text>().text = matching_SO.Q1[i];
            q2[i].GetComponentInChildren<Text>().text = matching_SO.Q2[arraysuffle[i]];
        }
        for(int i=0;i<=3;i++)
        {
            string a = matching_SO.Q1[i];
            string b = matching_SO.Q2[i];
            correct_Answer1[i] = a;
            correct_Answer2[i] = b;
            
        }
    }

    protected void suffleArray()
    {
        for(int i=0;i<=3;i++)
        {
            arraysuffle[i] = i;
        }
        for (int i = 0; i <=3; i++)
        {
            int randomIndex = Random.Range(i, 3);
            int temp = arraysuffle[i];
            arraysuffle[i] = arraysuffle[randomIndex];
            arraysuffle[randomIndex] = temp;
        }  
    }
    public void OnButtonClicked()
    {
        if(selectedObject1==null)
        {
            Debug.Log("lan 1");
            selectedObject1= EventSystem.current.currentSelectedGameObject;
        }
        else
        {
            selectedObject2= EventSystem.current.currentSelectedGameObject;
            CheckAnswer(selectedObject1.GetComponentInChildren<Text>().text, selectedObject2.GetComponentInChildren<Text>().text);
        }
    }
    private void CheckAnswer(string userAnswer1,string userAnswer2)
    {
        bool is_correct = false;
        for(int i=0;i<=3;i++)
        {
            if(correct_Answer1[i]==userAnswer1 && correct_Answer2[i]==userAnswer2)
            {
                is_correct = true;
                break;
            }
        }
        if (is_correct)
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
