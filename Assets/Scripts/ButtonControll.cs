using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// jag beklagar att du behöver läsa igenom min kod
public class ButtonControll : MonoBehaviour
{
    [SerializeField] Button thisButton;
    [SerializeField] TMP_Text buttonText;
    [SerializeField] GameObject mainControll;

    [SerializeField] string AnswerTable;
    [SerializeField] string QuestionTable;

    [SerializeField] string[] questions;
    [SerializeField] string[] answers;
    [SerializeField] int[] PatienceEffect;
    [SerializeField] int PatienceLeft;
    int maxPatience;

    [SerializeField] TMP_Text charReply;

    MainDialogueBehavior dialogueBehavior;
    string[] questionTable;
    int dialoguePoint = 0;
    public bool activeoption = true;
    // Start is called before the first frame update
    void Start()
    {
        dialogueBehavior = mainControll.GetComponent<MainDialogueBehavior>();
        PatienceLeft = dialogueBehavior.charPatience;
        maxPatience = PatienceLeft;
        Debug.Log("Started");
        buttonText.text = questions[dialoguePoint]; //questionTable.FirstOrDefault();
    }
    public void Clicked()
    {
        // så den inte errorar å sånt
        if (dialoguePoint + 1 < questions.Length)
        {
            buttonText.text = questions[dialoguePoint + 1];
        }
        else
        {
            buttonText.text = "";
        }

        // gör skit
        if (dialoguePoint < answers.Length)
        {
            charReply.text = answers[dialoguePoint];
        }
        else
        {
            charReply.text = "No more answers.";
        }

        dialogueBehavior.charPatience += PatienceEffect[dialoguePoint];
        if (dialogueBehavior.charPatience > maxPatience)
        {
            dialogueBehavior.charPatience = maxPatience;
        }

        dialoguePoint += 1;

        // stäng av kappnsaken
        if (dialoguePoint >= questions.Length)
        {
            thisButton.interactable = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
