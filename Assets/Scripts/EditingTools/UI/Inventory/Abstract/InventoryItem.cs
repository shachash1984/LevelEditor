#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using Elbit.Runtime;

namespace Elbit.Editor
{
    public interface IInventoryItem
    {
        string Name { get; }
        GameObject ElementPrefab { get; }
        void OnDrop();
    }

    public abstract class InventoryItem : MonoBehaviour, IInventoryItem, IDragHandler, IEndDragHandler
    {
        private const int RAYCAST_LAYER = 8;
        public virtual string Name => "BaseItem";

        [SerializeField] private GameObject elementPrefab;
        public GameObject ElementPrefab => elementPrefab;

        private static Transform environmentRoot;

        private void Start()
        {
            if (environmentRoot == null)
                environmentRoot = GameObject.Find("EnvironmentRoot").transform;

        }

        public virtual void OnDrop()
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.layer == RAYCAST_LAYER)
                {
                    GameObject newElement = Instantiate(elementPrefab, hit.point, Quaternion.identity, environmentRoot);
                    newElement.GetComponent<SceneElement>().OnCreate();
                }
            }
        }

        public IInventoryItem Item { get; set; }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            transform.localPosition = Vector3.zero;
        }
    }

    public class InventoryEventArgs : EventArgs
    {
        public InventoryEventArgs(IInventoryItem item)
        {
            Item = item;
        }

        public IInventoryItem Item;
    }

}

