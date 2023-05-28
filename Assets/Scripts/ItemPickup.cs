using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemPickup : MonoBehaviour
{

    public bool isHealth;
    public bool isArmor;
    public bool isAmmo;

    public int amount;

    // test
    public GameObject playerObject;
    

    void Start()
    {
        
    }

    void Update()
    {
        BillboardRotation(playerObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (isHealth)
            {
                other.GetComponent<PlayerHealth>().GiveHealth(amount, this.gameObject);
            }

            if (isArmor)
            {
                other.GetComponent<PlayerHealth>().GiveArmor(amount, this.gameObject);
            }

            if (isAmmo)
            {
               other.GetComponentInChildren<Gun>().GiveAmmo(amount, this.gameObject);
            }
        }
    }

    void BillboardRotation(GameObject player)
    {
        
        float xDist = this.transform.position.x - player.transform.position.x;
        float zDist = this.transform.position.z - player.transform.position.z;
        
        float angle = Mathf.Atan2(xDist, zDist) * Mathf.Rad2Deg;
        
        Quaternion rotation = Quaternion.Euler(0f, angle, 0f);
        this.transform.rotation = rotation;
    }
}
