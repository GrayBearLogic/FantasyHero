using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shot", menuName = "Skills/Shot", order = 1)]
public class SkillShot : Skill
{
    public GameObject missile;
    public override void Execute(GameObject gameObject)
    {
        Transform applyingPoint = gameObject.GetComponentInChildren<ApplyingPoint>().transform;

        var missile = Instantiate(this.missile, applyingPoint.position, applyingPoint.rotation);
    }
}