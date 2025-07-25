# QuaternionChecker

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/jiuya/QuaternionChecker)

A Unity project for visualizing and testing quaternion rotations. This tool helps developers understand quaternion behavior and debug rotation-related issues in Unity applications.

## Overview

QuaternionChecker provides a visual environment for experimenting with quaternion rotations in Unity. It includes tools for animating rotations, visualizing coordinate systems, and understanding how quaternions affect object transformations.

## Features

- **Quaternion Animation**: Smooth interpolation between rotation states using `Quaternion.Slerp`
- **World Axis Visualization**: Visual gizmos showing X, Y, Z coordinate axes
- **Real-time Position Tracking**: Debug output for monitoring object transformations
- **Interactive Rotation Control**: Ability to modify end rotations through string input

## Main Components

### Scripts

- **`RotateAnime.cs`**: Handles quaternion rotation animations
  - Animates objects between start and end rotations
  - Supports custom journey time and rotation targets
  - Includes string-based rotation input for testing
  
- **`WorldAxis.cs`**: Provides coordinate system visualization
  - Draws colored gizmos for X (red), Y (green), Z (blue) axes
  - Configurable axis size
  
- **`SceneViewCamera.cs`**: Camera control utilities for scene navigation
  
- **`GridDraw.cs`**: Grid visualization for spatial reference

## Setup

1. **Requirements**: Unity 2022.3.0f1 or later
2. **Installation**: Clone this repository and open the project in Unity
3. **Usage**: 
   - Open the main scene in `Assets/Scenes/`
   - Play the scene to see quaternion animations in action
   - Use the Scene view to observe gizmo visualizations
   - Monitor the Console for real-time position output

## Usage Examples

### Basic Rotation Animation
The `RotateAnime` component automatically animates between a start rotation (0°, 0°, 0°) and end rotation (0°, 180°, 0°) over a configurable time period.

### Custom Rotation Input
You can modify the end rotation by calling `ChangeEndRotationString()` with a comma-separated quaternion string:
```csharp
rotateAnime.ChangeEndRotationString("0,0.707,0,0.707"); // 90° Y rotation
```

### Coordinate Visualization
Add the `WorldAxis` component to any GameObject to visualize its local coordinate system in the Scene view.

## Development

This project serves as both a learning tool and debugging utility for Unity developers working with quaternions and 3D rotations.

## License

Please refer to the repository license for usage terms.