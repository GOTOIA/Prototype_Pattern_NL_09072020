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

    CSpawner spawnEnemy=default;

    CEnemy enemyTank;
    CEnemy enemyDrone;



    void Awake()
    {

        spawnEnemy = GetComponent<CSpawner>();

    }
    // Start is called before the first frame update
    void Start()
    {
        TankLocation = GameObject.Find("TankLocation");
        DroneLocation = GameObject.Find("DroneLocation");

       

        enemyTank = spawnEnemy.SpawnEnemy(tankEnemy);
        enemyDrone = spawnEnemy.SpawnEnemy(droneEnemy);

        spawnEnemy.type_of();
        enemyTank.type_of();
        enemyDrone.type_of();

        

    }

    // Update is called once per frame
    void Update()
    {

        
         enemyTank.transform.position = TankLocation.transform.position;

         enemyDrone.transform.position = DroneLocation.transform.position;





       
    }
}
