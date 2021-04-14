using System.Collections;
using UnityEngine;

namespace Assets.Advanture_Scripts_and_Prefabs.Inventory_Level_2
{
    public class InstantiateGreenBullet : MonoBehaviour
    {
        public GameObject prefabGreenBullet;
        public Transform player;
        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
        }
        public void Use()
        {
            if (player != null)
            {
                FindObjectOfType<AudioManager>().Play("GreenBullet_Item");
                Instantiate(prefabGreenBullet, player.transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}