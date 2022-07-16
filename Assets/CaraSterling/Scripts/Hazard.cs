using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class Hazard : MonoBehaviour
{
    [SerializeField] private float m_topSpeedModifier = 1.0f;
    [SerializeField] private float m_accelerationModifier = 1.0f;
    [SerializeField] private bool m_driftingAllowed = true;

    [SerializeField] private GameObject m_KartClassicPlayer;
    private ArcadeKart m_AKScript;

    private void Start()
    {
        m_AKScript = m_KartClassicPlayer.GetComponent<ArcadeKart>();
    }
    public virtual void OnCollisionEnter(Collision collision)
    {
        // set modifiers in Arkade Kart script to affect top speed, acceleration and ability to drift

        m_AKScript.topSpeedModifier = m_topSpeedModifier;
        m_AKScript.accelerationModifier = m_accelerationModifier;
        m_AKScript.driftingAllowed = m_driftingAllowed;

    }

    public virtual void OnCollisionExit(Collision collision)
    {
        // return modifiers to default values where they will have no effect

        m_AKScript.topSpeedModifier = 1.0f;
        m_AKScript.accelerationModifier = 1.0f;
        m_AKScript.driftingAllowed = true;
    }
}
