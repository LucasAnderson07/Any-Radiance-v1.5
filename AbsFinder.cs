﻿using UnityEngine;

internal class AbsFinder : MonoBehaviour {
    private GameObject _abs;
    private bool _assigned;

    private void Start() {
        AnyRadiancePrime.instance.Log("Added AbsFinder MonoBehaviour");
    }

    private void Update() {
        if (_abs == null)
        {
            _assigned = false;
            _abs = GameObject.Find("Absolute Radiance");
        }

        if (_assigned || _abs == null)
        {
            return;
        }

        _assigned = true;
        AnyRadiancePrime.instance.Log("Found the Radiance!");
        _abs.AddComponent<Abs>();
    }
}
