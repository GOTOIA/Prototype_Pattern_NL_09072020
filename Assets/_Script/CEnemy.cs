using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemy : MonoBehaviour, ICopyable
{

    //Creation de la copie de l'objet ( copie de sa référence mémoire)
    public ICopyable Copy()
    {
        return Instantiate(this);
    }

    public void type_of(){

        Debug.Log("Name : "+this.name);
    }

   


}
