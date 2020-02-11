using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Vector3> waypoints;
    public bool isLooped = false;

    private void Awake()
    {
        Vector3 pos = this.transform.position;
        waypoints.Add(pos);
        waypoints.Add(pos + new Vector3(-4, 0, 4));
        waypoints.Add(pos + new Vector3(4, 0, 4));
        waypoints.Add(pos + new Vector3(4, 0, -4));
        waypoints.Add(pos + new Vector3(-4, 0, -4));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        
        for (int i = 1; i < waypoints.Count; i++)
        {
            Gizmos.DrawSphere(waypoints[i], 0.5f);
        }
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
