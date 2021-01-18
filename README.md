# dynamic-content-processor
An overview of how to use reflection and assembly loading to handle dynamic content.

This solution uses .NET Reflection to handle registration of types with base-class objects.  Each of the objects are registered with a base object by the processor system.  This eliminates the need for Interfaces or forward type declaration.  For this example, there is no manager class that needs to be defined that has to know about the 2D and 3D shapes, and the various properties that they have.  A generic method on the base class can then be used to get the individual objects if needed.

To extend on this functionality, each of these items can then have additional configuration options for whether they are enabled, which can rely on configuration settings in a file and/or database.  

To see how the output changes, add or remove the following assemblies from the **Configuration Manager** in the **Build** menu.
- ProgramOutput.ConsoleOutput: Remove this item to disable writing content to the console window.
- ProgramOutput.FileOutput: Remove this item to disable writing content to text files.
- Shapes.2D: Remove this item to not register two-dimensional shapes.
- Shapes.3D: Remove this item to not register three-dimensional shapes.

The solution is broken up into multiple assemblies:

#### LaunchProcessor

This is the console application that will run.  It contains the base **DynamicContentProcessor** and the **DynamicContentProcessor** for the output types.

#### ProgramOutput.ConsoleOutput

This assembly defines the output type for the console output. 

#### ProgramOutput.FileOutput

This assembly defines the output type for the file output.

#### ShapeProcessor

Contains the base shape class, the processor for shape objects, and attribute use to register new shapes.

#### Shapes.2D

Contains the base 2-D shape class, and several sample 2-D shapes.

#### Shapes.3D

Contains the base 3-D shape class, and two sample 3-D shapes.
