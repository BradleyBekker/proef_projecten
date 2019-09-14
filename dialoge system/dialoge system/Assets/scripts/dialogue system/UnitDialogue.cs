using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UnitDialogue : MonoBehaviour
{
    public string[] dialogue;
    [SerializeField] private string file; 
    TextAsset doc;

    private void Start()
    {
        doc = Resources.Load("text files/"  + file) as TextAsset;
        dialogue = doc.text.Split("\n"[0]);
    }
}
