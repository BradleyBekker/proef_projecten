using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UnitDialogue : MonoBehaviour
{
    [SerializeField]
    private string path;
    private string json;
    public List<string> dialogue = new List<string>();

    private void Start()
    {
        
    }
}
