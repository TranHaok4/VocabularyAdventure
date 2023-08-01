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

    [SerializeField] GameObject countdown_timer;

    protected GameObject questionObject;

    protected override void Start()
    {
        base.Start();
    }
    public void Set_quetion(QuestionSO type_ofquestion)
    {
        Debug.Log(type_ofquestion.Question_Type);
        countdown_timer.SetActive(true);
        if(type_ofquestion.Question_Type==QuestionType.multiplechoice)
        {
            questionObject = Instantiate(multipleChoice_prefabs, this.transform);
            questionObject.GetComponent<MultipleChoiceCtrler>().Set_Question((MultipleChoiceSO)type_ofquestion);
        }
        else if(type_ofquestion.Question_Type == QuestionType.matching)
        {
            questionObject = Instantiate(matching_prefabs, this.transform);
            questionObject.GetComponent<MatchingCtrler>().Set_Question((MatchingSO)type_ofquestion);

        }
        else if (type_ofquestion.Question_Type == QuestionType.truefalse)
        {
            questionObject = Instantiate(truefalse_prefabs, this.transform);
            questionObject.GetComponent<TrueFalseCtrler>().Set_Question((TrueFalseSO)type_ofquestion);

        }
        else if(type_ofquestion.Question_Type == QuestionType.picture)
        {
            questionObject = Instantiate(picture_prefabs, this.transform);
            questionObject.GetComponent<PictureCtrler>().Set_Question((PictureSO)type_ofquestion);
        }
    }

    public void TimeOut()
    {
        countdown_timer.SetActive(false);
    }
}
