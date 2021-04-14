using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell
{
    private string name;
    private float castTime;
    private Color32 color;

    public Spell(string name, float castTime, Color32 color)
    {
        this.name = name;
        this.castTime = castTime;
        this.color = color;
    }

    public float myCastTime {
        get { return castTime; }
    }
    public Color32 myColor
    {
        get { return color; }
    }
}
