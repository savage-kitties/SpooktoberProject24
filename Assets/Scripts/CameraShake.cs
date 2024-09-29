using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    public CinemachineVirtualCamera CinemachineVirtualCamera; // Set this in the Inspector
    public float ShakeIntensity = 1f; // Intensity of the shake
    public float ShakeTime = 0.2f; // Duration of the shake
    private float Timer;
    private CinemachineBasicMultiChannelPerlin _cbmcp;

    private void Start()
    {
        // Ensure Cinemachine camera is referenced correctly
        if (CinemachineVirtualCamera != null)
        {
            _cbmcp = CinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        }
        StopShake(); // Stop shake at start
    }

    // Method to trigger the camera shake, callable from Animation Events
    public void ShakeCamera()
    {
        if (_cbmcp != null)
        {
            _cbmcp.m_AmplitudeGain = ShakeIntensity;
            Timer = ShakeTime;
            StartCoroutine(StopShakeAfterTime());
            Debug.Log("Cinemachine Virtual Camera found and Perlin noise component assigned.");
        }
    }

    // Coroutine to stop shake after a specified duration
    private IEnumerator StopShakeAfterTime()
    {
        yield return new WaitForSeconds(Timer);
        StopShake();
    }

    // Reset shake parameters
    private void StopShake()
    {
        if (_cbmcp != null)
        {
            _cbmcp.m_AmplitudeGain = 0f;
            Timer = 0;
        }
    }
}