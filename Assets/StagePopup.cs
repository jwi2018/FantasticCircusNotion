using System.Collections;
using System.Collections.Generic;
using EnhancedScrollerCustom.StageScroll;
using UnityEngine;

public class StagePopup : MonoBehaviour
{
    public void OpenEnd()
    {
        var controller = transform.GetComponentInChildren<StageScrollController>();
        if (controller != null)
        {
            controller.StageOpening = true;
        }
    }

    public void CloaseStart()
    {
        var controller = transform.GetComponentInChildren<StageScrollController>();
        if (controller != null)
        {
            controller.StageOpening = false;
        }
    }
}
