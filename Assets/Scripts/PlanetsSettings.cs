using System;
using UnityEngine;

[CreateAssetMenu(fileName ="PlanetsSettings", menuName ="Create SO/Create Planet Setting")]
public class PlanetsSettings : ScriptableObject
{
    public int BallHits;
    public Planet[] Planets;
}

[Serializable]
public class Planet
{
    public Vector2 GravityOnThePlanet;
    public Color BackgroundColorPlanet;
}