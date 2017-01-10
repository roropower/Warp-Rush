﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public float health = 10.0f;
    public static float constSpeed = -10.0f;
    public Vector2 speed = new Vector2(0, constSpeed);
    private string collided;

	// Use this for initialization
	void Start () {
        health = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {

        this.gameObject.GetComponent<Rigidbody2D>().velocity = speed;

        if (health <= 0)
        {
            DestroyObject(this.gameObject);
        }
	}

    void OnCollisionEnter2D (Collision2D col)
    {
        collided = col.gameObject.name;

        if (collided == "BorderBottom")
        {
            DestroyObject(this.gameObject);
        }
    }

    IEnumerator RespawnTimer(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }
}
