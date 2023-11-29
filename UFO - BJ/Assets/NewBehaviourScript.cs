using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D ufo;
    float horizontal;
    float vertical;
        // Start is called before the first frame update
    void Start()
    {
        ufo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {
        ufo.velocity = new Vector2 (horizontal * speed, vertical * speed);
    }




}




