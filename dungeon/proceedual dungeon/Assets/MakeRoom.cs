
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRoom : MonoBehaviour
{
    [SerializeField] bool spawned = false;
    public int OpenDirection;
    /// <summary>
    /// 1 = top
    /// 2 = bottom
    /// 3 = left
    /// 4 = right
    /// </summary>
    
   private bool available = true;
    Maps Maps;
    
    // Start is called before the first frame update
    void Start()
    {
      Maps = GameObject.Find("maps").GetComponent<Maps>();
        Invoke("spawn",0.1f);

        Destroy(gameObject, 5);
   }
    void spawn()
    {

        int val;
        if (!spawned)
        {

            switch (OpenDirection)
            {
                case 1:
                    val = Random.Range(0, Maps.Brooms.Length);
                    //make bot room
                    if (available)
                    {
                        Instantiate(Maps.Brooms[val], transform.position, Quaternion.identity);
                    }
                    break;
                case 2:
                    val = Random.Range(0, Maps.Trooms.Length);
                    if (available)
                    {
                        Instantiate(Maps.Trooms[val], transform.position, Quaternion.identity);
                    }
                    break;
                case 3:
                    val = Random.Range(0, Maps.Rrooms.Length);
                    //make right room
                    if (available)
                    {
                        Instantiate(Maps.Rrooms[val], transform.position, Quaternion.identity);
                    }

                    break;
                case 4:
                    val = Random.Range(0, Maps.Lrooms.Length);
                    if (available)
                    {
                        Instantiate(Maps.Lrooms[val], transform.position, Quaternion.identity);
                    }
                    //make left room
                    break;

                default:
                    break;
            }
            spawned = true;

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("spawnpoint"))
        {
            if (!collision.gameObject.GetComponent<MakeRoom>().spawned && !spawned && collision.name != "CENTER OF DOOM")
            {
                Instantiate(Maps.wall,transform.position,Quaternion.identity);
                Destroy(gameObject);
            }

            spawned = true;
        }

    }
    
}
