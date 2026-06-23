using UnityEngine;

public class Path : MonoBehaviour
{
    public GameObject[] waypoints;

    private void OnDrawGizmos()
    {
    if (waypoints.Length > 0)
        {
            for (int i = 0; i < waypoints.Length - 1; i++)
            {
                if (i < waypoints.Length - 1)
                {
                    Gizmos.color = Color.white;
                    Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i+1].transform.position);
                }
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
