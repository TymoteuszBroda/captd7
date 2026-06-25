using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int numberOfEnemies = 100;
    public Path path;


    void spawnEnemies()
    {
        path = GameObject.Find("Path").GetComponent<Path>();
        for(int i = 0; i < numberOfEnemies; i++)
        {
            //Spawns >>numberOfEnemies<< enemies at the first waypoint of the path
            Instantiate(enemyPrefab, path.getWaypointPosition(0), Quaternion.identity);
        }
    }
    private void Awake()
    {
        spawnEnemies();
    }
    void OnEnable()
    {
        
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
