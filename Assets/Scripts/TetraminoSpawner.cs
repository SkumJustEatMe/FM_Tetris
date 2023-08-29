using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TetraminoSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] tetraminos;
    public GameObject currentTetramino;
    Transform[,] grid = new Transform[10, 20];
    float test = 0f;
    float speed = 0.5f;
    int check = 0;

    private void Update()
    {
        spawnTetramno();
        TetraminoControls();
        //rowFullfilled();

    }

    void spawnTetramno()
    {
        if(currentTetramino == null)
        {
            currentTetramino = Instantiate(tetraminos[Random.Range(0, tetraminos.Length)], new Vector3(5, 16, 1), Quaternion.identity);
        }
        if (!validMove())
        {
            addToGrid();
            currentTetramino = Instantiate(tetraminos[Random.Range(0, tetraminos.Length)], new Vector3(5, 16, 1), Quaternion.identity); // random range between x and y -> https://docs.unity3d.com/ScriptReference/Random.Range.html
        }

        test += Time.deltaTime;

        if (test >= speed && validMove())
        {
            test = 0f;
            currentTetramino.transform.position += new Vector3(0, -1);
        }    
        
    }

    void TetraminoControls()
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
            rotateTetramino();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            while(validMove())
            {
                currentTetramino.transform.position += new Vector3(0, -1);
            }

        }

    }

    void addToGrid()
    {
        foreach (Transform child in currentTetramino.transform)
        {
            float xCord = child.position.x;
            float yCord = child.position.y;

            grid[Mathf.RoundToInt(xCord), Mathf.RoundToInt(yCord)] = child;

        }
    }

    bool validMove()
    {
        foreach (Transform child in currentTetramino.transform)
        {

            float xCord = child.position.x;
            float yCord = child.position.y;

            if (xCord < 0 || xCord > 9 || yCord <= 0)
            {
                return false;
            }
            if (grid[Mathf.RoundToInt(xCord), Mathf.RoundToInt(yCord) - 1])
            {
                return false;
            }

        }
        return true;
    }

    void rotateTetramino()
    {
        currentTetramino.transform.RotateAround(currentTetramino.transform.GetChild(0).position, Vector3.forward, 90);
        if (!validMove())
        {
            currentTetramino.transform.RotateAround(currentTetramino.transform.GetChild(0).position, Vector3.forward, -90);
        }
    }

    void rowFullfilled()
    {
        for(int i = 0; i < 10; i++)
        {
            if (grid[0, i] != null)
            {
                check++;
                Debug.Log(check.ToString());
            }
        }
        if(check == 10)
        {
            clearRow();
            Debug.Log("Clear");
        }
    }

    void clearRow()
    {
        for(int i = 0; i < 10; i++)
        {
            Destroy(grid[0, i].gameObject);
        }
    }

}
