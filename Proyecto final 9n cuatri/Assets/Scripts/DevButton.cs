using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DevButton : MonoBehaviour
{
    public string code;
    public TMP_InputField accesCode;
    public string accesCodeNum;
    ChangeScene changeScene;
    //ChangeScene changeScene = new ChangeScene();
    void Update()
    {
        accesCode = GameObject.Find("Password Imput").GetComponent<TMP_InputField>();
        accesCodeNum = accesCode.text;
    }

    public void buttonPass()
    {
        if (accesCodeNum == code)
        {
          changeScene.CambioEscenaPrincipal();
        }
    }
}
