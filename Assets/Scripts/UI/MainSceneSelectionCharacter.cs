using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainSceneSelectionCharacter : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) => SceneManager.LoadScene("CharacterSelection");
}
