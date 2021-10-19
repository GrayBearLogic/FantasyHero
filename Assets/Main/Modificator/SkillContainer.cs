using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillContainer : MonoBehaviour
{
    public List<Skill> skills;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            skills[0].Execute(gameObject);
        }
    }
}
