using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetraminos : MonoBehaviour
{
    [SerializeField] private GameObject[] tetraminos;


    void Start()
    {
        while (true)
        {
            Instantiate(tetraminos[Random.Range(0, tetraminos.Length)], new Vector3(2 + 0.5f, 2 + 0.5f, 1), Quaternion.identity); // random range between x and y -> https://docs.unity3d.com/ScriptReference/Random.Range.html
        }
    }

}
