using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] [Range(0f, 5f)] float enemySpeed = 1f;

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
        foreach(Waypoint waypoint in path) //will keep running until it reaches the last waypoint in the path
        {

            Vector3 startPosition = transform.position; // A LERP needs a start and end position
            Vector3 endPosition = waypoint.transform.position;

            float travelPercentage = 0f; // 0 is the start position, 1 is the end position

            transform.LookAt(endPosition);

            while(travelPercentage < 1)
            {
                travelPercentage += Time.deltaTime * enemySpeed;

                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercentage);
                yield return new WaitForEndOfFrame();
            }


            //Debug.Log(waypoint.name);
            //transform.position = waypoint.transform.position;
            //yield return new WaitForSeconds(waitTime);
        }
    }

}
