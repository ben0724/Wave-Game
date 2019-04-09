using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleManager : MonoBehaviour {


    public GameObject PlayerObj;
    public GameObject[] ObsticlesArr;


    int obsticleCount;


    int playerDistanceIndex = -1;
    int obsticleIndex = 0;
    int distanceToNext = 50;


	// Use this for initialization
	void Start ()
    {
        obsticleCount = ObsticlesArr.Length;
        InstantiateObsticle();
	}
	
	// Update is called once per frame
	void Update ()
    {
        int PlayerDistance = (int)(PlayerObj.transform.position.y / (distanceToNext));

        if(playerDistanceIndex != PlayerDistance)
        {
            InstantiateObsticle();
            playerDistanceIndex = PlayerDistance;
        }
	}


    public void InstantiateObsticle()
    {
        int RandomInt = Random.Range(0, obsticleCount);
        GameObject newObsticle = Instantiate(ObsticlesArr[RandomInt], new Vector3(0, obsticleIndex * distanceToNext), Quaternion.identity);
        newObsticle.transform.SetParent(transform);
        obsticleIndex++;

    }



}
