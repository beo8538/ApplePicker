/****
 * Created by Betzaida Orriz Rivas
 * Date Created 1/31/2022
 * 
 * Last Edited by: NA
 * Last Edited: 1/31/2022
 * 
 * Description: Controls the movement of the AppleTree
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    /****VARIABLES****/
    [Header("Set In Inpsector")]
    public float speed = 1f; //tree speed
    public float leftAndRightEdge = 10f; //distance where the tree turns around
    public GameObject applePreFab; //prefab for instantiating apples
    public float secondsBetweenApplesDrops = 1f; // time between apples dropped
    public float chanceToChangeDirection = 0.1f; //chance the tree changes direction (left and right)


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position; //records current position
        pos.x += speed * Time.deltaTime; //adds speed to the x position
        transform.position = pos; //apply the position value

        //Change Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //set speed to positive
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //set speed to negative value
        } //end Change Directions


    }//end Update

    //FixedUpdate is called pn fixed intervals (50 times per second)
    if(Random.value < chanceToChangeDirection){

        speed *= -1;

}
