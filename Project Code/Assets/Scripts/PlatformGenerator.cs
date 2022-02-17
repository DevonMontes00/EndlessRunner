using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject obstacle;
    [SerializeField] private GameObject obstacle1;
    [SerializeField] private GameObject healthPU;
    [SerializeField] private GameObject jumpPU;
    [SerializeField] private GameObject slowPU;
    [SerializeField] private float distanceThreshold;
    GameObject player;
    int random;
    int powerUp;
    private Vector3 nextPlatformPos = Vector3.zero;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Instantiate(platform, nextPlatformPos, Quaternion.identity); // Gimbal Lock -- Euler angles vs Quaternions
        nextPlatformPos += new Vector3(0,0,55);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(nextPlatformPos, player.transform.position) < distanceThreshold){
            GameObject plat = Instantiate(platform, nextPlatformPos, Quaternion.identity);
            plat.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
            for (int i = 0; i < 3; i++)
            {
                obstacle.transform.position = new Vector3(Random.Range(-2,3), 1, Random.Range(-20, 21));
                GameObject obs = Instantiate(obstacle, nextPlatformPos + obstacle.transform.position, Quaternion.identity);
                obs.transform.parent = plat.transform;
            }

            for (int i = 0; i < 3; i++)
            {
                obstacle1.transform.position = new Vector3(Random.Range(-2, 3), 1, Random.Range(-20, 21));
                GameObject obs = Instantiate(obstacle1, nextPlatformPos + obstacle1.transform.position, Quaternion.identity);
                obs.transform.parent = plat.transform;
            }

            random = Random.Range(1, 5);
            powerUp = Random.Range(1, 4);


            if (random == 1)
            {
                if (powerUp == 1)
                {
                    healthPU.transform.position = new Vector3(Random.Range(-2, 3), 1, Random.Range(-20, 21));
                    GameObject PU = Instantiate(healthPU, nextPlatformPos + healthPU.transform.position, Quaternion.identity);
                    PU.transform.parent = plat.transform;
                }

                if (powerUp == 2)
                {
                    jumpPU.transform.position = new Vector3(Random.Range(-2, 3), 1, Random.Range(-20, 21));
                    GameObject PU = Instantiate(jumpPU, nextPlatformPos + jumpPU.transform.position, Quaternion.identity);
                    PU.transform.parent = plat.transform;
                }

                if (powerUp == 3)
                {
                    slowPU.transform.position = new Vector3(Random.Range(-2, 3), 1, Random.Range(-20, 21));
                    GameObject PU = Instantiate(slowPU, nextPlatformPos + slowPU.transform.position, Quaternion.identity);
                    PU.transform.parent = plat.transform;
                }

            }

                nextPlatformPos += new Vector3(Random.Range(-2,2),Random.Range(-2,2),55);
        }
    }
}
