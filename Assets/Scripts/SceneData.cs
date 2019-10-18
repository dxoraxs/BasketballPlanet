using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneData : MonoBehaviour
{
    [SerializeField] private BallMovement _ballMovement;
    [SerializeField] private SpriteRenderer _backgroundImage;
    [SerializeField] private PlanetsSettings _planetsSettings;
    [SerializeField] private GameObject _canvasObject;
    private UIChanges _uIChanges;

    private void Start()
    {
        _uIChanges = _canvasObject.GetComponent<UIChanges>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _ballMovement.ChangeRigidbodySimulated();
            _canvasObject.SetActive(!_canvasObject.activeSelf);
        }
    }

    public void OnClickButtonChangePlanet(PlanetType planet)
    {
        ChangePlanet(planet);
    }

    private void ChangePlanet(PlanetType planet)
    {
        Physics2D.gravity = _planetsSettings.Planets[(int)planet].GravityOnThePlanet;
        _backgroundImage.color = _planetsSettings.Planets[(int)planet].BackgroundColorPlanet;
    }

    public void BallHitsAdd()
    {
        _planetsSettings.BallHits++;
        _uIChanges.ChangeTextHits(_planetsSettings.BallHits);
    }
}
