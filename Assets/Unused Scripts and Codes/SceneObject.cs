using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SceneObject", menuName = "OnLoad/SceneObject", order = 0)]

public class SceneObject : ScriptableObject
{
    public GameObject prefab;
    public Vector2 spawnPosition;
    public Quaternion spawnRotation;
}
