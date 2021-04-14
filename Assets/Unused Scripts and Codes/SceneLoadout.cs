using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName = "SceneObject", menuName = "OnLoad/SceneObject", order = 0)]

public class SceneLoadout : MonoBehaviour
{
    public List<SceneObject> spawnObjects;
    public string sceneName;
}
