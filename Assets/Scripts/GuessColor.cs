using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

public class GuessColor : MonoBehaviour

{
    public MasterColor masterColorManager;
    
    
    // à revoir
    
    /* je veux que la classe guess vérifie les données du tableau que master aura randomisé
     pourquoi hériter ? pour les couleurs, pas != ni d'ajouts donc inutile 
     comment se déplacer pour choisir un autre emplacement ? raytracing sur le click ?
     Où utiliser les scripts ? Prefab de boule noire (miniature qui swap avec les autres boules ?
     
     */
    public
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        onHitColor();
    }

    private void onHitColor()
    {
        
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (gameObject.GetComponentInChildren(gameObject.CompareTag("Sphere"))
                {
                    for (int i = 0; i < masterColorManager.colors.Length; i++)
                    {
                        Destroy(this.gameObject);
                        Instantiate(masterColorManager.colors[i]);
                    }
                }
            }
        }

    }
    //TODO: COMMUNICATION BETWEEN GUESS & MASTER
    //TODO: Number of Tries
    //TODO: [] Rows  length 12  == Line
    //TODO: [] Rows - Tries length 4
    //TODO: ON click right click color change
    
}
