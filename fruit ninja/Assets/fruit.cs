using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour { 
    public GameObject fruitSlicedPrefab;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "blade")
        {
            
        Instantiate(fruitSlicedPrefab);
            Destroy(gameObject);
        }
    }
}
