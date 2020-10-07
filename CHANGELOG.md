# Changelog
All notable changes to this project will be documented in this file.

## [1.0.5] - 2020-10-07

### Changed

- Library versions for this version
  
|Library|Version|Description|
|:------|:------|:----------|
|iTin.Core| **2.0.0.0** | Base library containing various extensions, helpers, common constants |
|iTin.Core.Hardware.Common| **1.0.0.0** | Common Hardware Infrastructure |
|iTin.Core.Hardware.Specification.Eedid|**1.0.0.5**| Implementation of the E-EDID (Extended Display Identification Data) specification |
|iTin.Logging| **1.0.0.0** | Logging library |

### Removed

- Remove unnecessary libraries (for now).

- The **Properties** property in data sections, now use **GetProperty(IPropertyKey)** methods with **ImplementedProperties**.
    
     - Please see sample project for see how to use.

## [1.0.4] - 2020-07-31

### Fixed

- Fixed the bug reported by [@nk64](https://https://github.com/nk64), please see https://github.com/iAJTin/iEEDID/issues/1 for more information.

### Changed

- Minor changes.

- Adds descriptive code help. I Tried to adds a help most descriptive for the properties keys. 
 
  - The image below shows an example.

    ![Help.png][helpimg] 

- Library versions for this version
  
|Library|Version|Description|
|:------|:------|:----------|
|iTin.Core| **1.0.2** | Common calls |
|iTin.Core.Interop| 1.0.0 | Interop calls |
|iTin.Core.Hardware| **1.0.1** | Hardware Interop Calls |
|iTin.Core.Hardware.Specification.Eedid|**1.0.4**| E-EDID Specification Implementation |


## [1.0.3] - 2019-09-02

### Added

- **iTin.Core.Interop**:
  - Many structures, enumerations, win32 native methods have been added to project, for video cards, video modes, monitors, storage, etc ...

- **iTin.Core.Hardware.Specification.Eedid**: 
  - Two new properties have been added (to meet the specification),
    1. WeekOfManufactureOrModelYearFlag
    2. YearOfManufactureOrModelYear

- Minor changes. 

### Changed

- **iTin.Core.Hardware**: 
- Due to a problem with duplicate properties of the same type, the data type for storing the properties has been changed. (This change should not affect current behavior).

### Fixed

- **iTin.Core.Hardware.Specification.Eedid**: 
  - Fixed an issue that did not allow you to correctly calculate the value of the property **ManufactureDate** of the section **Vendor**

  - Fixed an issue that did not allow the property value **IdSerialNumber** of the **Vendor** section to be calculated correctly

## [1.0.2] - 2019-08-28

### Added

- Added **iEEDID.ConsoleAppCore** netcoreapp console app project. 

      \root
        - lib
          - iTin.Core             
            - iTin.Core                                [Common Calls] 
            - iTin.Core.Interop                        [Interop Calls]
          - iTin.Core.Hardware    
            - iTin.Core.Hardware                       [Hardware Interop Calls]
          - iTin.Core.Hardware.Specification   
            - iTin.Core.Hardware.Specification.Eedid   [E-EDID Specification Implementation] 
        - test
            - iEEDID.ConsoleApp                        [Console Test App]
            - iEEDID.ConsoleAppCore                    [NetCoreApp Console Test App]

- Minor changes. 

### Changed

- The solution has been migrated to **.NetStandard**.

  - The supported targets are:

        .NetFramework > = 4.0
        .NetStandard > = 2.0
        .NetCoreapp > = 2.0

## [1.0.1] - 2019-08-23

### Added
-  Assemblies with strong naming.

## [1.0.0] - 2019-08-22

### Added
- Create project and first commit

[1.0.5]: https://github.com/iAJTin/iEEDID/releases/tag/v1.0.5
[1.0.4]: https://github.com/iAJTin/iEEDID/releases/tag/v1.0.4
[1.0.3]: https://github.com/iAJTin/iEEDID/releases/tag/v1.0.3
[1.0.2]: https://github.com/iAJTin/iEEDID/releases/tag/v1.0.2
[1.0.1]: https://github.com/iAJTin/iEEDID/releases/tag/v1.0.1
[1.0.0]: https://github.com/iAJTin/iEEDID/releases/tag/v1.0.0

[helpimg]: ./assets/helpimg.png "help"

