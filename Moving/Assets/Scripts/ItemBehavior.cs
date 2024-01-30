using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                Destroy(this.transform.parent.gameObject);

                Debug.Log("RAHHH YOU GOT AN ITEM");  
            }
        }
    }
}
