using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime2 : MonoBehaviour {
    public float lifeTime2 = 0.5f;
    private RaycastHit2D[] hits;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Explode2(lifeTime2));
    }

    IEnumerator Explode2(float lifeTime2)
    {
        yield return new WaitForSeconds(lifeTime2);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
