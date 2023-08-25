using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tetramino : MonoBehaviour
{

    void Start()
    {
        this.gameObject.AddComponent<Rigidbody2D>();
        //this.gameObject.AddComponent<BoxCollider2D>();
        foreach (Transform child in this.transform)
        {
            child.AddComponent<BoxCollider2D>();
        }
    }
}