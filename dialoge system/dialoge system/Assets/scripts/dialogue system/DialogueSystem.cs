using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private Text _textbox;
    private UnitDialogue UD;
    private int _index = 0;
    bool isDialogueRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        UD = GetComponent<UnitDialogue>();
       _textbox  = GameObject.Find("DialogueBox").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isDialogueRunning && Input.anyKeyDown)
        {
            ProceedDialogue();
        }
    }

    public void StartDialogue()
    {
        isDialogueRunning = true;
        _index = 0;
       

        _textbox.text = UD.dialogue[_index];
    }
    public void ProceedDialogue()
    {
        _index++;

        if (UD.dialogue.Length -1 < _index)
        {
            print("stopped");
            StopDialogue();
            return;
        }
       
        _textbox.text = UD.dialogue[_index];

    }

    public void StopDialogue()
    {
        _textbox.text = "";
        isDialogueRunning = false;
    }
    private void OnMouseDown()
    {
        if (!isDialogueRunning && Input.anyKeyDown)
        {
            StartDialogue();
        }
    }
}
