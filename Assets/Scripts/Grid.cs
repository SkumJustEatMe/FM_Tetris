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
        Camera.main.orthographicSize = rows/2;

        Debug.Log("Screen Columms : " + Screen.width);
        Debug.Log("Screen Rows : " + Screen.height);
        myCamera.transform.position = new Vector3(columms/2, rows/2, -10);

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
    }
}
