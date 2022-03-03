using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterColor : MonoBehaviour
{
    public Material[] colors;
    private int[] _randomSolution ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(_randomSolution);
    }

    private void ColorChoosing()
    {
        for (int i = 0; i < _randomSolution.Length; i++)
        {
            //TODO: RandomRange choose color and replace material Random.Range(colors.Length);
        }
    }
    //TODO: On click middle click reset Color
    //TODO: [] Colors length 4(primary)
    //TODO: [] Master Colors - Computer choosing length 4
}
