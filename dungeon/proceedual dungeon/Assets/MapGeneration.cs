using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        GenerateFloor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerateFloor()
    {
        int width = 2;
        int height = 2;
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Instantiate(tile, new Vector3(18 * x, 13 * y), Quaternion.identity, transform);
            }
        }
    }
}
