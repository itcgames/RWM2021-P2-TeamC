﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour
{
    // Enemy's rigidbody
    Rigidbody2D rb;

    // Enemy Health
    public float maxHealth = 5.0f;
    // Enemy movement speed
    public float speed = 5.0f;
    // Player GameObject
    public GameObject player;
    // Bomb GameObject
    private GameObject bomb;
    // Current Health
    private float health;

    // Bombing Range
    public float range = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        health = maxHealth;
        // Movement
        rb.velocity = new Vector2(-speed, rb.velocity.y);
        bomb = Instantiate(GameObject.Find("Bomb"), new Vector3(rb.position.x, rb.position.y - 0.5f, 0), Quaternion.identity);
        bomb.transform.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}