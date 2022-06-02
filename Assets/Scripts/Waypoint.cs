using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    [SerializeField] bool isClickable;
    [SerializeField] Transform tower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (isClickable)
        {
            Debug.Log(transform.name);
            Instantiate(tower, transform.position, Quaternion.identity);
            isClickable = false;
        }
        
    }

}
