using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class karekter_hareket : MonoBehaviour
{
    public float hiz;
    public Rigidbody2D doodle;
    private float hareketInput;



    void Update()
    {
        hareketInput = Input.GetAxis("Horizontal");
        doodle.velocity = new Vector2(hiz * hareketInput, doodle.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag=="Bitis")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
