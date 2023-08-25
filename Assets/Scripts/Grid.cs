using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Transform myCamera;
    public GameObject squareTile;
    private int columms = 10; // You could also use Screen.width.
    private int rows = 20; // You could also use Screen.height.

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
     
        GameObject grid = new GameObject("GridParent");

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

                gridTile.transform.parent = grid.transform;

            }
        }

        initEdges(grid);

        // Tryed with the EdgeCollider instead of box, i might move back and thats why im saving it. Just coudnt figurer out how to set the points right
        //grid.AddComponent<EdgeCollider2D>();
        //grid.GetComponent<EdgeCollider2D>().adjacentStartPoint = new Vector2(10, 20);
        //grid.GetComponent<EdgeCollider2D>().offset = new Vector2(columms/2, -2);
        //grid.GetComponent<EdgeCollider2D>().adjacentEndPoint = new Vector2(0, 20);
    }


    private void initEdges(GameObject grid)
    {
        //Buttom part of the collider
        BoxCollider2D buttom = grid.AddComponent<BoxCollider2D>();
        buttom.GetComponent<BoxCollider2D>().size = new Vector2(columms, 0.1f);
        buttom.GetComponent<BoxCollider2D>().offset = new Vector2(columms / 2, -0.1f);

        //Left side of the collider
        //BoxCollider2D left = grid.AddComponent<BoxCollider2D>();
        //left.GetComponent<BoxCollider2D>().size = new Vector2(0.1f, rows);
        //left.GetComponent<BoxCollider2D>().offset = new Vector2(-0.1f, columms / 2);

    }
}
