using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

public class GuessColor : MonoBehaviour

{
    public MasterColor masterColorManager;
    private Material[] _couleur;
    private Renderer _rend;



    void Start()
    {
        /*_rend = GetComponent<Renderer>();
        _rend.enabled = true;
        _rend.sharedMaterial = _couleur[0];*/
    }

    void Update()
    { 
         onHitColor();
    }

    // Nouvelle idée -> utiliser le Render pour aléger les tableaux - un objet avec déjà implémenté les 4 couleurs et swap entre elles
    
    private void onHitColor()
    {
        
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (Physics.Raycast(ray, out hit))
            {
                print("j'ai touché");
                for (int i = 0; i < _couleur.Length; i++)
                {
                    _rend.sharedMaterial = _couleur[i];
                }
            }
        }

    }
    //TODO: COMMUNICATION BETWEEN GUESS & MASTER
    //TODO: Number of Tries
    //TODO: [] Rows  length 12  == Line
    //TODO: [] Rows - Tries length 4
    //TODO: ON click right click color change
    
    
    /* je veux que la classe guess vérifie les données du tableau que master aura randomisé
     pourquoi hériter ? pour les couleurs, pas != ni d'ajouts donc inutile 
     comment se déplacer pour choisir un autre emplacement ? raytracing sur le click ?
     Où utiliser les scripts ? Prefab de boule noire (miniature qui swap avec les autres boules ?
     
     */
    
}
