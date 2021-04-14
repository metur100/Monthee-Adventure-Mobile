using System.Collections;
using UnityEngine;

namespace Assets.Advanture_Scripts_and_Prefabs.Inventory_Level_2
{
    public class InstantiateBox : MonoBehaviour
    {
        public GameObject prefabBox;
        public Transform player;
        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
        }
        public void Use()
        {
            if (player != null)
            {
                FindObjectOfType<AudioManager>().Play("Box_Item");
                Instantiate(prefabBox, player.transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}