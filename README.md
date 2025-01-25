# KeyRemap - Windows Key Remapping Utility ⌨️
KeyRemap ⌨️ is a .NET desktop application that enables users to remap keyboard keys via the Windows Registry, providing a simplified interface for customizing key mappings.

## NEW GUI VERSION!
![image](https://github.com/user-attachments/assets/65974d32-6ce1-4f74-afb3-6711ea41e186)

## Features
Remap Keys: Choose a key to remap and assign it to another key.
Permanent Key Remapping: Changes are applied system-wide and persist after restarting.

## How It Works
The application leverages the Windows Registry to apply key mappings. It writes the scancode map in the registry, which the system loads during startup, effectively remapping keys at the hardware level.

#### Key Functionalities:
Scancode Map: The application modifies the scancode map, which instructs Windows to treat one key's input as another.
Registry Manager: Handles the writing and resetting of key mappings in the Windows Registry.
Command Parser: Accepts command-line arguments to trigger different functions like remapping keys or resetting mappings.

## Prerequisites
1. `.NET 6.0 SDK` or later
2. `Windows Operating System`

## Installation
1. Clone this repository to your local machine:
```
git clone https://github.com/jordonkane/KeyRemap.git
```
2. Navigate into the project directory::
```
cd KeyRemap
```
3. Build the solution:
```
dotnet build
```

## Usage
Once the application is built, you can run it from the command line with the following commands:

#### Remap a Key
To remap a key, use the `remap` command. The program will prompt you to press the key you want to remap and enter the key you want to map it to.
```
keyremap.exe remap
```
#### Command Help
If no arguments are passed, the program will display the help instructions:
```
keyremap.exe
```

## Supported Keys
Here are the supported keys and their corresponding scancodes and byte array representations:
| Key         | Scancode | Byte Array  |
|-------------|----------|-------------|
| `A`         | 0x1E     | `1E 00`     |
| `B`         | 0x30     | `30 00`     |
| `C`         | 0x2E     | `2E 00`     |
| `D`         | 0x20     | `20 00`     |
| `E`         | 0x12     | `12 00`     |
| `F`         | 0x21     | `21 00`     |
| `G`         | 0x22     | `22 00`     |
| `H`         | 0x23     | `23 00`     |
| `I`         | 0x17     | `17 00`     |
| `J`         | 0x24     | `24 00`     |
| `K`         | 0x25     | `25 00`     |
| `L`         | 0x26     | `26 00`     |
| `M`         | 0x32     | `32 00`     |
| `N`         | 0x31     | `31 00`     |
| `O`         | 0x18     | `18 00`     |
| `P`         | 0x19     | `19 00`     |
| `Q`         | 0x10     | `10 00`     |
| `R`         | 0x13     | `13 00`     |
| `S`         | 0x1F     | `1F 00`     |
| `T`         | 0x14     | `14 00`     |
| `U`         | 0x16     | `16 00`     |
| `V`         | 0x2F     | `2F 00`     |
| `W`         | 0x11     | `11 00`     |
| `X`         | 0x2D     | `2D 00`     |
| `Y`         | 0x15     | `15 00`     |
| `Z`         | 0x2C     | `2C 00`     |
| `1`         | 0x02     | `02 00`     |
| `2`         | 0x03     | `03 00`     |
| `3`         | 0x04     | `04 00`     |
| `4`         | 0x05     | `05 00`     |
| `5`         | 0x06     | `06 00`     |
| `6`         | 0x07     | `07 00`     |
| `7`         | 0x08     | `08 00`     |
| `8`         | 0x09     | `09 00`     |
| `9`         | 0x0A     | `0A 00`     |
| `0`         | 0x0B     | `0B 00`     |
| `Space`     | 0x39     | `39 00`     |
| `Enter`     | 0x1C     | `1C 00`     |
| `Esc`       | 0x01     | `01 00`     |
| `Tab`       | 0x0F     | `0F 00`     |
| `Backspace` | 0x0E     | `0E 00`     |
| `LeftShift` | 0x2A     | `2A 00`     |
| `RightShift`| 0x36     | `36 00`     |
| `LeftCtrl`  | 0x1D     | `1D 00`     |
| `RightCtrl` | 0x1D     | `1D 00`     |
| `LeftAlt`   | 0x38     | `38 00`     |
| `RightAlt`  | 0x38     | `38 00`     |
| `CapsLock`  | 0x3A     | `3A 00`     |
| `F1`        | 0x3B     | `3B 00`     |
| `F2`        | 0x3C     | `3C 00`     |
| `F3`        | 0x3D     | `3D 00`     |
| `F4`        | 0x3E     | `3E 00`     |
| `F5`        | 0x3F     | `3F 00`     |
| `F6`        | 0x40     | `40 00`     |
| `F7`        | 0x41     | `41 00`     |
| `F8`        | 0x42     | `42 00`     |
| `F9`        | 0x43     | `43 00`     |
| `F10`       | 0x44     | `44 00`     |
| `F11`       | 0x57     | `57 00`     |
| `F12`       | 0x58     | `58 00`     |


## How to Contribute
If you would like to contribute to KeyRemap, feel free to fork the repository and submit a pull request. Contributions for new features like displaying remapped keys are welcome!
1. Fork the repository.
2. Create a feature branch.
3. Push your changes.
4. Submit a pull request.

## Known Issues
- The application requires administrative privileges to modify the Windows Registry.
- Currently, there is no functionality to read remapped keys directly from the registry due to the way Windows handles scancode mappings.

## Future Features
- Add support to display remapped keys.
- Improve the user interface for a better experience (possibly with a GUI version).

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Credits
Developed by Jordon Kane
