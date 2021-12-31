using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Laboratory : MonoBehaviour
{
    public TextMeshProUGUI lbl_Life;
    public TextMeshProUGUI lbl_Damage;

    private Character PlayerCharacter;

    private void OnDisable()
    {
        //PlayerCharacter.Life.OnValueChange -= RefreshUI;
        //PlayerCharacter.Life.OnCurrentValueChange -= RefreshUI;
        //PlayerCharacter.Damage.OnValueChange -= RefreshUI;
    }

    private void Start()
    {
        //Debug.Log("J'ai pété");
        //PlayerCharacter = PlayerManager.Instance.playerData.Character;
        //PlayerCharacter.Life.OnValueChange += RefreshUI;
        //PlayerCharacter.Life.OnCurrentValueChange += RefreshUI;
        //PlayerCharacter.Damage.OnValueChange += RefreshUI;
        //RefreshUI();
    }

    private void Update()
    {
        
    }

    public void AddLife()
    {
        
    }

    public void AddDamage()
    {
       
    }


    

}
