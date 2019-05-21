using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocidade;

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position,GetComponentInChildren<Camera>().ScreenToWorldPoint(Input.mousePosition), velocidade * Time.deltaTime);    
    }
}
