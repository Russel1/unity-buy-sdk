﻿namespace Shopify.Tests {
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using System.Runtime.InteropServices;

    public class Tester : MonoBehaviour {
        [DllImport ("__Internal")]
        protected static extern void _TesterObjectFinishedLoading();

        void Start () {
            _TesterObjectFinishedLoading();
        }
    }
}