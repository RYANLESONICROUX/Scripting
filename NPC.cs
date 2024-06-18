using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //NPC Health
    public int health = 5;

    //NPC level 
    public int level = 1;

    //NPC Speed 
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("Lives: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        //Crathing a vector3-type variable and save the NPC position in it 
        Vector3 newPositon=transform.position;

        //Chaning the position of the NPC on Z axis according to the speed of the NPC and the time between frames 
        newPositon.z += speed * Time.deltaTime;
        //Changing the NPC position to the new value calculated above
        transform.position = newPositon;
    }
}
