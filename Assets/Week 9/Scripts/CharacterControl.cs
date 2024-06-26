using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI selectedText;
    public static Villager SelectedVillager { get; private set; }


    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }

    private void Update()
    {
        
        if (SelectedVillager == null)
        {
            selectedText.text = ("Selected: None");
        }
        else
        {
            selectedText.text = ("Selected: " + SelectedVillager.CanOpen());
        }
    }


}
