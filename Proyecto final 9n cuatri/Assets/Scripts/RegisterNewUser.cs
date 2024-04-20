using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterNewUser : MonoBehaviour
{

    //public TMP_InputField contrasena;
    public TMP_InputField nickname;
    public string nicknameText;
    public static RegisterNewUser registro;

    public void Awake()
    {
        nicknameText = "Default";
        nickname = GameObject.Find("InputName").GetComponent<TMP_InputField>();

        if (registro == null)
        {
            registro = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //Destroy(gameObject);
        }
    }

    public void SetPlayerName()
    {
        nicknameText = nickname.text;

    }

}
