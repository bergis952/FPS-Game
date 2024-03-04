using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_DamageReceiver : MonoBehaviour, IEntity
{
    //This script will keep track of player HP
    public float playerHP = 100;
    public SC_CharacterController playerController;
    public SC_WeaponManager weaponManager;

    public void ApplyDamage(float points)
    {
        playerHP -= points;
        Debug.Log("I hurt");
        if (playerHP <= 0)
        {
            //Player is dead
            playerController.canMove = false;
            playerHP = 0;
        }
    }
}