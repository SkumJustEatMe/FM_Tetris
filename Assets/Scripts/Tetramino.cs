using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tetramino : MonoBehaviour
{
    //Rigidbody2D rigid;

    void Start()
    {
        this.gameObject.AddComponent<Rigidbody2D>();
        //rigid = this.gameObject.GetComponent<Rigidbody2D>();
    }
}
