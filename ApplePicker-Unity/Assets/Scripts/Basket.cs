/****
 * Created by Betzaida Orriz Rivas
 * Date Created 2/04/2022
 * 
 * Last Edited by: NA
 * Last Edited: 2/04/2022
 * 
 * Description: moves the basket
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;

        // The Camera's z position sets how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z;

        // Convert the point from 2D screen space into 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        // Move the x position of this Basket to the x position of the Mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Find out what hit this basket
        GameObject collideWith = collision.gameObject; // Makes collideWith as a collision
        if(collideWith.tag == "Apple") //assigns collideWith to Apples
        {
            Destroy(collideWith); //destroys the apples
        }
    }
}
