using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ballObject;
    public Transform sprite;
    public Transform lighting;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sprite != null && lighting != null) {
            lighting.position = sprite.position;
        }
    }
}
