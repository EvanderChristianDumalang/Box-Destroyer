using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawner : MonoBehaviour
{
    Rigidbody2D _rb;
    public GameObject square;
    public GameObject topWall;
    public GameObject bottomWall;
    public GameObject rightWall;
    public GameObject leftWall;
    public float distance;
    private int score = 0;
    public Text scoreText;
    public GameObject ball;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
        audio = GetComponent<AudioSource>();
        for (int i = 0; i < Random.Range(10, 20); i++)
        {
            float[] horizontalPos = new float[2];
            horizontalPos[0] = Random.Range(ball.transform.position.y + distance, topWall.transform.position.y - distance);
            horizontalPos[1] = Random.Range(bottomWall.transform.position.y + distance, ball.transform.position.y - distance);

            float[] verticalPos = new float[2];
            verticalPos[0] = Random.Range(leftWall.transform.position.x + distance, ball.transform.position.x - distance);
            verticalPos[1] = Random.Range(ball.transform.position.x + distance, rightWall.transform.position.x - distance);

            Vector2 spawnPosition = new Vector2(
                horizontalPos[Random.Range(0, 2)],
                verticalPos[Random.Range(0, 2)]
            );
            Instantiate(square, spawnPosition, Quaternion.identity);
        }
        InvokeRepeating("respawn", 0f, 3.0f);
    }

    public void respawn()
    {
        float[] horizontalPos = new float[2];
        horizontalPos[0] = Random.Range(ball.transform.position.y + distance, topWall.transform.position.y - distance);
        horizontalPos[1] = Random.Range(bottomWall.transform.position.y + distance, ball.transform.position.y - distance);

        float[] verticalPos = new float[2];
        verticalPos[0] = Random.Range(leftWall.transform.position.x + distance, ball.transform.position.x - distance);
        verticalPos[1] = Random.Range(ball.transform.position.x + distance, rightWall.transform.position.x - distance);

        Vector2 Position = new Vector2(
            horizontalPos[Random.Range(0, 2)],
            verticalPos[Random.Range(0, 2)]
        );
        Instantiate(square, Position, Quaternion.identity);
    }

    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Respawn")
        {
            Destroy(collision.gameObject);
            audio.Play();
            score++;
            scoreText.text = "Score: " + score.ToString();
            audio = GetComponent<AudioSource>();

        }

    }
}
