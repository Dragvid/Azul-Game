using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPieces : MonoBehaviour
{
    public GameObject[] spawnOrigin;
    public GameObject[] pieces;
    public bool turnStart;
    private int colorRandom;
    private int pieceCount;
    void Start()
    {
        
    }

    void Update()
    {
        if (turnStart)
        {
            spawnPieces();
        }
    }
    public void spawnPieces()
    {
        pieceCount = Random.Range(1, 5);
        Debug.Log("piece count: " + pieceCount);
        for (int i = 0; i < pieceCount; i++)
        {
            colorRandom = Random.Range(0, 5);
            Debug.Log("color random: " + colorRandom);
            var piece = Instantiate(pieces[colorRandom], spawnOrigin[i].transform.position, Quaternion.identity);
            piece.transform.parent = gameObject.transform;
        }
        turnStart = false;
    }
}
