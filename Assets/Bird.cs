using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    private float jumpH = 10f;
    private Rigidbody2D rb2D;
    public GameObject GameOverUI;
    public Text countScore;
    public Text ScoreTot;
    int count;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
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
        if (collision.gameObject.CompareTag("Score"))
        {
            count += 1;
            SetCountText();
        }
        else
        {
            Debug.Log("Game Over"); //Peut être modifier pour afficher un Texte.
            Time.timeScale = 0;  //Arrête le jeu lorsqu'on entre en collision avec une pipe
            ScoreTot.text = "Score : " + count.ToString();
            this.GameOverUI.SetActive(true);
        }
    }
        void SetCountText()
    {
        countScore.text = "Score : " + count.ToString();
    }
}
