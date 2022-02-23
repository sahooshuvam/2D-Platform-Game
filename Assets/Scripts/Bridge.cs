using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public float destroyTimmer;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(DestroyBridge(destroyTimmer));
    }

    IEnumerator DestroyBridge(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
