using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PictureSO", menuName = "ScriptableObject/PictureSO")]

public class PictureSO : QuestionSO
{

    private void Awake()
    {    
        Reset();
    }
    private void Reset()
    {
        questiontype = QuestionType.picture;
    }

    [SerializeField] Sprite picture;

    public Sprite Picture { get => picture; }

    [SerializeField] string[] answers=new string[4];
    public string[] Answers { get => answers; }

    [SerializeField] int correctAnswer;
    public int CorrectAnswer { get => correctAnswer; }

}
