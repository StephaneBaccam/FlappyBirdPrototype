using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private float jumpH = 10f;
    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb2D.velocity = Vector2.up * jumpH;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Game Over"); //Peut être modifier pour afficher un Texte.
        Time.timeScale = 0;  //Arrête le jeu lorsqu'on entre en collision avec une pipe
    }
}
