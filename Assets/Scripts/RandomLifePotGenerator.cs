using System;
using System.Collections.Generic;
using UnityEngine;

public class RandomLifePotGenerator : MonoBehaviour
{
    public List<Transform> positions;
    public GameObject dropedItemPrefab;
    private float deltaTime;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        deltaTime += Time.deltaTime;
        if(deltaTime>60)
        {
            PlantRandomLifePot();
            deltaTime = 0;
        }
    }

    private void PlantRandomLifePot()
    {
        int length = positions.Count;
        System.Random rnd = new System.Random();
        int randomNr = rnd.Next(0, length - 1);
        Transform trans = positions[randomNr];
        GameObject droppedItem;
        droppedItem = Instantiate(dropedItemPrefab, trans.position, trans.rotation);
        droppedItem.SetActive(true);
    }
}
