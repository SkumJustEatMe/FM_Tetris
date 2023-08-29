using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour
{
    [SerializeField] private Transform myCamera;
    public GameObject squareTile;
    private int columms = 10;
    private int rows = 20;

    public GameObject[,] grid;

    private Color color1 = new Color32(245, 245, 245, 245);
    private Color color2 = new Color32(255, 255, 255, 255);


    void Awake()
    {
        myCamera.transform.position = new Vector3(columms/2 - 0.5f, rows/2 - 0.5f, -10);
        Camera.main.orthographicSize = rows / 2;

        initGrid();
        
    }

    private void initGrid()
    {
        //grid = new GameObject[columms, rows];
        //Vector2[] points = { new Vector2(10f, 0f), new Vector2(0f, 0f) }; // new Vector2(10f, 20f), new Vector2(0f, 20f)
        //this.gameObject.AddComponent<EdgeCollider2D>().points = points;


        for (int i = 0; i < columms; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                GameObject gridTile = Instantiate(squareTile, new Vector2(i, j), Quaternion.identity); // Instatiate GameObjects -> https://docs.unity3d.com/Manual/InstantiatingPrefabs.html

                gridTile.name = "Tile " + i + "," + j;
                if (j % 2 == 0 && i % 2 != 0 || i % 2 == 0 && j % 2 != 0)
                {
                    gridTile.GetComponent<Renderer>().material.color = color1;
                }
                else
                {
                    gridTile.GetComponent<Renderer>().material.color = color2;
                }

                gridTile.transform.parent = this.transform;
                  
            }
        }

    }
}
