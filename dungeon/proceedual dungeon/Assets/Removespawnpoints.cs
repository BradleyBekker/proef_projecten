using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removespawnpoints : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);
        if (collision.CompareTag("spawnpoint") || collision.CompareTag("wall"))
        {
            Destroy(collision.gameObject);
        }
    }
}
