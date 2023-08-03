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

    [SerializeField] bool AnswerSucces = true;

    protected override void Start()
    {
        base.Start();
    }
    private IEnumerator ProcessQuestions(QuestionSO[] type_ofquestion, int numberofquestion)
    {
        int indexQuestion = 0;

        while (indexQuestion < numberofquestion)
        {
            Debug.Log(AnswerSucces);

            if (AnswerSucces)
            {
                AnswerSucces = false;
                countdown_timer.SetActive(true);

                Debug.Log(type_ofquestion[indexQuestion].Question_Type);

                if (type_ofquestion[indexQuestion].Question_Type == QuestionType.multiplechoice)
                {
                    questionObject = Instantiate(multipleChoice_prefabs, transform);
                    questionObject.GetComponent<MultipleChoiceCtrler>().Set_Question((MultipleChoiceSO)type_ofquestion[indexQuestion]);
                }
                else if (type_ofquestion[indexQuestion].Question_Type == QuestionType.matching)
                {
                    questionObject = Instantiate(matching_prefabs, transform);
                    questionObject.GetComponent<MatchingCtrler>().Set_Question((MatchingSO)type_ofquestion[indexQuestion]);
                }
                else if (type_ofquestion[indexQuestion].Question_Type == QuestionType.truefalse)
                {
                    questionObject = Instantiate(truefalse_prefabs, transform);
                    questionObject.GetComponent<TrueFalseCtrler>().Set_Question((TrueFalseSO)type_ofquestion[indexQuestion]);
                }
                else if (type_ofquestion[indexQuestion].Question_Type == QuestionType.picture)
                {
                    questionObject = Instantiate(picture_prefabs, transform);
                    questionObject.GetComponent<PictureCtrler>().Set_Question((PictureSO)type_ofquestion[indexQuestion]);
                }
                indexQuestion++;
            }

            yield return new WaitUntil(() => AnswerSucces);
        }
    }

    public void Set_quetion(QuestionSO[] type_ofquestion, int numberofquestion)
    {
        AnswerSucces = true;
        StartCoroutine(ProcessQuestions(type_ofquestion, numberofquestion));
    }

    public void TimeOut_orHadAnswer()
    {
        countdown_timer.SetActive(false);
        AnswerSucces = true;
    }
}
