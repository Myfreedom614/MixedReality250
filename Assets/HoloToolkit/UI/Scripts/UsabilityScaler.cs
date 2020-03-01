// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace HoloToolkit.Unity
{
    /// <summary>
    /// A MonoBehaviour which automatically scales an object for better usability across different devices.
    /// </summary>
    public class UsabilityScaler : StartAwareBehaviour
    {
        private Vector3 baseScale;

        protected override void OnEnableAfterStart()
        {
            base.OnEnableAfterStart();

            baseScale = transform.localScale;
            float usabilityScaleFactor = UsabilityUtilities.GetUsabilityScaleFactor(Camera.main);

            transform.localScale = (baseScale * usabilityScaleFactor);
        }

        protected override void OnDisableAfterStart()
        {
            transform.localScale = baseScale;

            base.OnDisableAfterStart();
        }
    }
}
