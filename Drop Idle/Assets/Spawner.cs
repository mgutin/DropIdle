using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float cooldown = 0.1f;
    public float curTime = 0;
    public Vector3 spawnLocation;
    public float chaosFactor = 10f;
    public string ballName = "Ball";

    private static int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        curTime +=Time.deltaTime;
        if(curTime > cooldown)
        {
            curTime -= cooldown;
            spawn();
        }
    }

    void spawn()
    {
        //Setup GameObject
        GameObject newBallObject = GameObject.Instantiate(GameObject.Find(ballName), spawnLocation, Quaternion.identity);    
        Transform sprite = newBallObject.transform.Find("Sprite");
        Transform lighting = newBallObject.transform.Find("Lighting");
        sprite.position = spawnLocation;
        sprite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-chaosFactor, chaosFactor), 0);
        lighting.position = spawnLocation;


        //Setup Ball class
        Ball newBall = newBallObject.GetComponent<Ball>();
        newBall.ballObject = newBallObject;
        newBall.sprite = sprite;
        newBall.lighting = lighting;
        Global.balls.Add(newBall);
    }
}
