using UnityEngine;

public class FreezeXPosition : MonoBehaviour
{
    public Transform targetObject; // Takip edilecek obje

    void Update()
    {
        
            // Takip edilecek objenin Y pozisyonunu al
            float targetY = targetObject.position.y;

            // Objeyi yeni pozisyon ile güncelle
            transform.position = new Vector3(transform.position.x, targetY, transform.position.z);

            // Sadece X ekseni üzerinde döndürme
            transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        
    }
}