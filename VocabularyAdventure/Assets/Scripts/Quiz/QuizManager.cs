using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : HaroMonobehavior
{
    private static QuizManager instance;
    public static QuizManager Instance { get => instance; }

    protected override void Awake()
    {
        base.Awake();
        if (QuizManager.instance != null) return;
        QuizManager.instance = this;
    }

    [SerializeField] GameObject multipleChoice_prefabs;
    [SerializeField] GameObject matching_prefabs;
    [SerializeField] GameObject picture_prefabs;
    [SerializeField] GameObject truefalse_prefabs;



    protected GameObject questionObject;

    protected override void Start()
    {
        base.Start();
    }
    public void Set_quetion(QuestionSO type_ofquestion)
    {
        if(type_ofquestion.Question_Type==QuestionType.multiplechoice)
        {
            questionObject = Instantiate(multipleChoice_prefabs, this.transform);
            questionObject.GetComponent<MultipleChoiceCtrler>().Set_Question((MultipleChoiceSO)type_ofquestion);
        }
        else if(type_ofquestion.Question_Type == QuestionType.matching)
        {
            questionObject = Instantiate(matching_prefabs, this.transform);
        }
        else if (type_ofquestion.Question_Type == QuestionType.truefalse)
        {
            questionObject = Instantiate(truefalse_prefabs, this.transform);
        }
        else if(type_ofquestion.Question_Type == QuestionType.picture)
        {
            questionObject = Instantiate(picture_prefabs, this.transform);
        }
       
    }


}
