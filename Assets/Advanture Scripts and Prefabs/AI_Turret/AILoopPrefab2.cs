using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AILoopPrefab2 : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    [SerializeField]
    float speed;
    [SerializeField]
    Rigidbody2D bulletRB;
    public int damageDone = -20;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroyBullet());
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Target_AI_2");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Knight_Advanturer")
        {
            HealthKnightAdvanturer eHealth = other.gameObject.GetComponent<HealthKnightAdvanturer>();
            eHealth.ModifyHealth(damageDone);
        }
    }
    IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(1.85f);
        Destroy(gameObject);
    }
}