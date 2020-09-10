<div align="center">

<img src="https://raw.githubusercontent.com/elraccoone/unity-timers/master/.github/WIKI/logo.jpg" height="100px">

</br>

# Timers

[![npm](https://img.shields.io/badge/upm-1.1.0-232c37.svg?style=for-the-badge)]()
[![license](https://img.shields.io/badge/license-Custom-%23ecc531.svg?style=for-the-badge)](./LICENSE.md)
[![npm](https://img.shields.io/github/stars/elraccoone/unity-timers.svg?style=for-the-badge)]()
[![npm](https://img.shields.io/badge/build-passing-brightgreen.svg?style=for-the-badge)]()

We may decide to execute a function not right now, but at a certain time later. That’s called “scheduling a call”. The Timers class helps you to do so with a clean and short syntax without having to worry about enumerators.

**&Lt;**
[**Installation**](#installation) &middot;
[**Documentation**](#documentation) &middot;
[**License**](./LICENSE.md)
**&Gt;**

</br></br>

[![npm](https://img.shields.io/badge/sponsor_the_project-donate-E12C9A.svg?style=for-the-badge)](https://paypal.me/jeffreylanters)

Hi! My name is Jeffrey Lanters, thanks for checking out my modules! I've been a Unity developer for years when in 2020 I decided to start sharing my modules by open-sourcing them. So feel free to look around. If you're using this module for production, please consider donating to support the project. When using any of the packages, please make sure to **Star** this repository and give credit to **Jeffrey Lanters** somewhere in your app or game. Also keep in mind **it it prohibited to sublicense and/or sell copies of the Software in stores such as the Unity Asset Store!** Thanks for your time.

**&Lt;**
**Made with &hearts; by Jeffrey Lanters**
**&Gt;**

</br>

</div>

# Installation

Install using the Unity Package Manager. add the following line to your `manifest.json` file located within your project's packages directory.

```json
"nl.elraccoone.timers": "git+https://github.com/elraccoone/unity-timers"
```

# Documentation

## Syntax

```cs
using ElRaccoone.Timers;
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
