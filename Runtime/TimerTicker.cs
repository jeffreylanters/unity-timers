using System;
using System.Collections;
using UnityEngine;

namespace ElRaccoone.Timers {
  public class TimerTicker : MonoBehaviour {
    public IEnumerator EnumerateSetTimeout (int miliseconds, Action callback) {
      yield return new WaitForSecondsRealtime (miliseconds / 1000f);
      callback ();
    }

    public IEnumerator EnumerateSetInterval (int miliseconds, Action callback) {
      yield return new WaitForSecondsRealtime (miliseconds / 1000f);
      callback ();
      this.StartCoroutine (this.EnumerateSetInterval (miliseconds, callback));
    }
  }
}
