using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootManager : MonoBehaviour
{
    public GameObject[] _drops;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject RollForLoot()
    {
        int whichItem = Random.Range(0, 3);

        return (_drops[whichItem]);
    }
}
