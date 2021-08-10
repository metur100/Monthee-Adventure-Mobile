using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallKnight : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damageDoneFireB;
    [SerializeField]
    private float speedOfFireBall = 200f;
    [SerializeField]
    private GameObject impactEffect;
    void Start()
    {
        rb.velocity = transform.right * speedOfFireBall;
        Physics2D.IgnoreLayerCollision(15, 5, true);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Slime_AI":
                SlimeHealthPatrol eHealth = other.gameObject.GetComponent<SlimeHealthPatrol>();
                eHealth.ModifyHealth(damageDoneFireB);
                break;
            case "Slime_AI_2":
                SlimeHealthPatrol2 eHealth1 = other.gameObject.GetComponent<SlimeHealthPatrol2>();
                eHealth1.ModifyHealth(damageDoneFireB);
                break;
            case "Slime_AI_3":
                SlimeHealthPatrol3 eHealth2 = other.gameObject.GetComponent<SlimeHealthPatrol3>();
                eHealth2.ModifyHealth(damageDoneFireB);
                break;
            case "Slime_AI_4":
                SlimeHealthPatrol4 eHealth3 = other.gameObject.GetComponent<SlimeHealthPatrol4>();
                eHealth3.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI":
                TrunkHealth eHealth4 = other.gameObject.GetComponent<TrunkHealth>();
                eHealth4.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_2":
                TrunkHealth2 eHealth5 = other.gameObject.GetComponent<TrunkHealth2>();
                eHealth5.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_3":
                TrunkHealth3 eHealth6 = other.gameObject.GetComponent<TrunkHealth3>();
                eHealth6.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_4":
                TrunkHealth4 eHealth7 = other.gameObject.GetComponent<TrunkHealth4>();
                eHealth7.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_5":
                TrunkHealth5 eHealth8 = other.gameObject.GetComponent<TrunkHealth5>();
                eHealth8.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_6":
                TrunkHealth6 eHealth9 = other.gameObject.GetComponent<TrunkHealth6>();
                eHealth9.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_7":
                TrunkHealth7 eHealth10 = other.gameObject.GetComponent<TrunkHealth7>();
                eHealth10.ModifyHealth(damageDoneFireB);
                break;
            case "Bee_AI":
                BeeHealth eHealth11 = other.gameObject.GetComponent<BeeHealth>();
                eHealth11.ModifyHealth(damageDoneFireB);
                break;
            case "Bee_AI_2":
                BeeHealth2 eHealth12 = other.gameObject.GetComponent<BeeHealth2>();
                eHealth12.ModifyHealth(damageDoneFireB);
                break;
            case "Snail_AI":
                SnailHealth eHealth13 = other.gameObject.GetComponent<SnailHealth>();
                eHealth13.ModifyHealth(damageDoneFireB);
                break;
            case "Snail_AI_2":
                SnailHealth2 eHealth14 = other.gameObject.GetComponent<SnailHealth2>();
                eHealth14.ModifyHealth(damageDoneFireB);
                break;
            case "Snail_AI_3":
                SnailHealth3 eHealth15 = other.gameObject.GetComponent<SnailHealth3>();
                eHealth15.ModifyHealth(damageDoneFireB);
                break;
            case "Snail_AI_4":
                SnailHealth4 eHealth16 = other.gameObject.GetComponent<SnailHealth4>();
                eHealth16.ModifyHealth(damageDoneFireB);
                break;
            case "Turtle_AI":
                TurtleHealth eHealth17 = other.gameObject.GetComponent<TurtleHealth>();
                eHealth17.ModifyHealth(damageDoneFireB);
                break;
            case "Turtle_AI_2":
                TurtleHealth2 eHealth18 = other.gameObject.GetComponent<TurtleHealth2>();
                eHealth18.ModifyHealth(damageDoneFireB);
                break;
            case "Turtle_AI_3":
                TurtleHealth3 eHealth19 = other.gameObject.GetComponent<TurtleHealth3>();
                eHealth19.ModifyHealth(damageDoneFireB);
                break;
            case "BlueBird_AI":
                BlueBirdHealth eHealth20 = other.gameObject.GetComponent<BlueBirdHealth>();
                eHealth20.ModifyHealth(damageDoneFireB);
                break;
            case "BlueBird_AI_2":
                BlueBirdHealth2 eHealth21 = other.gameObject.GetComponent<BlueBirdHealth2>();
                eHealth21.ModifyHealth(damageDoneFireB);
                break;
            case "BlueBird_AI_3":
                BlueBirdHealth3 eHealth22 = other.gameObject.GetComponent<BlueBirdHealth3>();
                eHealth22.ModifyHealth(damageDoneFireB);
                break;
            case "Ghost_AI":
                GhostHealth eHealth23 = other.gameObject.GetComponent<GhostHealth>();
                eHealth23.ModifyHealth(damageDoneFireB);
                break;
            case "Suprise_Box":
                SupriseBoxHealth eHealth24 = other.gameObject.GetComponent<SupriseBoxHealth>();
                eHealth24.ModifyHealth(damageDoneFireB);
                break;
            case "Suprise_Box_2":
                SupriseBoxHealth2 eHealth25 = other.gameObject.GetComponent<SupriseBoxHealth2>();
                eHealth25.ModifyHealth(damageDoneFireB);
                break;
            case "Suprise_Box_3":
                SupriseBoxHealth3 eHealth26 = other.gameObject.GetComponent<SupriseBoxHealth3>();
                eHealth26.ModifyHealth(damageDoneFireB);
                break;
            case "Bat_AI":
                BatHealth eHealth27 = other.gameObject.GetComponent<BatHealth>();
                eHealth27.ModifyHealth(damageDoneFireB);
                break;
            case "GreenPig_AI":
                GreenPigHealth eHealth28 = other.gameObject.GetComponent<GreenPigHealth>();
                eHealth28.ModifyHealth(damageDoneFireB);
                break;
            case "Plant_AI":
                PlantHealth eHealth29 = other.gameObject.GetComponent<PlantHealth>();
                eHealth29.ModifyHealth(damageDoneFireB);
                break;
            case "Plant_AI_2":
                PlantHealth2 eHealth30 = other.gameObject.GetComponent<PlantHealth2>();
                eHealth30.ModifyHealth(damageDoneFireB);
                break;
            case "Radish_AI":
                RadishHealth eHealth31 = other.gameObject.GetComponent<RadishHealth>();
                eHealth31.ModifyHealth(damageDoneFireB);
                break;
            case "Bunny_AI":
                BunnyHealth eHealth32 = other.gameObject.GetComponent<BunnyHealth>();
                eHealth32.ModifyHealth(damageDoneFireB);
                break;
            case "Mushroom_AI":
                MushroomHealth eHealth33 = other.gameObject.GetComponent<MushroomHealth>();
                eHealth33.ModifyHealth(damageDoneFireB);
                break;
            case "Mushroom_AI_2":
                MushroomHealth2 eHealth34 = other.gameObject.GetComponent<MushroomHealth2>();
                eHealth34.ModifyHealth(damageDoneFireB);
                break;
            case "Bunny_AI_2":
                BunnyHealth2 eHealth35 = other.gameObject.GetComponent<BunnyHealth2>();
                eHealth35.ModifyHealth(damageDoneFireB);
                break;
            case "Mushroom_AI_3":
                MushroomHealth3 eHealth36 = other.gameObject.GetComponent<MushroomHealth3>();
                eHealth36.ModifyHealth(damageDoneFireB);
                break;
            case "Radish_AI_3":
                RadishHealth3 eHealth37 = other.gameObject.GetComponent<RadishHealth3>();
                eHealth37.ModifyHealth(damageDoneFireB);
                break;
            case "Radish_AI_4":
                RadishHealth4 eHealth38 = other.gameObject.GetComponent<RadishHealth4>();
                eHealth38.ModifyHealth(damageDoneFireB);
                break;
            case "Mushroom_AI_4":
                MushroomHealth4 eHealth39 = other.gameObject.GetComponent<MushroomHealth4>();
                eHealth39.ModifyHealth(damageDoneFireB);
                break;
            case "Mushroom_AI_5":
                MushroomHealth5 eHealth40 = other.gameObject.GetComponent<MushroomHealth5>();
                eHealth40.ModifyHealth(damageDoneFireB);
                break;
            case "Chest_Box":
                ChestHealth eHealth41 = other.gameObject.GetComponent<ChestHealth>();
                eHealth41.ModifyHealth(damageDoneFireB);
                break;
            case "Chest_Box_2":
                ChestHealth2 eHealth42 = other.gameObject.GetComponent<ChestHealth2>();
                eHealth42.ModifyHealth(damageDoneFireB);
                break;
            case "Chest_Box_3":
                ChestHealth3 eHealth43 = other.gameObject.GetComponent<ChestHealth3>();
                eHealth43.ModifyHealth(damageDoneFireB);
                break;
            case "Bunny_AI_3":
                BunnyHealth3 eHealth44 = other.gameObject.GetComponent<BunnyHealth3>();
                eHealth44.ModifyHealth(damageDoneFireB);
                break;
            case "Bat_AI_2":
                BatHealth2 eHealth45 = other.gameObject.GetComponent<BatHealth2>();
                eHealth45.ModifyHealth(damageDoneFireB);
                break;
            case "Bat_AI_3":
                BatHealth3 eHealth46 = other.gameObject.GetComponent<BatHealth3>();
                eHealth46.ModifyHealth(damageDoneFireB);
                break;
            case "Bat_AI_4":
                BatHealth4 eHealth47 = other.gameObject.GetComponent<BatHealth4>();
                eHealth47.ModifyHealth(damageDoneFireB);
                break;
            case "Bat_AI_5":
                BatHealth5 eHealth48 = other.gameObject.GetComponent<BatHealth5>();
                eHealth48.ModifyHealth(damageDoneFireB);
                break;
            case "Bat_AI_6":
                BatHealth6 eHealth49 = other.gameObject.GetComponent<BatHealth6>();
                eHealth49.ModifyHealth(damageDoneFireB);
                break;
            case "Rino_AI":
                RinoHealth eHealth50 = other.gameObject.GetComponent<RinoHealth>();
                eHealth50.ModifyHealth(damageDoneFireB);
                break;
            case "Rino_AI_2":
                RinoHealth2 eHealth51 = other.gameObject.GetComponent<RinoHealth2>();
                eHealth51.ModifyHealth(damageDoneFireB);
                break;
            case "Rino_AI_3":
                RinoHealth3 eHealth52 = other.gameObject.GetComponent<RinoHealth3>();
                eHealth52.ModifyHealth(damageDoneFireB);
                break;
            case "Rino_AI_4":
                RinoHealth4 eHealth53 = other.gameObject.GetComponent<RinoHealth4>();
                eHealth53.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_8":
                TrunkHealth8 eHealth54 = other.gameObject.GetComponent<TrunkHealth8>();
                eHealth54.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_9":
                TrunkHealth9 eHealth55 = other.gameObject.GetComponent<TrunkHealth9>();
                eHealth55.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_10":
                TrunkHealth10 eHealth56 = other.gameObject.GetComponent<TrunkHealth10>();
                eHealth56.ModifyHealth(damageDoneFireB);
                break;
            case "Trunk_AI_11":
                TrunkHealth11 eHealth57 = other.gameObject.GetComponent<TrunkHealth11>();
                eHealth57.ModifyHealth(damageDoneFireB);
                break;
            case "Bat_AI_7":
                BatHealth7 eHealth58 = other.gameObject.GetComponent<BatHealth7>();
                eHealth58.ModifyHealth(damageDoneFireB);
                break;
            case "Bat_AI_8":
                BatHealth8 eHealth59 = other.gameObject.GetComponent<BatHealth8>();
                eHealth59.ModifyHealth(damageDoneFireB);
                break;
            case "Bat_AI_9":
                BatHealth9 eHealth60 = other.gameObject.GetComponent<BatHealth9>();
                eHealth60.ModifyHealth(damageDoneFireB);
                break;
            case "Chest_Box_4":
                ChestHealth4 eHealth61 = other.gameObject.GetComponent<ChestHealth4>();
                eHealth61.ModifyHealth(damageDoneFireB);
                break;
            case "Radish_AI_2":
                RadishHealth2 eHealth62 = other.gameObject.GetComponent<RadishHealth2>();
                eHealth62.ModifyHealth(damageDoneFireB);
                break;
            case "Mini_Ghost_AI":
                MiniGhostHealth eHealth63 = other.gameObject.GetComponent<MiniGhostHealth>();
                eHealth63.ModifyHealth(damageDoneFireB);
                break;
            case "Slime_AI_5":
                SlimeHealthPatrol5 eHealth64 = other.gameObject.GetComponent<SlimeHealthPatrol5>();
                eHealth64.ModifyHealth(damageDoneFireB);
                break;
            case "Slime_AI_6":
                SlimeHealthPatrol6 eHealth65 = other.gameObject.GetComponent<SlimeHealthPatrol6>();
                eHealth65.ModifyHealth(damageDoneFireB);
                break;
            case "Slime_AI_7":
                SlimeHealthPatrol7 eHealth66 = other.gameObject.GetComponent<SlimeHealthPatrol7>();
                eHealth66.ModifyHealth(damageDoneFireB);
                break;
            case "Slime_AI_8":
                SlimeHealthPatrol8 eHealth67 = other.gameObject.GetComponent<SlimeHealthPatrol8>();
                eHealth67.ModifyHealth(damageDoneFireB);
                break;
            case "Bee_AI_3":
                BeeHealth3 eHealth68 = other.gameObject.GetComponent<BeeHealth3>();
                eHealth68.ModifyHealth(damageDoneFireB);
                break;
            case "Bee_AI_4":
                BeeHealth4 eHealth69 = other.gameObject.GetComponent<BeeHealth4>();
                eHealth69.ModifyHealth(damageDoneFireB);
                break;
            case "Bee_AI_5":
                BeeHealth5 eHealth70 = other.gameObject.GetComponent<BeeHealth5>();
                eHealth70.ModifyHealth(damageDoneFireB);
                break;
            case "Snail_AI_5":
                SnailHealth5 eHealth71 = other.gameObject.GetComponent<SnailHealth5>();
                eHealth71.ModifyHealth(damageDoneFireB);
                break;
            case "Snail_AI_6":
                SnailHealth6 eHealth72 = other.gameObject.GetComponent<SnailHealth6>();
                eHealth72.ModifyHealth(damageDoneFireB);
                break;
            case "Snail_AI_7":
                SnailHealth7 eHealth73 = other.gameObject.GetComponent<SnailHealth7>();
                eHealth73.ModifyHealth(damageDoneFireB);
                break;
            case "Snail_AI_8":
                SnailHealth8 eHealth74 = other.gameObject.GetComponent<SnailHealth8>();
                eHealth74.ModifyHealth(damageDoneFireB);
                break;
            case "Turtle_AI_4":
                TurtleHealth4 eHealth75 = other.gameObject.GetComponent<TurtleHealth4>();
                eHealth75.ModifyHealth(damageDoneFireB);
                break;
            case "Turtle_AI_5":
                TurtleHealth5 eHealth76 = other.gameObject.GetComponent<TurtleHealth5>();
                eHealth76.ModifyHealth(damageDoneFireB);
                break;
            case "Turtle_AI_6":
                TurtleHealth6 eHealth77 = other.gameObject.GetComponent<TurtleHealth6>();
                eHealth77.ModifyHealth(damageDoneFireB);
                break;
            case "Turtle_AI_7":
                TurtleHealth7 eHealth78 = other.gameObject.GetComponent<TurtleHealth7>();
                eHealth78.ModifyHealth(damageDoneFireB);
                break;
            case "BlueBird_AI_4":
                BlueBirdHealth4 eHealth79 = other.gameObject.GetComponent<BlueBirdHealth4>();
                eHealth79.ModifyHealth(damageDoneFireB);
                break;
            case "BlueBird_AI_5":
                BlueBirdHealth5 eHealth80 = other.gameObject.GetComponent<BlueBirdHealth5>();
                eHealth80.ModifyHealth(damageDoneFireB);
                break;
            case "BlueBird_AI_6":
                BlueBirdHealth6 eHealth81 = other.gameObject.GetComponent<BlueBirdHealth6>();
                eHealth81.ModifyHealth(damageDoneFireB);
                break;
            case "BlueBird_AI_7":
                BlueBirdHealth7 eHealth82 = other.gameObject.GetComponent<BlueBirdHealth7>();
                eHealth82.ModifyHealth(damageDoneFireB);
                break;
            case "BlueBird_AI_8":
                BlueBirdHealth8 eHealth83 = other.gameObject.GetComponent<BlueBirdHealth8>();
                eHealth83.ModifyHealth(damageDoneFireB);
                break;
            case "Suprise_Box_4":
                SupriseBoxHealth4 eHealth84 = other.gameObject.GetComponent<SupriseBoxHealth4>();
                eHealth84.ModifyHealth(damageDoneFireB);
                break;
            case "Suprise_Box_5":
                SupriseBoxHealth5 eHealth85 = other.gameObject.GetComponent<SupriseBoxHealth5>();
                eHealth85.ModifyHealth(damageDoneFireB);
                break;
            case "Suprise_Box_6":
                SupriseBoxHealth6 eHealth86 = other.gameObject.GetComponent<SupriseBoxHealth6>();
                eHealth86.ModifyHealth(damageDoneFireB);
                break;
            case "Rino_AI_5":
                RinoHealth5 eHealth87 = other.gameObject.GetComponent<RinoHealth5>();
                eHealth87.ModifyHealth(damageDoneFireB);
                break;
            case "Rino_AI_6":
                RinoHealth6 eHealth88 = other.gameObject.GetComponent<RinoHealth6>();
                eHealth88.ModifyHealth(damageDoneFireB);
                break;
            case "Chicken_AI":
                ChickenHealth eHealth89 = other.gameObject.GetComponent<ChickenHealth>();
                eHealth89.ModifyHealth(damageDoneFireB);
                break;
            case "Duck_AI":
                DuckHealth eHealth90 = other.gameObject.GetComponent<DuckHealth>();
                eHealth90.ModifyHealth(damageDoneFireB);
                break;
        }
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("FireBallExplosion");
        Destroy(gameObject);
    }
}