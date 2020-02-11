using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Vector3> waypoints;
    public bool isLooped = false;

    private void Awake()
    {
        waypoints.Add(this.transform.position);
        //waypoints.
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
