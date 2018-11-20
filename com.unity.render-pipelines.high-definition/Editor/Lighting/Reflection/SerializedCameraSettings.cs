using UnityEditor.Rendering;
using UnityEngine.Experimental.Rendering.HDPipeline;

namespace UnityEditor.Experimental.Rendering.HDPipeline
{
    internal class SerializedCameraSettingsOverride
    {
        internal SerializedProperty root;

        internal SerializedProperty camera;

        public SerializedCameraSettingsOverride(SerializedProperty root)
        {
            this.root = root;

            camera = root.Find((CameraSettingsOverride p) => p.camera);
        }
    }

    internal class SerializedCameraSettings
    {
        internal SerializedProperty root;

        internal SerializedFrameSettings frameSettings;

        internal SerializedProperty physicalAperture;
        internal SerializedProperty physicalShutterSpeed;
        internal SerializedProperty physicalIso;
        internal SerializedProperty bufferClearColorMode;
        internal SerializedProperty bufferClearBackgroundColorHDR;
        internal SerializedProperty bufferClearClearDepth;
        internal SerializedProperty volumesLayerMask;
        internal SerializedProperty volumesAnchorOverride;
        internal SerializedProperty frustumMode;
        internal SerializedProperty frustumAspect;
        internal SerializedProperty frustumFarClipPlane;
        internal SerializedProperty frustumNearClipPlane;
        internal SerializedProperty frustumFieldOfView;
        internal SerializedProperty frustumProjectionMatrix;
        internal SerializedProperty cullingUseOcclusionCulling;
        internal SerializedProperty cullingCullingMask;
        internal SerializedProperty cullingInvertFaceCulling;
        internal SerializedProperty renderingPath;
        internal SerializedProperty flipYMode;

        internal SerializedCameraSettings(SerializedProperty root)
        {
            this.root = root;

            frameSettings = new SerializedFrameSettings(root.Find((CameraSettings s) => s.frameSettings));

            physicalAperture = root.FindPropertyRelative("physical.aperture");
            physicalShutterSpeed = root.FindPropertyRelative("physical.shutterSpeed");
            physicalIso = root.FindPropertyRelative("physical.iso");
            bufferClearColorMode = root.FindPropertyRelative("bufferClearing.clearColorMode");
            bufferClearBackgroundColorHDR = root.FindPropertyRelative("bufferClearing.backgroundColorHDR");
            bufferClearClearDepth = root.FindPropertyRelative("bufferClearing.clearDepth");
            volumesLayerMask = root.FindPropertyRelative("volumes.layerMask");
            volumesAnchorOverride = root.FindPropertyRelative("volumes.anchorOverride");
            frustumMode = root.FindPropertyRelative("frustum.mode");
            frustumAspect = root.FindPropertyRelative("frustum.aspect");
            frustumFarClipPlane = root.FindPropertyRelative("frustum.farClipPlane");
            frustumNearClipPlane = root.FindPropertyRelative("frustum.nearClipPlane");
            frustumFieldOfView = root.FindPropertyRelative("frustum.fieldOfView");
            frustumProjectionMatrix = root.FindPropertyRelative("frustum.projectionMatrix");
            cullingUseOcclusionCulling = root.FindPropertyRelative("culling.useOcclusionCulling");
            cullingCullingMask = root.FindPropertyRelative("culling.cullingMask");
            cullingInvertFaceCulling = root.FindPropertyRelative("invertFaceCulling");
            renderingPath = root.FindPropertyRelative("renderingPath");
            flipYMode = root.FindPropertyRelative("flipYMode");
        }
    }
}
