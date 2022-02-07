using UnityEngine;
using UnityEngine.Events;

public class Box : MonoBehaviour
{
  public UnityEvent openBoxEvent;

  public void Open()
  {
    openBoxEvent?.Invoke();
  }
}
