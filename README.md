# C# Race Condition Example

This repository demonstrates a simple example of a race condition in a C# multithreaded application.  A race condition occurs when multiple threads try to access and modify the same shared resource (in this case, the `MyProperty` integer) concurrently without proper synchronization mechanisms.  This can lead to unexpected and inconsistent results.

## The Problem

The `ExampleClass` has a method `MyMethod` that increments `MyProperty`. If multiple threads call this method simultaneously, the final value of `MyProperty` might not be what you expect.  The increment operation (read, add one, write back) is not atomic; it can be interrupted by another thread, leading to data loss.

## The Solution

The solution involves using synchronization primitives such as `lock` statements or other thread-safe constructs to ensure that only one thread accesses the shared resource at a time. The solution file provides a corrected version.