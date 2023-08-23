using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetraminos : MonoBehaviour
{
    public GameObject squareTile;

    void Start()
    {
        Ltetramino();
    }

    void Ltetramino()
    {
        GameObject L1 = Instantiate(squareTile, new Vector2(-1 + 0.5f, 0 + 0.5f), Quaternion.identity);
        //L1.transform.position = new Vector3(1 + 0.5f, -1 + 0.5f, -2);
        L1.GetComponent<Renderer>().material.color = Color.black;
        L1.name = "L Tile";
        //GameObject L1 = Instantiate(SquareTile, new Vector2(1, 1), Quaternion.identity);
        //GameObject L2 = Instantiate(SquareTile, new Vector2(2, 1), Quaternion.identity);
        //GameObject L3 = Instantiate(SquareTile, new Vector2(3, 1), Quaternion.identity);
        //GameObject L4 = Instantiate(SquareTile, new Vector2(1, 2), Quaternion.identity);
    }
}
