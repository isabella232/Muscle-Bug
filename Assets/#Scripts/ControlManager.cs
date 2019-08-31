using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.XR;
using Valve.VR;


public class ControlManager : MonoBehaviour
{
    public static SteamVR_TrackedObject controller;
    public static SteamVR_Controller.Device device;

    void Start()
    {
        controller = GetComponent<SteamVR_TrackedObject>();
        device = GetComponent<SteamVR_Controller.Device>();
    }

    void Update()
    {
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {

        }
    }
}
