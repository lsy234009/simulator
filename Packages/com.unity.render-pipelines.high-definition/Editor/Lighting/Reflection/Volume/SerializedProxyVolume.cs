using UnityEngine.Rendering.HighDefinition;

namespace UnityEditor.Rendering.HighDefinition
{
    class SerializedProxyVolume
    {
        public SerializedProperty root;

        public SerializedProperty shape;
        public SerializedProperty boxSize;
        public SerializedProperty sphereRadius;

        public SerializedProxyVolume(SerializedProperty root)
        {
            this.root = root;

            shape = root.Find((ProxyVolume p) => p.shape);
            boxSize = root.Find((ProxyVolume p) => p.boxSize);
            sphereRadius = root.Find((ProxyVolume p) => p.sphereRadius);
        }
    }
}
