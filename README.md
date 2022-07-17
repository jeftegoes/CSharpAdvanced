# C# Advanced <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. Delagates](#1-delagates)
- [2. Events and Delegates](#2-events-and-delegates)
- [Nullable types](#nullable-types)

## 1. Delagates

- An object that knows hot to call a method (or a group of methods).
- A reference to a function.
- Why we need Delegates?
  - For designing extensible and flexible application (e.g. frameworks).
- Alternative: Interfaces.
- Interfaces or Delegates? Use a delegate when:
  - An eventing design pattern is used.
  - The caller doesn't need to access other properties or methods on the object implementing the method.
- [Delegate example](Delegates/)

## 2. Events and Delegates

- A mechanism for communication between objects.
- Used in building _Loosely Coupled Application_.
- Helps extending application.
- [Events and Delegates example](EventsAndDelegates/)

## Nullable types

- This expression `DateTime date = null;` don't be possible, because DateTime is a value type, and value type cannot be null.
- `Nullable<DateTime> date = null;` is a generic structure defined in the System namespace.
- The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null; otherwise, it evaluates the right-hand operand and returns its result. The ?? operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
- [Nullable types example](NullableTypes/)