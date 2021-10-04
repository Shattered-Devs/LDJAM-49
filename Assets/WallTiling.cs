using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Scrolling))]
public class WallTiling : MonoBehaviour
{

    public bool flipX = false;
    public Sprite[] wallTiles;
    public GameObject WallTilePrefab;

    private const float WALLDISTANCE = 0.4642857f;
    private const float WALLSPACING = 0.0714286f;
    private int[] selectedTiles;
    private GameObject[] tilesOnWall;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Scrolling>().SCROLLED.AddListener(RandomizeTiles);
        selectedTiles = new int[14];
        tilesOnWall = new GameObject[14];
        for (int i = 0; i < 14; i++)
        {
            tilesOnWall[i] = Instantiate(WallTilePrefab, Vector3.zero, Quaternion.identity, transform);
            tilesOnWall[i].transform.localPosition = new Vector3(0, (WALLDISTANCE - (WALLSPACING * i)), 0);
        }
        RandomizeTiles();
        GetComponent<SpriteRenderer>().enabled = false;
    }

    SpriteRenderer tempSR;
    // Update is called once per frame
    public void RandomizeTiles()
    {
        Debug.Log("Randomizing tiles");
        for (int i = 0; i < selectedTiles.Length; i++)
        {
            selectedTiles[i] = Random.Range(0, wallTiles.Length);
            tempSR = tilesOnWall[i].GetComponent<SpriteRenderer>();
            tempSR.sprite = wallTiles[selectedTiles[i]];
            tempSR.flipX = flipX;
        }

    }

}
