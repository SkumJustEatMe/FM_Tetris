using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class TetraminoSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] tetraminos;
    public GameObject currentTetramino;
    bool[,] grid = new bool[10, 20];

    private void Update()
    {
        moveTetramino();
    }

    void spawnTetramno()
    {
        currentTetramino = Instantiate(tetraminos[1], new Vector3(5, 16, 1), Quaternion.identity); // random range between x and y -> https://docs.unity3d.com/ScriptReference/Random.Range.html
    }


    void moveTetramino()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow)) // KeyCodes -> https://docs.unity3d.com/ScriptReference/KeyCode.html And KeyPressed https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
        {
            currentTetramino.transform.position += new Vector3(1, 0);
            if (!validMove())
            {
                currentTetramino.transform.position -= new Vector3(1, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentTetramino.transform.position += new Vector3(-1, 0);
            if (!validMove())
            {
                currentTetramino.transform.position -= new Vector3(-1, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //rotateTetramino();
            downTetramino();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnTetramno();
        }

    }

    void downTetramino()
    {
        currentTetramino.transform.position += new Vector3(0, -1);
        if (!validMove())
        {
            currentTetramino.transform.position -= new Vector3(0, -1);
        }
    }

    bool validMove()
    {
        foreach (Transform child in currentTetramino.transform)
        {

            float xCord = child.position.x;
            float yCord = child.position.y;

            if (xCord < 0 || xCord > 9 || yCord < 0)
            {
                return false;
            }

        }
        return true;
    }

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
