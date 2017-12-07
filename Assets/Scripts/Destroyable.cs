using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour {

    public Texture2D cursorTexture;
    public float Life;
    public bool dropsItem;
    public GameObject dropedItemPrefab;

    void Start()
    {

    }

    void Update()
    {
        if(Life <= 0)
        {
            if(dropsItem)
            {
                GameObject droppedItem;
                droppedItem = Instantiate(dropedItemPrefab, transform.position, transform.rotation);
                droppedItem.SetActive(true);
            }
            Destroy(gameObject);
            OnMouseExit();
        }
    }

    public void Damage(float damage)
    {
        Life -= damage;
    }

    void OnMouseOver()
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }
    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
