using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabRock;

    //value time 2 spawn a rock
    float time2Spawn = 2;

    //value 4 checking timer is running or not
    bool isRuning = false;

    //value 4 checking how many rock on the screen
    int totalRock = 0;  
    
    // Start is called before the first frame update
    void Start()
    {
        isRuning = true;     
    }

    // Update is called once per frame
    void Update()
    {
        if (isRuning)
        {
            if (time2Spawn > 0)
            {
                time2Spawn -= Time.deltaTime;
            }
            else
            {
                Instantiate(prefabRock);
                totalRock += 1;
                time2Spawn = 2;
                Debug.Log(totalRock);
            }
        }
        DestroyRock();
    }

    void DestroyRock()
    {
        if(totalRock == 4)
        {
            GameObject poorRock = GameObject.FindWithTag("Rock");
            Destroy(poorRock);
            totalRock = 3;
        }
    }
}
