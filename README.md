# Time Switch Ability

A Unity gameplay ability that allows the player to switch an environment between three time states: Present, Past, and Future.

The system uses a central state manager to control the current time state and update environment objects accordingly. Objects can be configured to appear or disappear depending on the selected state, creating a foundation for time-based puzzles and environmental gameplay mechanics.

## Features

- **Three time states:** Switch between Present, Past, and Future.
- **Input-based switching:** Trigger state changes using a configurable keyboard key.
- **Environment state management:** Control environment objects based on the active time state.
- **Object visibility:** Enable or disable renderers to change which objects are visible.
- **Collision control:** Enable or disable colliders alongside object visibility.
- **UI feedback:** Display the current time state on screen.
- **ScriptableObject configuration:** Define environment state settings independently from the manager.

## How it works

The `EnvironStateInput` component listens for the configured input key and forwards the request to `EnvironmentStateManager`.

The manager cycles through the available `TimeState` values:

- Present
- Past
- Future

It then updates the UI and communicates with `EnvironmentObjectStateManager`, which controls the renderers and colliders of the relevant environment objects.

This allows different objects to behave differently depending on the selected time period.

## Main components

| Script | Responsibility |
|---|---|
| `EnvironmentStateManager.cs` | Controls the current time state and switching logic |
| `EnvironmentObjectStateManager.cs` | Enables and disables environment renderers and colliders |
| `EnvironStateInput.cs` | Handles the player's time-switch input |
| `EnvironStateUI.cs` | Displays the current time state |
| `EnvironStateConfig.cs` | Stores environment state configuration |
| `IEnvironmentStateManager.cs` | Defines the environment state manager contract |
| `IEnvironmentObjectStateManager.cs` | Defines the environment object management contract |
| `IEnvironStateUI.cs` | Defines the UI contract |

## Built with

- **Unity**
- **C#**
- **ScriptableObjects**
- **TextMeshPro**
- **Unity Physics**

## Getting started

Clone the repository:

```bash
git clone https://github.com/PhilipNzube/TimeSwitchAbility.git
```

Open the project through Unity Hub and allow Unity to import the required assets and packages.

The repository includes a demo scene and sample configurations for the Past and Future states.

## Setting up the ability

1. Add the `EnvironmentStateManager` component to the appropriate manager GameObject.
2. Add the `EnvironmentObjectStateManager` component to environment objects that need to change between time states.
3. Add the `EnvironStateInput` component and configure its input key.
4. Assign an `EnvironStateConfig` asset to the input component.
5. Set up the UI reference through `EnvironStateUI`.
6. Configure the environment objects and their renderers and colliders.
7. Test the switching behaviour in the demo scene.

The default switching key is **T**.

## Project contents

The main implementation is located in:

```text
Assets/TimeSwitchSystem/
├── Scenes/
├── ScriptableObjects/
└── Scripts/
```

## Notes

The current implementation provides the core switching mechanic and basic environment object control. It can be expanded with more elaborate time-based mechanics, such as changing object positions, activating different versions of a level, modifying environmental conditions, and introducing puzzles that require switching between different periods.
