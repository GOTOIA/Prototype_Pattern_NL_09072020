using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSpawner : MonoBehaviour
{
    ICopyable copyObj;


    CEnemy SpawnEnemy(CEnemy protoObject)
    {
        protoObject=(CEnemy)copyObj.Copy();

        return protoObject;
    }


}
