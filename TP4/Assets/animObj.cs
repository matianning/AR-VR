using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animObj : MonoBehaviour
{
    private Animation anim;
    public string animName;
    public ParticleSystem ps;
   
    void Start()
    {
        anim = GetComponent<Animation>();
        ps = GetComponent<ParticleSystem>();
        if (ps != null) ps.Stop();

    }

    void Update()
    {
    }

    public void animate()
    {
        if(anim!=null) anim.Play(animName);
        if (ps != null) ps.Play();
    }
}
