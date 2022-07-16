using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud : Hazard
{
    [SerializeField] private ParticleSystem mudSpume;
    [SerializeField] private AudioSource mudSquishSource;
    
    public override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        // play sound effect of slogging through mud and start mud sploosh visual effect
        mudSpume.Play();
        mudSquishSource.Play();
    }

    public override void OnCollisionExit(Collision collision)
    {
        base.OnCollisionExit(collision);

        // stop mud sound effect and mud sploosh visual effect
        mudSpume.Stop();
        mudSquishSource.Stop();
    }
}
