using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject ball = collision.gameObject.transform.parent.gameObject;
        Global.balls.Remove(ball.GetComponent<Ball>());
        collision.gameObject.SetActive(false);
        Destroy(ball);
        Global.score(1);
    }
}
