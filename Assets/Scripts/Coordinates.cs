using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways] //Runs the code in scene mode

public class Coordinates : MonoBehaviour
{

    private TextMeshPro label;
    private Vector2Int coordinates = new Vector2Int(); //constantly will be updaing its variable location


    void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates();
    }

    // Start is called before the first frame update
    void Start()
    {
        DisplayCoordinates();
        UpdateObjectName();
    }

    // Update is called once per frame
    void Update()
    {

        DisplayCoordinates();
        UpdateObjectName();

        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
        }
    }

    void DisplayCoordinates()
    {
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x /10);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z /10);

        label.text = coordinates.x + "," + coordinates.y;
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }

}
