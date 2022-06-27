using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
  #region Private methods

  private void Update()
  {
    Vector3 mousePositionInPixels = Input.mousePosition;
    Vector3 mousePositionInUnits = Camera.main.ScreenToWorldPoint(mousePositionInPixels);

    Vector3 currentPosition = transform.position;
    currentPosition.x = mousePositionInUnits.x;
    transform.position = currentPosition;
  }

  #endregion
}