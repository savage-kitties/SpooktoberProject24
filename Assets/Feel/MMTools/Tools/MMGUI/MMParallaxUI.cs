using System;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.Tools
{
    public class MMParallaxUI : MonoBehaviour
    {
        [Serializable]
        public class ParallaxLayer
        {
            public RectTransform Rect;    // The RectTransform for this layer
            public float Speed = 2f;      // Speed of parallax motion
            public float Amplitude = 50f; // Maximum distance this layer can travel
            public bool Active = true;    // Toggle for enabling/disabling this layer
            [HideInInspector]
            public Vector3 StartPosition; // Starting position for the layer in world space
        }

        public enum Modes { Mouse, Gyroscope, Script }
        public Modes Mode = Modes.Mouse;

        [Header("General Settings")]
        public float AmplitudeMultiplier = 1f;
        public float SpeedMultiplier = 1f;
        public List<ParallaxLayer> ParallaxLayers;

        [Header("Camera Settings")]
        public Camera ParallaxCamera; // Custom camera reference for parallax calculations
        public float ZOffset = 0.1f;  // Z-Offset to prevent visual conflicts

        private Vector2 _referencePosition;
        private Vector3 _newPosition;
        private Vector2 _mousePosition;

        /// Initializes all layers at startup.
        protected virtual void Start()
        {
            Initialization();
        }

        /// Initializes the start position of each parallax layer.
        public virtual void Initialization()
        {
            if (ParallaxCamera == null)
            {
                ParallaxCamera = Camera.main; // Fallback to Camera.main if no custom camera is assigned
                //Debug.LogWarning("No camera assigned to MMParallaxUI. Defaulting to Camera.main.");
            }

            foreach (ParallaxLayer layer in ParallaxLayers)
            {
                // Store the start position in *local* coordinates, to avoid world-space displacement issues
                layer.StartPosition = layer.Rect.localPosition;
            }
        }

        /// Updates layer positions every frame.
        protected virtual void Update()
        {
            MoveLayers();
        }

        /// Moves each layer according to the selected control mode.
        protected virtual void MoveLayers()
        {
            // Calculate the reference position based on the chosen input mode
            switch (Mode)
            {
                case Modes.Gyroscope:
                    _referencePosition = MMGyroscope.CalibratedInputAcceleration;
                    break;
                case Modes.Mouse:
                    _mousePosition = Input.mousePosition;
                    if (ParallaxCamera != null)
                    {
                        _referencePosition = ParallaxCamera.ScreenToViewportPoint(_mousePosition);
                    }
                    break;
            }

            // Move each parallax layer based on the reference position
            foreach (ParallaxLayer layer in ParallaxLayers)
            {
                if (layer.Active)
                {
                    // Compute the new local position relative to the starting local position
                    _newPosition.x = Mathf.Lerp(layer.Rect.localPosition.x, layer.StartPosition.x + _referencePosition.x * layer.Amplitude * AmplitudeMultiplier, layer.Speed * SpeedMultiplier * Time.deltaTime);
                    _newPosition.y = Mathf.Lerp(layer.Rect.localPosition.y, layer.StartPosition.y + _referencePosition.y * layer.Amplitude * AmplitudeMultiplier, layer.Speed * SpeedMultiplier * Time.deltaTime);
                    
                    // Ensure Z remains the same relative to the canvas' local position, not world space
                    _newPosition.z = layer.StartPosition.z;

                    // Apply the new local position back to the RectTransform
                    layer.Rect.localPosition = _newPosition;

                    // Debug log for checking positions
                    //Debug.Log($"Layer {layer.Rect.name} Local Position: {_newPosition}");
                }
            }
        }

        /// Sets a new reference position, to be used when in Script mode.
        public virtual void SetReferencePosition(Vector3 newReferencePosition)
        {
            _referencePosition = newReferencePosition;
        }
    }
}