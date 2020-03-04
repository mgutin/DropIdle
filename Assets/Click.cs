using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour
{

    private GameObject explosion = null;
    private float radius = 5;
    private float power = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetMouseButtonDown(0) && explosion == null)
        {
            Vector3 location = Input.mousePosition;
            location.z = 10;
            location = Camera.main.ScreenToWorldPoint(location);
            Collider2D[] colliders = Physics2D.OverlapCircleAll(location, radius);
            Debug.Log("Fire in the hole!");
            foreach (Collider2D hit in colliders)
            {
                Debug.Log("I'm shot!");
           
                Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();

                if (rb != null)
                {
                    float distance = Vector2.Distance(location, rb.transform.position);
                    Vector2 direction = location - rb.transform.position;
                    direction.Normalize();
                    float curPower = power / (1 + distance);
                    rb.AddForce(-direction * curPower, ForceMode2D.Impulse);
                }

            }
        }
       
    }
}
