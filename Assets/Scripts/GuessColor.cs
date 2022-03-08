using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

public class GuessColor : MonoBehaviour

{
    public MasterColor masterColorManager;
    private GameObject _bouleMaterial;
    public GameObject[] lignes;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            OnHitColor();
        }
         
    }

    // Nouvelle idée -> utiliser le Render pour aléger les tableaux - un objet avec déjà implémenté les 4 couleurs et swap entre elles
    
    private void OnHitColor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(ray.origin,ray.direction, Color.green);

        if (Physics.Raycast(ray, out hit))
        {
            if (gameObject.CompareTag("Sphere"))
            {
                print("j'ai touché sphere");
                for (int i = 0; i < masterColorManager.colors.Length; i++)
                {
                    Instantiate(masterColorManager.colors[i]);
                    Destroy(gameObject);
                }
            }
        }
    }

    private void ResetColor()
    {
        // Remettre couleur en couleur de base
    }

    private void Tentatives()
    {
        for (int i = 0; i < lignes.Length; i++)
        {
            //je me balade dans le tableau d'essais
        }
    }

    private void Verifification()

    {
        
    }

    private void YouWin()
    {
        
    }

    //TODO: Naviguer sur les lignes "essais"
    //TODO: choisir la couleur en fonction de la position
    //TODO: COMMUNICATION BETWEEN GUESS & MASTER
    //TODO: Number of Tries
    //TODO: [] Rows  length 12  == Line
    //TODO: [] Rows - Tries length 4
    //TODO: ON click right click color change
    //TODO: On click middle click reset Color
    
    /* 
     comment se déplacer pour choisir un autre emplacement ? raytracing sur le click ?
     Où utiliser les scripts ? Prefab de boule noire (miniature qui swap avec les autres boules ?
     
     */
    
}
