using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : ScriptableObject
{
    public new string name;
    public Sprite icon;
    public float mana;

    public abstract void Execute(GameObject gameObject);
}
