/****
 * Created by Betzaida Orriz Rivas
 * Date Created 2/04/2022
 * 
 * Last Edited by: NA
 * Last Edited: 2/04/2022
 * 
 * Description: Instantiating the Basket
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    /****VARIABLES****/
    [Header("Set In Inpsector")]
    public GameObject basketPreFab; //basket in game
    public int numBaskets = 3; //number of baskets in game
    public float basketBottomY = -14f; //bottom of basket in game
    public float basketSpacingY = 2f; //spacing of the basket in game

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPreFab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
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
    } //end AppleDestroyed
}
