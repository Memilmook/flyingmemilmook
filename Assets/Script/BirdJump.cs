using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class BirdJump : MonoBehaviour
{

    Rigidbody2D rb;
    public AudioSource audio;
    public AudioClip[] soundClip;
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower;
            audio.PlayOneShot(soundClip[0]);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
