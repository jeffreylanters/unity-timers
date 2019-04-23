using System;
using System.Collections;
using UnityEngine;

namespace UnityPackages {

  public static class Timers {

    private static TimerTicker _Enumerator;
    private static TimerTicker Enumerator {
      get {
        if (_Enumerator == null) {
          _Enumerator = new GameObject ("~timers")
            .AddComponent<TimerTicker> ();
          GameObject.DontDestroyOnLoad (_Enumerator);
        }
        return _Enumerator;
      }
    }

    public static void SetTimeout (int miliseconds, Action callback) {
      Enumerator.StartCoroutine (Enumerator.EnumerateSetTimeout (miliseconds, callback));
    }

    public static void SetInterval (int miliseconds, Action callback) {
      Enumerator.StartCoroutine (Enumerator.EnumerateSetInterval (miliseconds, callback));
    }
  }

  public class TimerTicker : MonoBehaviour {
    public IEnumerator EnumerateSetTimeout (int miliseconds, Action callback) {
      yield return new WaitForSeconds (miliseconds / 1000);
      callback ();
    }

    public IEnumerator EnumerateSetInterval (int miliseconds, Action callback) {
      yield return new WaitForSeconds (miliseconds / 1000);
      callback ();
      this.StartCoroutine (this.EnumerateSetInterval (miliseconds, callback));
    }
  }
}