using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TetraminoSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] tetraminos;
    public GameObject currentTetramino;
    Transform[,] grid = new Transform[10, 20];

    private void Update()
    {
        moveTetramino();
    }

    void spawnTetramno()
    {
        currentTetramino = Instantiate(tetraminos[1], new Vector3(5 + 0.5f, 16 + 0.5f, 1), Quaternion.identity); // random range between x and y -> https://docs.unity3d.com/ScriptReference/Random.Range.html
    }


    void moveTetramino()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) // KeyCodes -> https://docs.unity3d.com/ScriptReference/KeyCode.html And KeyPressed https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
        {
            currentTetramino.transform.position += new Vector3(1, 0);
        //    if (!validMove())
        //    {
        //        currentTetramino.transform.position -= new Vector3(1, 0);
        //        Debug.Log("Out");
        //    }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentTetramino.transform.position += new Vector3(-1, 0);
            //if (!validMove())
            //{
            //    currentTetramino.transform.position -= new Vector3(-1, 0);
            //    Debug.Log("Out");
            //}
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //rotateTetramino();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnTetramno();
        }
    }

    //bool validMove()
    //{
    //    // Code
    //}

    //void rotateTetramino()
    //{
    //    Vector2 v1 = new Vector2(1, 0);
    //    Vector2 v2 = new Vector3(-1, 0);
    //    //this.transform.GetChild(0).position += new Vector3(1, 0);
    //    currentTetramino.transform.GetChild(1).position *= v1;
    //    //this.transform.GetChild(2).position += new Vector3(0, 2);
    //    currentTetramino.transform.GetChild(3).position *= v2;
    //}

}
