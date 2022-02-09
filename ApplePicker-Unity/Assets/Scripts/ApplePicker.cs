/****
 * Created by Betzaida Orriz Rivas
 * Date Created 2/04/2022
 * 
 * Last Edited by: NA
 * Last Edited: 2/08/2022
 * 
 * Description: Instantiating the Basket
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    /****VARIABLES****/
    [Header("Set In Inpsector")]
    public GameObject basketPreFab; //basket in game
    public int numBaskets = 3; //number of baskets in game
    public float basketBottomY = -14f; //bottom of basket in game
    public float basketSpacingY = 2f; //spacing of the basket in game
    public List<GameObject> basketList;

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPreFab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGo in tAppleArray)
        {
            Destroy(tGo);
        } //end foreach

        //Destroy one of the baskets
        //Get the index of the last Baskets in basketList
        int basketIndex = basketList.Count - 1;
        //Get s reference to that Basket GameObject
        GameObject tBasketGo = basketList[basketIndex];
        //Remove the Basket from the list and destroy the GameObject
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGo);

        //If there are no Baskets left, restart that game
        if(basketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene-00");
        }

    } //end Apple Destroyed
}
