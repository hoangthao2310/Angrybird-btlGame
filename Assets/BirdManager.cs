using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{
    public GameObject[] birdPrefabs;
    private int currentBirdIndex;

    void Start()
    {
        // Set the initial bird type to the first one in the array
        currentBirdIndex = 0;
    }

    public void SelectNextBird()
    {
        // Increment the current bird index
        currentBirdIndex++;

        // If we've gone past the end of the array, wrap back to the beginning
        if (currentBirdIndex >= birdPrefabs.Length)
        {
            currentBirdIndex = 0;
        }

        // Spawn the new bird
        SpawnBird();
    }

    void SpawnBird()
    {
        // Destroy the previous bird
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Instantiate the new bird prefab
        GameObject newBird = Instantiate(birdPrefabs[currentBirdIndex], transform.position, Quaternion.identity);
        newBird.transform.parent = transform;
    }
}
