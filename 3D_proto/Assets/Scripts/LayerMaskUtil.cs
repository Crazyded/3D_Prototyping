using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerMaskUtil
{
    public static bool ContainsLayer (LayerMask layerMask, 
        int layer)
    {
        return (layerMask.value & 1 << layer) > 0;
    }
}
