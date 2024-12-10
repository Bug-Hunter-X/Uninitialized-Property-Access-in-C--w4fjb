# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing a property before it has been initialized.  This can lead to unexpected behavior or exceptions, depending on the context.

## The Problem

In C#, class properties are not automatically initialized to a default value if you don't provide an initial value in the constructor or property declaration.  Accessing such a property can lead to unpredictable values or exceptions.  This is especially problematic with value types (like `int`, `bool`, etc.) as they may contain garbage values before being assigned.

## The Solution

To prevent this, always initialize properties in the class constructor or provide an explicit default value in the property declaration.  Make sure you assign a value before reading the property.