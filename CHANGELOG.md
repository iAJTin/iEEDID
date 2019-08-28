# Changelog
All notable changes to this project will be documented in this file.

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

[1.0.2]: https://github.com/iAJTin/iEEDID/releases/tag/v1.0.2
[1.0.1]: https://github.com/iAJTin/iEEDID/releases/tag/v1.0.1
[1.0.0]: https://github.com/iAJTin/iEEDID/releases/tag/v1.0.0
