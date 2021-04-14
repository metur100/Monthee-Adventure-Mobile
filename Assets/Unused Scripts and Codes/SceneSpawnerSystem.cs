using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "SceneObject", menuName = "OnLoad/SceneObject", order = 0)]

public class SceneSpawnerSystem : MonoBehaviour
{
    public List<SceneLoadout> loadouts;

// protected override void Initialize()
// {
//     base.Initialize();
//
//     SceneManager.sceneLoaded += delegate { SpawnSceneObject(); };
// }

    public void SpawnSceneObject()
    {
        SceneLoadout foundLoadout = loadouts.Find(x => x.sceneName == SceneManager.GetActiveScene().name);
        if (foundLoadout)
        {
            foreach(SceneObject obj in foundLoadout.spawnObjects)
            {
                GameObject.Instantiate(obj.prefab, obj.spawnPosition, obj.spawnRotation);
            }
        }
    }
}
