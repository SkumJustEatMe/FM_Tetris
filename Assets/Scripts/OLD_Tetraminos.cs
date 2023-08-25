using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLD_Tetraminos : MonoBehaviour
{
    public GameObject squareTile;
    //[SerializeField] private SpriteRenderer SprRenderer;
    float tileSize = 0.5f;

    void Start()
    {
        Ltetramino(0, 0);
    }

    void Ltetramino(int x, int y)
    {
        GameObject Ltetramino = new GameObject("L Tetramino");

        transform.localScale = new Vector2(tileSize, tileSize);
        GameObject L1 = Instantiate(squareTile, new Vector2(x + 0.5f, y + 0.5f), Quaternion.identity);
        GameObject L2 = Instantiate(squareTile, new Vector2(x - 1 + 0.5f, y + 0.5f), Quaternion.identity);
        GameObject L3 = Instantiate(squareTile, new Vector2(x - 2 + 0.5f, y + 0.5f), Quaternion.identity);
        GameObject L4 = Instantiate(squareTile, new Vector2(x - 2 + 0.5f, y + 1 + 0.5f), Quaternion.identity);

        L1.GetComponent<Renderer>().material.color = Color.black;
        L2.GetComponent<Renderer>().material.color = Color.black;
        L3.GetComponent<Renderer>().material.color = Color.black;
        L4.GetComponent<Renderer>().material.color = Color.black;

        L1.transform.parent = Ltetramino.transform;
        L2.transform.parent = Ltetramino.transform;
        L3.transform.parent = Ltetramino.transform;
        L4.transform.parent = Ltetramino.transform;
    }
}
