using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private float jumpSpeed = 6f;
    [SerializeField] private AudioSource dieSFX;
    [SerializeField] private AudioSource pointSFX;
    [SerializeField] private AudioSource wingSFX;
    private Rigidbody2D rb2d;

    void Start()
    {
        Time.timeScale = 1f;
        rb2d = GetComponent<Rigidbody2D>();
        deathScreen.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.up * jumpSpeed;
            wingSFX.Play();
        }  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Scoring")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
            pointSFX.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
            dieSFX.Play();

        }
    }
}
