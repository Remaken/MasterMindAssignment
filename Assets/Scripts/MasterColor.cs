using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterColor : MonoBehaviour
{
    public GameObject[] colors;
    public GuessColor guessManager;
    public InterfaceManager interManager;
    private GameObject[] _randomSolution = new GameObject[4] ;
    // Start is called before the first frame update
    void Start()
    {
        ColorChoosing();
        print(_randomSolution[0] + " " + _randomSolution[1] + " " +_randomSolution[2] + " " +_randomSolution[3] );
    }

    // Update is called once per frame
    void Update()
    {  
     
    }

    private void ColorChoosing()
    {
        for (int i = 0; i < _randomSolution.Length; i++)
        {
            _randomSolution[i] = colors[Random.Range(0, colors.Length)];
        }
    }
    //TODO: On click middle click reset Color
    //TODO: [] Colors length 4(primary)
    //TODO: [] Master Colors - Computer choosing length 4
}
