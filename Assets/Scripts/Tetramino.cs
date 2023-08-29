using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tetramino : MonoBehaviour
{

    void Start()
    {
        this.gameObject.AddComponent<Rigidbody2D>().gravityScale = 0f;
        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        foreach (Transform child in this.transform)
        {
            child.AddComponent<BoxCollider2D>();
        }
    }
}