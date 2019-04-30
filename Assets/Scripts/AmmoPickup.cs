﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// note: responsible for increasing a weapon's ammo when collided with (ie. picked up)

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoAmount = 5;
    [SerializeField] Ammo ammoSlot; //This won't scale past one scene

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            print("player entered me... the horror");
            ammoSlot.IncreaseAmmo(ammoAmount);
            //TODO: play sound
            Destroy(gameObject);
        }
    }
}
