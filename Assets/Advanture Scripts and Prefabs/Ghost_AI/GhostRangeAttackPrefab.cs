using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostRangeAttackPrefab : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private int damageDone = -20;
    private Transform player;
    private Vector2 target;

    //public GameObject explodeEffect;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        //StartCoroutine(ExplodeAfterDuration());
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player_Knight_Advanturer"))
        {
            HealthKnightAdvanturer eHealth = other.gameObject.GetComponent<HealthKnightAdvanturer>();
            eHealth.ModifyHealth(damageDone);
            DestroyProjectile();
        }
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
    //IEnumerator ExplodeAfterDuration()
    //{
    //    yield return new WaitForSeconds(.5f);
    //    Instantiate(explodeEffect, target, Quaternion.identity);
    //}
}
