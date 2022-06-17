using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterItemGet : MonoBehaviour
{

    [SerializeField]
    private Inventory theInventory;


    void Update()
    {

        if (theInventory == null && UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex > 4)
        {
            theInventory = GameObject.Find("InGameCanvas").transform.Find("InGame_Ui").transform.Find("Options").transform.Find("Inventory").GetComponent<Inventory>();
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Item")
        {

            //if (Input.GetKeyDown(KeyCode.E))
            //{
            //    theInventory.AcquireItem(other.transform.GetComponent<ItemPickUp>().item);
            //    Destroy(other.gameObject);
            //    actionText.gameObject.SetActive(false);
            //}

            theInventory.AcquireItem(other.transform.GetComponent<ItemPickUp>().item);
            Destroy(other.gameObject);
        }
    }
}
