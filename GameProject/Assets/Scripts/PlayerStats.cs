using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public float health = 10f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        if (health >=0)
        {
            Destroy(player);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
