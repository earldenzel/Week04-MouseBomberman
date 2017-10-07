using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour {

    public GameObject bomb;
    //public Camera mainCamera;
    //private Ray ray;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
            if (!Physics.Raycast(ray))
            {
                Instantiate(bomb, ray.origin, Quaternion.identity);
            }
        }
    }
}
