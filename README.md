# Timers

![](https://img.shields.io/badge/dependencies-unity--packages-%233bc6d8.svg) ![](https://img.shields.io/badge/license-MIT-%23ecc531.svg)

We may decide to execute a function not right now, but at a certain time later. That’s called “scheduling a call”. The Timers class helps you to do so with a clean and short syntax without having to worry about enumerators.

> NOTE When using this Unity Package, make sure to **Star** this repository. When using any of the packages please make sure to give credits to **Jeffrey Lanters** somewhere in your app or game. **THESE PACKAGES ARE NOT ALLOWED TO BE SOLD ANYWHERE!**

## Install

```
"com.unity-packages.timers": "git+https://github.com/unity-packages/timers"
```

[Click here to read the Unity Packages installation guide](https://github.com/unity-packages/installation)

## Syntax

```cs
Timers.SetTimeout(/* miliseconds */ 1000, /* callback */ () => { /* ... */ });
Timers.SetInterval(/* miliseconds */ 1000, /* callback */ () => { /* ... */ });
```

## Description

We may decide to execute a function not right now, but at a certain time later. That’s called “scheduling a call”.

There are two methods for it:

- setTimeout allows to run a function once after the interval of time.
- setInterval allows to run a function regularly with the interval between the runs.

## Examples

```cs
private void Awake () {
  Timers.SetTimeout(1000, () => {
    Debug.Log("A second has passed!");
  });
  Timers.SetTimeout(1000, Notifiy);
  Timers.SetInterval(2500, Notifiy);
}

private void Notify () {
  Debug.Log("Notify!!");
}
```
