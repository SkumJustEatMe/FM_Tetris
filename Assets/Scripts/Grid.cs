using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Transform myCamera;
    public GameObject squareTile;
    private int columms = 10; // You could also use Screen.width.
    private int rows = 20; // You could also use Screen.height.

    private GameObject[,] grid;

    private Color color1 = new Color32(245, 245, 245, 245);
    private Color color2 = new Color32(255, 255, 255, 255);


    void Awake()
    {
        Debug.Log("Screen Columms : " + Screen.width);
        Debug.Log("Screen Rows : " + Screen.height);
        myCamera.transform.position = new Vector3(columms/2, rows/2, -10);
        Camera.main.orthographicSize = rows / 2;

        initGrid();
        
    }

    private void initGrid()
    {
        grid = new GameObject[columms, rows];

        for (int i = 0; i < columms; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                GameObject gridTile = Instantiate(squareTile, new Vector2(i + 0.5f, j + 0.5f), Quaternion.identity); // Instatiate GameObjects -> https://docs.unity3d.com/Manual/InstantiatingPrefabs.html

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
                grid[i, j] = gridTile;

                // For now we will add the colliders like this. But we will probably refactor this. Its bad code :)
                if (j == 0 || i == 9)
                {
                    gridTile.AddComponent<BoxCollider2D>().offset = new Vector2(0, -1);
                }
                else if(i == 9)
                {
                    gridTile.AddComponent<BoxCollider2D>().offset = new Vector2(1, 0);
                }
                else if(i == 0)
                {
                    gridTile.AddComponent<BoxCollider2D>().offset = new Vector2(-1, 0);
                }

            }
        }

    }


    private void addCollider()
    {

    }
}
