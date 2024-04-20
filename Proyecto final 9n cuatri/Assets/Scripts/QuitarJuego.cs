using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarJuego : MonoBehaviour
{
  public void CerrarJuego()
    {
        Application.Quit();
        Debug.Log("JUEGO CERRADO");
    }
}
