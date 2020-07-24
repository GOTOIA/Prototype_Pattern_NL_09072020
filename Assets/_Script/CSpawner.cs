using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSpawner : MonoBehaviour
{
    ICopyable copyObj;

    //Methode spawn objet
    public CEnemy SpawnEnemy(CEnemy protoObject)
    {
        copyObj = protoObject.Copy();

        return (CEnemy)protoObject;
    }


    public void type_of()
    {

        Debug.Log("Name : " + this.name);
    }



}
