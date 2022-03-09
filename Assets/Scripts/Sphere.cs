using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public MasterColor masterColorManager;
    public int couleurActuelle = 0;

    private void Start()
    {
        
    }


    public Color CouleurDeBase()
    {
       return gameObject.GetComponent<MeshRenderer>().material.GetColor("_Color");
    }

    public void ChangementCouleur(Color NewColor)
    {
        GetComponent<MeshRenderer>().material.SetColor("_Color",NewColor);
    }

    
    
}
