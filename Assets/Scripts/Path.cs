using UnityEngine;
using UnityEditor;

public class Path : MonoBehaviour
{
    public GameObject[] waypoints;
    // OnDrawGizmos is used to draw lines betweend waypoints, you can only see them in editor. Not in game view.
    private void OnDrawGizmos()
    {
    if (waypoints.Length > 0)
        {
            for (int i = 0; i < waypoints.Length; i++)
            {
                //GUIStyle adds text above waypoints.
                GUIStyle style = new GUIStyle();
                style.normal.textColor = Color.white;
                style.fontSize = 12;
                style.alignment = TextAnchor.MiddleCenter;
                Handles.Label(waypoints[i].transform.position + Vector3.up * 0.9f, "Waypoint " + i, style);

                if (i < waypoints.Length - 1)
                {
                    Gizmos.color = Color.white;
                    Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i+1].transform.position);
                }
            }
        }
    }
}
