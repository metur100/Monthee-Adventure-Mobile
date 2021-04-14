using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffectPlayerKnight : MonoBehaviour
{
    private float timeBtwSpawns;
    public float startTimeBTwSpans;

    public GameObject echo;
    private PlayerMovementAdvanturerKnight player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerMovementAdvanturerKnight>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.normalMovementSpeed != 0)
        {
            if (timeBtwSpawns <= 0)
            {
                GameObject instance = (GameObject)Instantiate(echo, transform.position, Quaternion.identity);
                Destroy(instance, 1f);
                timeBtwSpawns = startTimeBTwSpans;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}
