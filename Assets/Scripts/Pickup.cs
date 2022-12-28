using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enum list
public enum PickupType { None, Key, Lightbulb}

public class Pickup : MonoBehaviour
{
    public PickupType pickupType;
}
