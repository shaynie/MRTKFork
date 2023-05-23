
using Microsoft.MixedReality.Toolkit.Examples;
using System;
using UnityEngine;
using UnityEngine.Events;

public class EyeCalibrationTextChanger : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshPro calibrationText;
    [SerializeField]
    private EyeCalibrationChecker eyeCalibrationChecker;


    private void OnEnable()
    {
        eyeCalibrationChecker.OnEyeCalibrationDetected.AddListener(() => { UpdateCalibrationText(true); });
        eyeCalibrationChecker.OnNoEyeCalibrationDetected.AddListener(()=> { UpdateCalibrationText(false); });
    }

    private void UpdateCalibrationText(bool calibrated)
    {
        calibrationText.text = $"Calibrated: {calibrated}";
    }
}
