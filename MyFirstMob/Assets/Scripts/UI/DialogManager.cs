using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogText;
    public Button continueButton;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog(Dialogue dialog)
    {
        Debug.Log("start dialogue");
        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextsentence();
    }
    public void DisplayNextsentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        if (sentences.Count == 1)
        {
            continueButton.interactable = false;
        }

        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
    }


    void EndDialog()
    {
        Debug.Log("end conversation");
    }
}
