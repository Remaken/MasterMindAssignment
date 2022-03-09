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
    public Sphere sphereManager;
    public Lignes[] lignes;
    private int _ligneActuelle=0;
    private bool _victoire = false;
    /*private GameObject _bouleMaterial;*/
    private int positionActuelle =0;
    private bool[] bonEmplacement;
    private bool[] bonneCouleur;

    private Color couleurDeLaBoule;
    /*private bool bonEmplacement0 =false;
    private bool bonEmplacement1=false;
    private bool bonEmplacement2=false;
    private bool bonEmplacement3=false;
    private bool bonneCouleur0 = false;
    private bool bonneCouleur1 = false;
    private bool bonneCouleur2 = false;
    private bool bonneCouleur3 = false;*/
    

    void Start()
    {
        Verifification();
    }
// verification 0,1,2,3 + boolean trues à chaque si touts booleans = true victoire

    private void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            OnHitColor();
        }
        // Tests(); 
    }
    private void LignSwitcher()
    {
        lignes[_ligneActuelle]=lignes[_ligneActuelle++];
        lignes[_ligneActuelle].gameObject.SetActive(true);
    }

    private void Verifification()

    {
        if (bonneCouleur[0]||bonneCouleur[1]||bonneCouleur[2]||bonneCouleur[3])
        {
            print("une bonne couleur");
        }

        if (bonEmplacement[0]||bonEmplacement[1]||bonEmplacement[2]||bonEmplacement[3])
        {
            print("une bien placée");
        }
        if (bonEmplacement[0]==true&&bonEmplacement[1]==true&&bonEmplacement[2]==true&&bonEmplacement[3]==true)
        //if (masterColorManager.randomSolution[3]==masterColorManager.randomSolution[3])
        {
            _victoire = true;
            YouWin();
            print("vous avez gagné");
        }
        else
        {
            print("c'est pas la bonne réponse");
            LignSwitcher();
        }
        
    }

    private void YouWin()
    {
        //Show Victory stuff
    }


    private void Tests()
    {
        if ((lignes[_ligneActuelle].boulepositions[positionActuelle]==masterColorManager.randomSolution[positionActuelle]))
        {
            bonEmplacement[positionActuelle] = true;
        }
        if ((lignes[_ligneActuelle].boulepositions[positionActuelle]==masterColorManager.randomSolution[masterColorManager.randomSolution.Length]))
        {
            bonneCouleur[positionActuelle] = true;
        }
        
        positionActuelle = positionActuelle++;
        if (positionActuelle>=4)
        {
            positionActuelle = 0;
        }
        
        /*if (lignes[_ligneActuelle].boulepositions[0]==masterColorManager.randomSolution[0])
        {
            bonEmplacement0 = true;
        }
        if (lignes[_ligneActuelle].boulepositions[1]==masterColorManager.randomSolution[1])
        {
            bonEmplacement1 = true;
        }
        if (lignes[_ligneActuelle].boulepositions[2]==masterColorManager.randomSolution[2])
        {
            bonEmplacement2 = true;
        }
        if (lignes[_ligneActuelle].boulepositions[3]==masterColorManager.randomSolution[3])
        {
            bonEmplacement3 = true;
        }

        if ((lignes[_ligneActuelle].boulepositions[0]==masterColorManager.randomSolution[masterColorManager.randomSolution.Length]))
        {
            bonneCouleur0 = true;
        } 
        if ((lignes[_ligneActuelle].boulepositions[1]==masterColorManager.randomSolution[masterColorManager.randomSolution.Length]))
        {
            bonneCouleur1 = true;
        } 
        if ((lignes[_ligneActuelle].boulepositions[2]==masterColorManager.randomSolution[masterColorManager.randomSolution.Length]))
        {
            bonneCouleur2 = true;
        } 
        if ((lignes[_ligneActuelle].boulepositions[3]==masterColorManager.randomSolution[masterColorManager.randomSolution.Length]))
        {
            bonneCouleur3 = true;
        }*/
    }
    
    private void OnHitColor()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if ( hit.collider.gameObject.GetComponent<Sphere>() !=null)
            {
                couleurDeLaBoule = masterColorManager.colors[sphereManager.couleurActuelle].gameObject.GetComponent<MeshRenderer>()
                    .material.GetColor("_Color");
                hit.collider.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",couleurDeLaBoule);
            }
        }

        sphereManager.couleurActuelle++;
        if (sphereManager.couleurActuelle>=masterColorManager.colors.Length)
        {
            sphereManager.couleurActuelle = 0;
        }
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
