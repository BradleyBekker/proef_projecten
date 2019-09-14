using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonTest : MonoBehaviour
{
    Document doc = new Document();

    [SerializeField]
    private string path;
    // private string json;
    public List<string> dialogue;

    private void Start()
    {
        TextAsset json = Resources.Load("Json files/document") as TextAsset;
        print(json.text);

        doc = JsonUtility.FromJson<Document>(json.text);
        print(doc.Dialogue);




        foreach (line item in doc.Dialogue)
        {
            print(item);
        }


        //doc.Dialogue;
    }
}
