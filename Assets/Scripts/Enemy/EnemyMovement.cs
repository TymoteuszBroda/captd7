using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    [SerializeField] private float movementSpeed = 0.2f;
    [SerializeField] private Path enemyPath;
    private Vector3 _targetPosition;
    private int _currentWaypointIndex = 0;

    private void Awake()
    {
        enemyPath = GameObject.Find("Path").GetComponent<Path>();
    }
    private void OnEnable()
    {
        _currentWaypointIndex = 0;
        _targetPosition = enemyPath.getWaypointPosition(_currentWaypointIndex);
    }
    // Update is called once per frame
    void Update()
    {
        //moves enemy roward the target position
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, movementSpeed * Time.deltaTime);

        float distanceToTarget = (transform.position - _targetPosition).magnitude;

        //checks if the enemy is close enough to the target position
        //if it is, it will move to the next waypoint
        if (distanceToTarget < 0.1f)
        {
            _currentWaypointIndex++;
            _targetPosition = enemyPath.getWaypointPosition(_currentWaypointIndex);
        }
    }
}
