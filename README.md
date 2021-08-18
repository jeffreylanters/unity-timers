<div align="center">

![readme splash](https://raw.githubusercontent.com/jeffreylanters/unity-timers/master/.github/WIKI/repository-readme-splash.png)

[![license](https://img.shields.io/badge/mit-license-red.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-timers/blob/master/LICENSE.md)
[![openupm](https://img.shields.io/npm/v/nl.elraccoone.timers?label=UPM&registry_uri=https://package.openupm.com&style=for-the-badge&color=232c37)](https://openupm.com/packages/nl.elraccoone.timers/)
[![build](https://img.shields.io/badge/build-passing-brightgreen.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-timers/actions)
[![deployment](https://img.shields.io/badge/state-success-brightgreen.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-timers/deployments)
[![stars](https://img.shields.io/github/stars/jeffreylanters/unity-timers.svg?style=for-the-badge&color=fe8523&label=stargazers)](https://github.com/jeffreylanters/unity-timers/stargazers)
[![size](https://img.shields.io/github/languages/code-size/jeffreylanters/unity-timers?style=for-the-badge)](https://github.com/jeffreylanters/unity-timers/blob/master/Runtime)
[![sponsors](https://img.shields.io/github/sponsors/jeffreylanters?color=E12C9A&style=for-the-badge)](https://github.com/sponsors/jeffreylanters)
[![donate](https://img.shields.io/badge/donate-paypal-F23150?style=for-the-badge)](https://paypal.me/jeffreylanters)

We may decide to execute a function not right now, but at a certain time later. That’s called “scheduling a call”. The Timers class helps you to do so with a clean and short syntax without having to worry about enumerators.

[**Installation**](#installation) &middot;
[**Documentation**](#documentation) &middot;
[**License**](./LICENSE.md)

**Made with &hearts; by Jeffrey Lanters**

</div>

# Installation

### Using the Unity Package Manager

Install the latest stable release using the Unity Package Manager by adding the following line to your `manifest.json` file located within your project's Packages directory, or by adding the Git URL to the Package Manager Window inside of Unity.

```json
"nl.elraccoone.timers": "git+https://github.com/jeffreylanters/unity-timers"
```

### Using OpenUPM

The module is availble on the OpenUPM package registry, you can install the latest stable release using the OpenUPM Package manager's Command Line Tool using the following command.

```sh
openupm add nl.elraccoone.timers
```

# Documentation

## Syntax

```cs
using ElRaccoone.Timers;
Timers.SetTimeout(/* miliseconds */ 1000, /* callback */ () => { /* ... */ });
Timers.SetInterval(/* miliseconds */ 1000, /* callback */ () => { /* ... */ });
```

## Description

We may decide to execute a function not right now, but at a certain time later. That’s called “scheduling a call”. Note that the timers are using unscaled time.

There are two methods for it:

- setTimeout allows to run a function once after the interval of time.
- setInterval allows to run a function regularly with the interval between the runs.

## Examples

```cs
public class MyClass {
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
}
```
