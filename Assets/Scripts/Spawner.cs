using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject square;
    public GameObject topWall;
    public GameObject bottomWall;
    public GameObject rightWall;
    public GameObject leftWall;
    private float a = 0.5f;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Random.Range(10,20); i++)
        {
            float[] horizontalPos = new float[2];
            horizontalPos[0] = Random.Range(ball.transform.position.y + a, topWall.transform.position.y - a);
            horizontalPos[1] = Random.Range(bottomWall.transform.position.y + a, ball.transform.position.y - a);

            float[] verticalPos = new float[2];
            verticalPos[0] = Random.Range(leftWall.transform.position.x + a, ball.transform.position.x - a);
            verticalPos[1] = Random.Range(ball.transform.position.x + a, rightWall.transform.position.x - a);

            Vector2 spawnPosition = new Vector2(
                horizontalPos[Random.Range(0, 2)],
                verticalPos[Random.Range(0, 2)]
            );
            Instantiate(square, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
