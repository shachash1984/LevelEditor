using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Elbit.Editor
{
    public class Inventory : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            RectTransform invPanel = transform as RectTransform;

            if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, eventData.position))
            {
                eventData.selectedObject.GetComponentInChildren<InventoryItem>().OnDrop();
            }
        }
    }
}

