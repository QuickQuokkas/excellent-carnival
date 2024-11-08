using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingTriangle : MonoBehaviour
{
    [SerializeField] private GameObject circle;
    [SerializeField] private float quick = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, circle.transform.position, quick * Time.deltaTime);
    }
}
