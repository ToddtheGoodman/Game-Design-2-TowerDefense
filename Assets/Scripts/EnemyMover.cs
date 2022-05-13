using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveEnemy()
    {
        foreach(Waypoint waypoint in path)
        {
            Debug.Log(waypoint.name);
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(2);
        }
    }

}
