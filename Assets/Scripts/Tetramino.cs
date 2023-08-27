using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tetramino : MonoBehaviour
{

    void Start()
    {
        this.gameObject.AddComponent<Rigidbody2D>().gravityScale = 0.5f;
        //this.gameObject.AddComponent<BoxCollider2D>();
        foreach (Transform child in this.transform)
        {
            child.AddComponent<BoxCollider2D>();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) // KeyCodes -> https://docs.unity3d.com/ScriptReference/KeyCode.html
        {
            this.transform.position += new Vector3(1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position -= new Vector3(1, 0);
        }
    }
}