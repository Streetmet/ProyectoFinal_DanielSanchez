using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetUserName : MonoBehaviour
{
    public void Start()
    {
        Debug.Log("reinicio");
       /* if (RegisterNewUser.registro.nickname == null)
        {
            RegisterNewUser.registro.nickname = GameObject.Find("InputfieldName").GetComponent<TMP_InputField>();
        } */
        RegisterNewUser.registro.nickname = GameObject.Find("InputName").GetComponent<TMP_InputField>();
    }

    public void Update()
    {
        RegisterNewUser.registro.SetPlayerName();
        
    }

}
