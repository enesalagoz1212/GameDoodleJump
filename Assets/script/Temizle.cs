using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temizle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D temas)
    {
        float rastgelex = Random.Range(-3.5f, 3.5f);
        float rastgeley = 10f;
        if (temas.tag=="Platform")
        {
            temas.transform.position = new Vector3(rastgelex, temas.transform.position.y + rastgeley, temas.transform.position.z);
        }
    }


}
