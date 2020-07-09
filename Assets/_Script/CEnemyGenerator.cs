using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CEnemyGenerator : MonoBehaviour
{

    GameObject TankLocation;
    GameObject DroneLocation;

    [SerializeField] CTank tankEnemy=default;
    [SerializeField] CDrone droneEnemy=default;

    [SerializeField] CSpawner spawnEnemy=default;

    CEnemy enemyTank;
    CEnemy enemyDrone;

    // Start is called before the first frame update
    void Start()
    {
        TankLocation = GameObject.Find("TankLocation");
        DroneLocation = GameObject.Find("DroneLocation");

        enemyTank = spawnEnemy.SpawnEnemy(tankEnemy);
        enemyDrone = spawnEnemy.SpawnEnemy(droneEnemy);

    }

    // Update is called once per frame
    void Update()
    {

        
         enemyTank.transform.position = TankLocation.transform.position;

         enemyDrone.transform.position = DroneLocation.transform.position;





       
    }
}
