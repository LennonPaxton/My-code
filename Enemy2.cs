using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject pointA ;
    public GameObject pointB ;
    private Transform currentPoint;
    private Rigidbody2D rb;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position; 
        if(currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(Speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-Speed, 0);
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
        }
    }
}
