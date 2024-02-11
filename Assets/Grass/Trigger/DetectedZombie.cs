using System.Collections.Generic;
using UnityEngine;

public class DetectedZombie : MonoBehaviour
{
    private readonly string ZombieTag = "Zombie";

    private bool _isDetected;
    public List<GameObject> _zombies = new();

    public bool IsDetected => _isDetected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(ZombieTag))
            _zombies.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(ZombieTag))
            _zombies.Remove(other.gameObject);
    }

    private void Update()
    {
        if (_zombies.Count > 0)
        {
            _isDetected = true;
        }
        else
        {
            _isDetected = false;
        }
    }

    public void SetDetected(bool isDetected)
    {
        _isDetected = isDetected;
    }

    public void RemoveZombie(GameObject zombie)
    {
        _zombies.Remove(zombie);
    }
}
