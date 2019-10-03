using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 4;
    private void FixedUpdate()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime );
    }
}
