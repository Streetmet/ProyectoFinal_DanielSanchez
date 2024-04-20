using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [Header("Paneles escena")]
    [SerializeField] private GameObject[] paneles;

    public void ActivadorDePaneles(int panel)
    {
        for(int i = 0; i < paneles.Length; i++)
        {
            if( i == panel)
            {
                paneles[i].SetActive(true);
            }
            else
            {
                paneles[i].SetActive(false);
            }
        }
    }
}
