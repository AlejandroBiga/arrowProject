using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform spawnPoint;
    public Image miraImage;
    public Button shootButton;
    public Slider xSlider;
    public Slider ySlider;

    public float projectileForce = 10.0f;
    public float projectileMass = 1.0f;
    public float movementRange = 1.0f;

    void Start()
    {
        shootButton.onClick.AddListener(ShootProjectile);
        xSlider.onValueChanged.AddListener(OnXSliderChanged);
        ySlider.onValueChanged.AddListener(OnYSliderChanged);
    }

    

    void ShootProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);

        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        if (projectileRb != null)
        {
            projectileRb.mass = projectileMass;
        }

        projectileRb.AddForce(spawnPoint.forward * projectileForce, ForceMode.Impulse);
    }

    void OnXSliderChanged(float value)
    {
        
        float normalizedX = value * movementRange;
        Vector3 newPosition = spawnPoint.localPosition;
        newPosition.x = normalizedX;
        spawnPoint.localPosition = newPosition;

        RectTransform miraRectTransform = miraImage.rectTransform;
        Vector3 newMiraPosition = miraRectTransform.localPosition;
        newMiraPosition.x = normalizedX;
        miraRectTransform.localPosition = newMiraPosition;
    }

    void OnYSliderChanged(float value)
    {
        
        float normalizedY = value * movementRange;
        Vector3 newPosition = spawnPoint.localPosition;
        newPosition.y = normalizedY;
        spawnPoint.localPosition = newPosition;

        RectTransform miraRectTransform = miraImage.rectTransform;
        Vector3 newMiraPosition = miraRectTransform.localPosition;
        newMiraPosition.y = normalizedY;
        miraRectTransform.localPosition = newMiraPosition;
    }
}