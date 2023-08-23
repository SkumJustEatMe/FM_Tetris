using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tile_Script : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SprRenderer;

    float tileSize = 1;

    private void Awake()
    {
        transform.localScale = new Vector2(tileSize, tileSize);
    }

}
