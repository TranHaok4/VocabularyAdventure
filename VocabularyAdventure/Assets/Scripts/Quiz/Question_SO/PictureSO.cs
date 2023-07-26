using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "PictureSO", menuName = "ScriptableObject/PictureSO")]

public class PictureSO : QuestionSO
{

    private void Awake()
    {
        questiontype = QuestionType.picture;
    }

    [SerializeField] Sprite picture;

    [SerializeField] string questionText;

    [SerializeField] string[] answers;

    [SerializeField] int correctAnswer;

}
