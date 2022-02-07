/****
 * Created by Betzaida Orriz Rivas
 * Date Created 2/04/2022
 * 
 * Last Edited by: NA
 * Last Edited: 2/07/2022
 * 
 * Description: Controls creation and deletion of apples
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    /****VARIABLES****/
    public static float bottomY = -20f; //checks where the bottom of screen is

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject); //destroys the apple once it passes the bottom
            GameObject GameManager = GameObject.Find("GameManager");
            ApplePicker apScript = GameManager.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
        }
    }
}
