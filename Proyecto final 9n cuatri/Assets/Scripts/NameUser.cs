using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameUser : MonoBehaviour
{
    public TextMeshProUGUI displayPlayerName;

    public void Start()
    {
        
        displayPlayerName.text = RegisterNewUser.registro.nicknameText;

    }
}
