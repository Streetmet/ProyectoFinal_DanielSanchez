using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void CambioEscenaPrincipal()
    {
        SceneManager.LoadScene("Inicio");
    }

    void DoDelayAction(float delayTime)
    {
        StartCoroutine(DelayAction(delayTime));
    }

    IEnumerator DelayAction(float delayTime)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime = 1f);
        
        //Do the action after the delay time has finished.
    }


    public void CambioScenaRegistro()
    {
        Invoke("Registro", 2.0f);
    }
    public void Registro()
    {
        SceneManager.LoadScene("Registro");
    }
}
