﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        { 
            Debug.Log("Game Over");
            SceneManager.LoadScene(1);
        }
	}
}
