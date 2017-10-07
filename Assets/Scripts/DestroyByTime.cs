using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {
    public float lifeTime = 3f;
    public float explosionRadius = 1.0f;
    public float explosionForce = 5.0f;
    public GameObject explosion;
    private RaycastHit2D[] hits;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Explode(lifeTime));
    }

    IEnumerator Explode(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(this.gameObject);
        Instantiate(explosion, transform.position, Quaternion.identity);
        hits = Physics2D.CircleCastAll(this.transform.position, explosionRadius, Vector2.zero);

        foreach (RaycastHit2D h in hits)
        {
            if (h.transform.gameObject.tag == "Crate")
                h.rigidbody.AddForce((h.transform.position - this.transform.position) * explosionForce, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
