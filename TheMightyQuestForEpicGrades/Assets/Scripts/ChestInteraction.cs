﻿using System;
using UnityEngine;
using System.Collections;
using Assets.Scripts;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ChestInteraction : MonoBehaviour
{
    public Question LinkedQuestion { get; set; }
    private bool ChestIsOpen = false;
    private bool ChestIsLocked = false;

    public void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown("e") && !ChestIsLocked) //col.gameObject.tag == "Player")
        {
            ChestIsOpen = true;
            OpenChest();
            ChestIsLocked = true; //Truhe abschließen
            Destroy(gameObject);//Lässt Truhe verschwinden
        }
    }

    public void OpenChest()
    {
        SceneManager.LoadScene("NewQuestion");
        //Fragemenü aufrufen
        ChestIsOpen = false;
    }

}
