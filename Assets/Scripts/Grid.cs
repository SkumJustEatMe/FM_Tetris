using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Transform myCamera;
    public GameObject myTile;
    private int width = 10;
    private int height = 10;
    private Color color1 = new Color32(245, 245, 245, 245);
    private Color color2 = new Color32(255, 255, 255, 255);

    void Awake()
    {
        Debug.Log("Screen Width : " + Screen.width);
        Debug.Log("Screen Height : " + Screen.height);

        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                GameObject gridTile = Instantiate(myTile, new Vector2(i + 0.5f, j + 0.5f), Quaternion.identity); // Instatiate GameObjects -> https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
                gridTile.name = "Tile " + i + "," + j;
                if (j % 2 == 0 && i % 2 != 0 || i % 2 == 0 && j % 2 != 0)
                {
                    gridTile.GetComponent<Renderer>().material.color = color1;
                }
                else
                {
                    gridTile.GetComponent<Renderer>().material.color = color2;
                }
               
            }
        }

        myCamera.transform.position = new Vector3(width/2, height/2, -10);
        
    }
}
