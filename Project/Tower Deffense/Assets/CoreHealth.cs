using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreHealth : MonoBehaviour {
    public static int health;
    public GameObject tujuansas;
	// Use this for initialization
	void Start () {
        health = 5;
	}

    // Update is called once per frame
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(tujuansas);
        }
    }
}
