using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject enemyprefab;
    public float spawnrate = 2.1f;
    public float lastspawn;
    public GameObject position;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Setspawn();

    }
    void Setspawn()
    {
        
        lastspawn += Time.deltaTime;
        if (lastspawn >= spawnrate)
        {
            Instantiate(enemyprefab, position.transform.position, Quaternion.identity);
            lastspawn = 0f;
        }
    }
}
