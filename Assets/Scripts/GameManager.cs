using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject MechG;
    public GameObject MechS;
    public GameObject MechW;
    public Transform[] Mechspawn;
    // Start is called before the first frame update
    void Start()
    {
        SpawnMech();
    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnMech();
        }




    }



    void SpawnMech()
    {
        int index = Random.Range(0, Mechspawn.Length);
        Vector3 spawnPos = Mechspawn[index].position;
        GameObject Mech1= Instantiate(MechG, spawnPos, Quaternion.identity);
        GameObject Mech2 = Instantiate(MechS, spawnPos, Quaternion.identity);
        GameObject Mech3 = Instantiate(MechW, spawnPos, Quaternion.identity);




        int dirModifier = (index > 2) ? -1 : 1;
        Mech1.GetComponent<MechG>().speed = Random.Range(3.0f, 6.0f);
        Mech2.GetComponent<MechS>().speed = Random.Range(3.0f, 6.0f);
        Mech3.GetComponent<MechW>().speed = Random.Range(3.0f, 6.0f);

    }




}
