using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterColor : MonoBehaviour
{
    public GameObject[] colors;
    public GuessColor guessManager;
    public InterfaceManager interManager;
    private int[] _randomSolution = new int[4] ;
    // Start is called before the first frame update
    void Start()
    {
        ColorChoosing();
    }

    // Update is called once per frame
    void Update()
    {
        print(_randomSolution.Length);
    }

    private void ColorChoosing()
    {
        for (int i = 0; i < _randomSolution.Length; i++)
        {
            i = colors[Random.Range(0,colors.Length)];
        }
    }
    //TODO: On click middle click reset Color
    //TODO: [] Colors length 4(primary)
    //TODO: [] Master Colors - Computer choosing length 4
}
