using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNumbers : MonoBehaviour
{
    int number_1 = Random.Range(0, 100);
    int number_2 = Random.Range(0, 100);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int AddTwoNumbers()
    {
        return number_1 + number_2;
    }
}
