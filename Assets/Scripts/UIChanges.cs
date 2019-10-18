using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIChanges : MonoBehaviour
{
    [SerializeField] private Text _ballHitsText;
    [SerializeField] private SceneData _sceneData;
    
    public void OnClickButtonPlanet(int planet)
    {
        _sceneData.OnClickButtonChangePlanet((PlanetType)planet);
    }

    public void ChangeTextHits(int setNumber)
    {
        _ballHitsText.text = "Ball hit: " + setNumber;
    }
}
public enum PlanetType
{
    Earth,
    Moon,
    Jupiter
}