using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TetraminoSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] tetraminos;


    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown("space")) // Key pressed -> https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
        {
            if(GameObject.Find("* Tetramino"))
            {
                Debug.Log("test");
            }
            Instantiate(tetraminos[Random.Range(0, tetraminos.Length)], new Vector3(2 + 0.5f, 2 + 0.5f, 1), Quaternion.identity); // random range between x and y -> https://docs.unity3d.com/ScriptReference/Random.Range.html
            Debug.Log("space key was pressed");
        }
    }

}
