using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Transform myCamera;
    public GameObject myTile;
    private int width = 10;
    private int height = 10;

    void Awake()
    {
        Debug.Log("Screen Width : " + Screen.width);
        Debug.Log("Screen Height : " + Screen.height);

        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                Instantiate(myTile, new Vector2(i + 0.5f, j + 0.5f), Quaternion.identity); // Instatiate GameObjects -> https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
                myTile.name = "Tile " + i + "," + j;
                if (j % 2 == 0)
                {
                    myTile.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                    Debug.Log("black");
                }
                else
                {
                    myTile.GetComponent<Renderer>().sharedMaterial.color = Color.gray;
                    Debug.Log("grey");
                }
               
            }
        }

        myCamera.transform.position = new Vector3(width/2, height/2, -10);
        
    }
}
