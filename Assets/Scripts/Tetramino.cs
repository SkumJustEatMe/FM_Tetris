using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tetramino : MonoBehaviour
{

    void Start()
    {
        this.gameObject.AddComponent<Rigidbody2D>();
    }
}
