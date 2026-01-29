using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
        private ShopManager shopManager;

        private void Start()
        {
            shopManager = FindFirstObjectByType<ShopManager>();
        }

        private void OnMouseDown()
        {
            print("test");
            shopManager.OpenShop(this);
        }


}
