# arclockvase 📱 AR Object Placement App

A simple **Augmented Reality (AR) Object Placement App** built with **Unity** and **AR Foundation**.

The app detects real-world surfaces and allows users to place different 3D objects by tapping on detected planes.

## ✨ Features

- 📷 Real-world plane detection
- 👆 Tap to place AR objects
- 🟦 Detects horizontal planes
- 🧱 Detects vertical planes
- 🕐 Places a clock on horizontal surfaces
- 🏺 Places a flower vase on vertical surfaces
- 📐 Uses AR Raycasting for object placement

## 🎯 How It Works

When the user taps on the screen:

1. The app gets the touch position.
2. An AR raycast is performed.
3. The raycast detects a real-world plane.
4. The plane orientation is checked.
5. An object is placed based on the detected plane.

| Plane Type | Object |
|---|---|
| Horizontal | 🕐 Clock |
| Vertical | 🏺 Flower Vase |

## 🛠️ Technologies Used

- Unity
- C#
- AR Foundation
- AR Subsystems
- ARCore / ARKit
- XR Raycasting
- Plane Detection

## 📋 Requirements

- Unity with AR Foundation
- Android or iOS device with AR support
- ARCore supported Android device or ARKit supported iOS device
- Camera permission
